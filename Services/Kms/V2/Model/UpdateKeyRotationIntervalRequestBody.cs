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
    public class UpdateKeyRotationIntervalRequestBody 
    {

        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("rotation_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? RotationInterval { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateKeyRotationIntervalRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  rotationInterval: ").Append(RotationInterval).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateKeyRotationIntervalRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateKeyRotationIntervalRequestBody input)
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
                    this.RotationInterval == input.RotationInterval ||
                    (this.RotationInterval != null &&
                    this.RotationInterval.Equals(input.RotationInterval))
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
                if (this.RotationInterval != null)
                    hashCode = hashCode * 59 + this.RotationInterval.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
