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
    public class ShowKeyRotationStatusResponse : SdkResponse
    {

        [JsonProperty("key_rotation_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KeyRotationEnabled { get; set; }

        [JsonProperty("rotation_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? RotationInterval { get; set; }

        [JsonProperty("last_rotation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRotationTime { get; set; }

        [JsonProperty("number_of_rotations", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfRotations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKeyRotationStatusResponse {\n");
            sb.Append("  keyRotationEnabled: ").Append(KeyRotationEnabled).Append("\n");
            sb.Append("  rotationInterval: ").Append(RotationInterval).Append("\n");
            sb.Append("  lastRotationTime: ").Append(LastRotationTime).Append("\n");
            sb.Append("  numberOfRotations: ").Append(NumberOfRotations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKeyRotationStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKeyRotationStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyRotationEnabled == input.KeyRotationEnabled ||
                    (this.KeyRotationEnabled != null &&
                    this.KeyRotationEnabled.Equals(input.KeyRotationEnabled))
                ) && 
                (
                    this.RotationInterval == input.RotationInterval ||
                    (this.RotationInterval != null &&
                    this.RotationInterval.Equals(input.RotationInterval))
                ) && 
                (
                    this.LastRotationTime == input.LastRotationTime ||
                    (this.LastRotationTime != null &&
                    this.LastRotationTime.Equals(input.LastRotationTime))
                ) && 
                (
                    this.NumberOfRotations == input.NumberOfRotations ||
                    (this.NumberOfRotations != null &&
                    this.NumberOfRotations.Equals(input.NumberOfRotations))
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
                if (this.KeyRotationEnabled != null)
                    hashCode = hashCode * 59 + this.KeyRotationEnabled.GetHashCode();
                if (this.RotationInterval != null)
                    hashCode = hashCode * 59 + this.RotationInterval.GetHashCode();
                if (this.LastRotationTime != null)
                    hashCode = hashCode * 59 + this.LastRotationTime.GetHashCode();
                if (this.NumberOfRotations != null)
                    hashCode = hashCode * 59 + this.NumberOfRotations.GetHashCode();
                return hashCode;
            }
        }
    }
}
