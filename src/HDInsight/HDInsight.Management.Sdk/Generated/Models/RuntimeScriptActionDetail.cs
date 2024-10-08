// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The execution details of a script action.
    /// </summary>
    public partial class RuntimeScriptActionDetail : RuntimeScriptAction
    {
        /// <summary>
        /// Initializes a new instance of the RuntimeScriptActionDetail class.
        /// </summary>
        public RuntimeScriptActionDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuntimeScriptActionDetail class.
        /// </summary>

        /// <param name="name">The name of the script action.
        /// </param>

        /// <param name="uri">The URI to the script.
        /// </param>

        /// <param name="parameters">The parameters for the script
        /// </param>

        /// <param name="roles">The list of roles where script will be executed.
        /// </param>

        /// <param name="applicationName">The application name of the script action, if any.
        /// </param>

        /// <param name="scriptExecutionId">The execution id of the script action.
        /// </param>

        /// <param name="startTime">The start time of script action execution.
        /// </param>

        /// <param name="endTime">The end time of script action execution.
        /// </param>

        /// <param name="status">The current execution status of the script action.
        /// </param>

        /// <param name="operation">The reason why the script action was executed.
        /// </param>

        /// <param name="executionSummary">The summary of script action execution result.
        /// </param>

        /// <param name="debugInformation">The script action execution debug information.
        /// </param>
        public RuntimeScriptActionDetail(string name, string uri, System.Collections.Generic.IList<string> roles, string parameters = default(string), string applicationName = default(string), long? scriptExecutionId = default(long?), string startTime = default(string), string endTime = default(string), string status = default(string), string operation = default(string), System.Collections.Generic.IList<ScriptActionExecutionSummary> executionSummary = default(System.Collections.Generic.IList<ScriptActionExecutionSummary>), string debugInformation = default(string))

        : base(name, uri, roles, parameters, applicationName)
        {
            this.ScriptExecutionId = scriptExecutionId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Status = status;
            this.Operation = operation;
            this.ExecutionSummary = executionSummary;
            this.DebugInformation = debugInformation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the execution id of the script action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scriptExecutionId")]
        public long? ScriptExecutionId {get; private set; }

        /// <summary>
        /// Gets the start time of script action execution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public string StartTime {get; private set; }

        /// <summary>
        /// Gets the end time of script action execution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public string EndTime {get; private set; }

        /// <summary>
        /// Gets the current execution status of the script action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; private set; }

        /// <summary>
        /// Gets the reason why the script action was executed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operation")]
        public string Operation {get; private set; }

        /// <summary>
        /// Gets the summary of script action execution result.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executionSummary")]
        public System.Collections.Generic.IList<ScriptActionExecutionSummary> ExecutionSummary {get; private set; }

        /// <summary>
        /// Gets the script action execution debug information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "debugInformation")]
        public string DebugInformation {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();






        }
    }
}