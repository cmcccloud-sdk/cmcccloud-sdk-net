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
    public class DeleteKeyResponse : SdkResponse
    {

        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteKeyResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keyState: ").Append(KeyState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteKeyResponse input)
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
                    this.KeyState == input.KeyState ||
                    (this.KeyState != null &&
                    this.KeyState.Equals(input.KeyState))
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
                if (this.KeyState != null)
                    hashCode = hashCode * 59 + this.KeyState.GetHashCode();
                return hashCode;
            }
        }
    }
}
