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
    public class DecryptDatakeyRequestBody 
    {

        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("cipher_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CipherText { get; set; }

        [JsonProperty("datakey_cipher_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyCipherLength { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptDatakeyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  cipherText: ").Append(CipherText).Append("\n");
            sb.Append("  datakeyCipherLength: ").Append(DatakeyCipherLength).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptDatakeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecryptDatakeyRequestBody input)
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
                    this.CipherText == input.CipherText ||
                    (this.CipherText != null &&
                    this.CipherText.Equals(input.CipherText))
                ) && 
                (
                    this.DatakeyCipherLength == input.DatakeyCipherLength ||
                    (this.DatakeyCipherLength != null &&
                    this.DatakeyCipherLength.Equals(input.DatakeyCipherLength))
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
                if (this.CipherText != null)
                    hashCode = hashCode * 59 + this.CipherText.GetHashCode();
                if (this.DatakeyCipherLength != null)
                    hashCode = hashCode * 59 + this.DatakeyCipherLength.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
