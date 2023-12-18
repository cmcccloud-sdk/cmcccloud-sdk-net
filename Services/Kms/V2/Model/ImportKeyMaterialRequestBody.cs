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
    /// 
    /// </summary>
    public class ImportKeyMaterialRequestBody 
    {

        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("import_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportToken { get; set; }

        [JsonProperty("encrypted_key_material", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedKeyMaterial { get; set; }

        [JsonProperty("encrypted_privatekey", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedPrivatekey { get; set; }

        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpirationTime { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportKeyMaterialRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  importToken: ").Append(ImportToken).Append("\n");
            sb.Append("  encryptedKeyMaterial: ").Append(EncryptedKeyMaterial).Append("\n");
            sb.Append("  encryptedPrivatekey: ").Append(EncryptedPrivatekey).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportKeyMaterialRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportKeyMaterialRequestBody input)
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
                    this.EncryptedKeyMaterial == input.EncryptedKeyMaterial ||
                    (this.EncryptedKeyMaterial != null &&
                    this.EncryptedKeyMaterial.Equals(input.EncryptedKeyMaterial))
                ) && 
                (
                    this.EncryptedPrivatekey == input.EncryptedPrivatekey ||
                    (this.EncryptedPrivatekey != null &&
                    this.EncryptedPrivatekey.Equals(input.EncryptedPrivatekey))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
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
                if (this.EncryptedKeyMaterial != null)
                    hashCode = hashCode * 59 + this.EncryptedKeyMaterial.GetHashCode();
                if (this.EncryptedPrivatekey != null)
                    hashCode = hashCode * 59 + this.EncryptedPrivatekey.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
