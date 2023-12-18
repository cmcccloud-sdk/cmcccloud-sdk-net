using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CmccCloud.SDK.Core;

namespace CmccCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateParametersForImportResponse : SdkResponse
    {

        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("import_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportToken { get; set; }

        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpirationTime { get; set; }

        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateParametersForImportResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  importToken: ").Append(ImportToken).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateParametersForImportResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateParametersForImportResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.ImportToken == input.ImportToken ||
                    (this.ImportToken != null &&
                    this.ImportToken.Equals(input.ImportToken))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.ImportToken != null)
                    hashCode = hashCode * 59 + this.ImportToken.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
