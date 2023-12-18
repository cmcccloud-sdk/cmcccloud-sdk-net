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
    public class DecryptDataResponse : SdkResponse
    {

        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PlainText { get; set; }

        [JsonProperty("plain_text_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string PlainTextBase64 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptDataResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  plainText: ").Append(PlainText).Append("\n");
            sb.Append("  plainTextBase64: ").Append(PlainTextBase64).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecryptDataResponse input)
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
                    this.PlainTextBase64 == input.PlainTextBase64 ||
                    (this.PlainTextBase64 != null &&
                    this.PlainTextBase64.Equals(input.PlainTextBase64))
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
                if (this.PlainTextBase64 != null)
                    hashCode = hashCode * 59 + this.PlainTextBase64.GetHashCode();
                return hashCode;
            }
        }
    }
}
