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
    public class ShowVersionsResponse : SdkResponse
    {

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApiVersionDetail> Versions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVersionsResponse {\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVersionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
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
                if (this.Versions != null)
                    hashCode = hashCode * 59 + this.Versions.GetHashCode();
                return hashCode;
            }
        }
    }
}
