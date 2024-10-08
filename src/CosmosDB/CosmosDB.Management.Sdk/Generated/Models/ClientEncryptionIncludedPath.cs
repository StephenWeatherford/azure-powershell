// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    /// <summary>
    /// .
    /// </summary>
    public partial class ClientEncryptionIncludedPath
    {
        /// <summary>
        /// Initializes a new instance of the ClientEncryptionIncludedPath class.
        /// </summary>
        public ClientEncryptionIncludedPath()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientEncryptionIncludedPath class.
        /// </summary>

        /// <param name="path">Path that needs to be encrypted.
        /// </param>

        /// <param name="clientEncryptionKeyId">The identifier of the Client Encryption Key to be used to encrypt the path.
        /// </param>

        /// <param name="encryptionType">The type of encryption to be performed. Eg - Deterministic, Randomized.
        /// </param>

        /// <param name="encryptionAlgorithm">The encryption algorithm which will be used. Eg -
        /// AEAD_AES_256_CBC_HMAC_SHA256.
        /// </param>
        public ClientEncryptionIncludedPath(string path, string clientEncryptionKeyId, string encryptionType, string encryptionAlgorithm)

        {
            this.Path = path;
            this.ClientEncryptionKeyId = clientEncryptionKeyId;
            this.EncryptionType = encryptionType;
            this.EncryptionAlgorithm = encryptionAlgorithm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets path that needs to be encrypted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "path")]
        public string Path {get; set; }

        /// <summary>
        /// Gets or sets the identifier of the Client Encryption Key to be used to
        /// encrypt the path.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clientEncryptionKeyId")]
        public string ClientEncryptionKeyId {get; set; }

        /// <summary>
        /// Gets or sets the type of encryption to be performed. Eg - Deterministic,
        /// Randomized.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptionType")]
        public string EncryptionType {get; set; }

        /// <summary>
        /// Gets or sets the encryption algorithm which will be used. Eg -
        /// AEAD_AES_256_CBC_HMAC_SHA256.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptionAlgorithm")]
        public string EncryptionAlgorithm {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Path == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Path");
            }
            if (this.ClientEncryptionKeyId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ClientEncryptionKeyId");
            }
            if (this.EncryptionType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "EncryptionType");
            }
            if (this.EncryptionAlgorithm == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "EncryptionAlgorithm");
            }




        }
    }
}