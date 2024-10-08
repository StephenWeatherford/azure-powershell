// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Vlan group properties.</summary>
    public partial class VlanGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IVlanGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IVlanGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Vlan group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Vlan" /> property.</summary>
        private System.Collections.Generic.List<string> _vlan;

        /// <summary>List of vlans.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Vlan { get => this._vlan; set => this._vlan = value; }

        /// <summary>Creates an new <see cref="VlanGroupProperties" /> instance.</summary>
        public VlanGroupProperties()
        {

        }
    }
    /// Vlan group properties.
    public partial interface IVlanGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable
    {
        /// <summary>Vlan group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Vlan group name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>List of vlans.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of vlans.",
        SerializedName = @"vlans",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Vlan { get; set; }

    }
    /// Vlan group properties.
    internal partial interface IVlanGroupPropertiesInternal

    {
        /// <summary>Vlan group name.</summary>
        string Name { get; set; }
        /// <summary>List of vlans.</summary>
        System.Collections.Generic.List<string> Vlan { get; set; }

    }
}