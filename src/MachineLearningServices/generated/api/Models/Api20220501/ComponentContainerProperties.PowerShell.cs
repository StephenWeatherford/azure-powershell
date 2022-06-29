// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>
    /// Component container definition.
    /// <see href="https://docs.microsoft.com/en-us/azure/machine-learning/reference-yaml-component-command" />
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentContainerPropertiesTypeConverter))]
    public partial class ComponentContainerProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ComponentContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ComponentContainerProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LatestVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).LatestVersion = (string) content.GetValueForProperty("LatestVersion",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).LatestVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NextVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).NextVersion = (string) content.GetValueForProperty("NextVersion",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).NextVersion, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ComponentContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ComponentContainerProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LatestVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).LatestVersion = (string) content.GetValueForProperty("LatestVersion",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).LatestVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NextVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).NextVersion = (string) content.GetValueForProperty("NextVersion",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetContainerInternal)this).NextVersion, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ComponentContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComponentContainerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComponentContainerProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ComponentContainerProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ComponentContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComponentContainerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComponentContainerProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ComponentContainerProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ComponentContainerProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ComponentContainerProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComponentContainerProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Component container definition.
    /// <see href="https://docs.microsoft.com/en-us/azure/machine-learning/reference-yaml-component-command" />
    [System.ComponentModel.TypeConverter(typeof(ComponentContainerPropertiesTypeConverter))]
    public partial interface IComponentContainerProperties

    {

    }
}