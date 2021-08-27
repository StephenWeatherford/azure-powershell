﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models;
using Microsoft.Azure.Commands.Synapse.Models.Auditing;
using Microsoft.Azure.Commands.Synapse.Properties;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.Azure.Management.Synapse.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Synapse
{
    [Cmdlet(VerbsLifecycle.Enable, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.Sql + SynapseConstants.AdvancedDataSecurity,
        DefaultParameterSetName = EnableByNameParameterSet, SupportsShouldProcess = true)]
    [Alias("Enable-AzSynapseSqlAdvancedThreatProtection")]
    [OutputType(typeof(WorkspaceAdvancedDataSecurityPolicy))]
    public class EnableAzureSynapseSqlAdvancedDataSecurity : SynapseManagementCmdletBase
    {
        private const string EnableByNameParameterSet = "EnableByNameParameterSet";
        private const string EnableByInputObjectParameterSet = "EnableByInputObjectParameterSet";
        private const string EnableByResourceIdParameterSet = "EnableByResourceIdParameterSet";

        [Parameter(ParameterSetName = EnableByNameParameterSet, Mandatory = false,
            HelpMessage = HelpMessages.ResourceGroupName)]
        [ResourceGroupCompleter()]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = EnableByNameParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceName)]
        [ResourceNameCompleter(ResourceTypes.Workspace, nameof(ResourceGroupName))]
        [ValidateNotNullOrEmpty]
        public string WorkspaceName { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = EnableByInputObjectParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceObject)]
        [ValidateNotNull]
        public PSSynapseWorkspace InputObject { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = EnableByResourceIdParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.DoNotConfigureVulnerabilityAssessment)]
        [ValidateNotNullOrEmpty]
        public SwitchParameter DoNotConfigureVulnerabilityAssessment { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.DeploymentName)]
        [ValidateNotNullOrEmpty]
        public string DeploymentName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.AsJob)]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.InputObject))
            {
                var resourceIdentifier = new ResourceIdentifier(this.InputObject.Id);
                this.ResourceGroupName = resourceIdentifier.ResourceGroupName;
                this.WorkspaceName = this.InputObject.Name;
            }

            if (this.IsParameterBound(c => c.ResourceId))
            {
                var resourceIdentifier = new ResourceIdentifier(this.ResourceId);
                this.ResourceGroupName = resourceIdentifier.ResourceGroupName;
                this.WorkspaceName = resourceIdentifier.ResourceName;
            }

            if (string.IsNullOrEmpty(this.ResourceGroupName))
            {
                this.ResourceGroupName = this.SynapseAnalyticsClient.GetResourceGroupByWorkspaceName(this.WorkspaceName);
            }

            if (this.ShouldProcess(this.WorkspaceName, string.Format(Resources.EnablingAdvancedDataSecurity, this.WorkspaceName)))
            {
                var policy = SynapseAnalyticsClient.GetWorkspaceThreatDetectionPolicy(this.ResourceGroupName, this.WorkspaceName);
                policy.State = SecurityAlertPolicyState.Enabled;
                if(!string.IsNullOrEmpty(policy.StorageEndpoint))
                {
                    policy.StorageAccountAccessKey = SynapseAnalyticsClient.GetStorageKeys(policy.StorageEndpoint)[StorageKeyKind.Primary];
                }
                else
                {
                    policy.StorageEndpoint = null;
                }
                SynapseAnalyticsClient.SetWorkspaceThreatDetectionPolicy(this.ResourceGroupName, this.WorkspaceName, policy);

                if (!DoNotConfigureVulnerabilityAssessment)
                {
                    // Deploy arm template to enable VA - only if VA at server level is not defined
                    var workspaceVa = SynapseAnalyticsClient.GetWorkspaceVulnerabilityAssessmentSettings(this.ResourceGroupName, this.WorkspaceName);
                    if (string.IsNullOrEmpty(workspaceVa.StorageContainerPath))
                    {
                        if(this.IsParameterBound(c => c.InputObject))
                        {
                            SynapseAnalyticsClient.EnableWorkspaceVa(this.ResourceGroupName, this.WorkspaceName, this.InputObject.Location, this.DeploymentName);
                        }
                        else
                        {
                            var workspace = SynapseAnalyticsClient.GetWorkspace(this.ResourceGroupName, this.WorkspaceName);
                            SynapseAnalyticsClient.EnableWorkspaceVa(this.ResourceGroupName, this.WorkspaceName, workspace.Location, this.DeploymentName);
                        }
                    }
                }

                var result = new WorkspaceAdvancedDataSecurityPolicy()
                {
                    ResourceGroupName = this.ResourceGroupName,
                    WorkspaceName = this.WorkspaceName,
                    IsEnabled = true
                };
                WriteObject(result);
            }
        }
    }
}
