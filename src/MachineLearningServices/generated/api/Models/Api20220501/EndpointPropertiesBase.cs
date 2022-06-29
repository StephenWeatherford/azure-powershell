// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Inference Endpoint base definition</summary>
    public partial class EndpointPropertiesBase :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBase,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseInternal
    {

        /// <summary>Backing field for <see cref="AuthMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EndpointAuthMode _authMode;

        /// <summary>
        /// [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication.
        /// 'Key' doesn't expire but 'AMLToken' does.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EndpointAuthMode AuthMode { get => this._authMode; set => this._authMode = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the inference endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeys _key;

        /// <summary>
        /// EndpointAuthKeys to set initially on an Endpoint.
        /// This property will always be returned as null. AuthKey values must be retrieved using the ListKeys API.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeys Key { get => (this._key = this._key ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointAuthKeys()); set => this._key = value; }

        /// <summary>The primary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string KeyPrimaryKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeysInternal)Key).PrimaryKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeysInternal)Key).PrimaryKey = value ?? null; }

        /// <summary>The secondary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string KeySecondaryKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeysInternal)Key).SecondaryKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeysInternal)Key).SecondaryKey = value ?? null; }

        /// <summary>Internal Acessors for Key</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeys Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseInternal.Key { get => (this._key = this._key ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointAuthKeys()); set { {_key = value;} } }

        /// <summary>Internal Acessors for ScoringUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseInternal.ScoringUri { get => this._scoringUri; set { {_scoringUri = value;} } }

        /// <summary>Internal Acessors for SwaggerUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseInternal.SwaggerUri { get => this._swaggerUri; set { {_swaggerUri = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseProperties _property;

        /// <summary>Property dictionary. Properties can be added, but not removed or altered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointPropertiesBaseProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="ScoringUri" /> property.</summary>
        private string _scoringUri;

        /// <summary>Endpoint URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ScoringUri { get => this._scoringUri; }

        /// <summary>Backing field for <see cref="SwaggerUri" /> property.</summary>
        private string _swaggerUri;

        /// <summary>Endpoint Swagger URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string SwaggerUri { get => this._swaggerUri; }

        /// <summary>Creates an new <see cref="EndpointPropertiesBase" /> instance.</summary>
        public EndpointPropertiesBase()
        {

        }
    }
    /// Inference Endpoint base definition
    public partial interface IEndpointPropertiesBase :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication.
        /// 'Key' doesn't expire but 'AMLToken' does.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication. 'Key' doesn't expire but 'AMLToken' does.",
        SerializedName = @"authMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EndpointAuthMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EndpointAuthMode AuthMode { get; set; }
        /// <summary>Description of the inference endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the inference endpoint.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The primary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The primary key.",
        SerializedName = @"primaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string KeyPrimaryKey { get; set; }
        /// <summary>The secondary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secondary key.",
        SerializedName = @"secondaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string KeySecondaryKey { get; set; }
        /// <summary>Property dictionary. Properties can be added, but not removed or altered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property dictionary. Properties can be added, but not removed or altered.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseProperties Property { get; set; }
        /// <summary>Endpoint URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Endpoint URI.",
        SerializedName = @"scoringUri",
        PossibleTypes = new [] { typeof(string) })]
        string ScoringUri { get;  }
        /// <summary>Endpoint Swagger URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Endpoint Swagger URI.",
        SerializedName = @"swaggerUri",
        PossibleTypes = new [] { typeof(string) })]
        string SwaggerUri { get;  }

    }
    /// Inference Endpoint base definition
    internal partial interface IEndpointPropertiesBaseInternal

    {
        /// <summary>
        /// [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication.
        /// 'Key' doesn't expire but 'AMLToken' does.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EndpointAuthMode AuthMode { get; set; }
        /// <summary>Description of the inference endpoint.</summary>
        string Description { get; set; }
        /// <summary>
        /// EndpointAuthKeys to set initially on an Endpoint.
        /// This property will always be returned as null. AuthKey values must be retrieved using the ListKeys API.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeys Key { get; set; }
        /// <summary>The primary key.</summary>
        string KeyPrimaryKey { get; set; }
        /// <summary>The secondary key.</summary>
        string KeySecondaryKey { get; set; }
        /// <summary>Property dictionary. Properties can be added, but not removed or altered.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointPropertiesBaseProperties Property { get; set; }
        /// <summary>Endpoint URI.</summary>
        string ScoringUri { get; set; }
        /// <summary>Endpoint Swagger URI.</summary>
        string SwaggerUri { get; set; }

    }
}