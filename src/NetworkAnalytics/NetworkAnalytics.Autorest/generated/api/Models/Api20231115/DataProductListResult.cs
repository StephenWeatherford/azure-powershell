// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The response of a DataProduct list operation.</summary>
    public partial class DataProductListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IDataProductListResult,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IDataProductListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IDataProduct[] _value;

        /// <summary>The DataProduct items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IDataProduct[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DataProductListResult" /> instance.</summary>
        public DataProductListResult()
        {

        }
    }
    /// The response of a DataProduct list operation.
    public partial interface IDataProductListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The DataProduct items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The DataProduct items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IDataProduct) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IDataProduct[] Value { get; set; }

    }
    /// The response of a DataProduct list operation.
    internal partial interface IDataProductListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The DataProduct items on this page</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Api20231115.IDataProduct[] Value { get; set; }

    }
}