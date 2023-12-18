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
    public class EncryptDatakeyRequestBody 
    {

        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PlainText { get; set; }

        [JsonProperty("datakey_plain_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyPlainLength { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptDatakeyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  plainText: ").Append(PlainText).Append("\n");
            sb.Append("  datakeyPlainLength: ").Append(DatakeyPlainLength).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncryptDatakeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncryptDatakeyRequestBody input)
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
                    this.PlainText == input.PlainText ||
                    (this.PlainText != null &&
                    this.PlainText.Equals(input.PlainText))
                ) && 
                (
                    this.DatakeyPlainLength == input.DatakeyPlainLength ||
                    (this.DatakeyPlainLength != null &&
                    this.DatakeyPlainLength.Equals(input.DatakeyPlainLength))
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
                if (this.PlainText != null)
                    hashCode = hashCode * 59 + this.PlainText.GetHashCode();
                if (this.DatakeyPlainLength != null)
                    hashCode = hashCode * 59 + this.DatakeyPlainLength.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
