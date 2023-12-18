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
    public class ApiVersionDetail 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApiLink> Links { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        [JsonProperty("min_version", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiVersionDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  minVersion: ").Append(MinVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiVersionDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApiVersionDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.MinVersion == input.MinVersion ||
                    (this.MinVersion != null &&
                    this.MinVersion.Equals(input.MinVersion))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.MinVersion != null)
                    hashCode = hashCode * 59 + this.MinVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
