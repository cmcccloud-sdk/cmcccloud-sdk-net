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
    public class ListKeysRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
            /// <summary>
            /// Enum AES_256 for value: AES_256
            /// </summary>
            public static readonly KeySpecEnum AES_256 = new KeySpecEnum("AES_256");

            /// <summary>
            /// Enum SM4 for value: SM4
            /// </summary>
            public static readonly KeySpecEnum SM4 = new KeySpecEnum("SM4");

            /// <summary>
            /// Enum RSA_2048 for value: RSA_2048
            /// </summary>
            public static readonly KeySpecEnum RSA_2048 = new KeySpecEnum("RSA_2048");

            /// <summary>
            /// Enum RSA_3072 for value: RSA_3072
            /// </summary>
            public static readonly KeySpecEnum RSA_3072 = new KeySpecEnum("RSA_3072");

            /// <summary>
            /// Enum RSA_4096 for value: RSA_4096
            /// </summary>
            public static readonly KeySpecEnum RSA_4096 = new KeySpecEnum("RSA_4096");

            /// <summary>
            /// Enum EC_P256 for value: EC_P256
            /// </summary>
            public static readonly KeySpecEnum EC_P256 = new KeySpecEnum("EC_P256");

            /// <summary>
            /// Enum EC_P384 for value: EC_P384
            /// </summary>
            public static readonly KeySpecEnum EC_P384 = new KeySpecEnum("EC_P384");

            /// <summary>
            /// Enum SM2 for value: SM2
            /// </summary>
            public static readonly KeySpecEnum SM2 = new KeySpecEnum("SM2");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly KeySpecEnum ALL = new KeySpecEnum("ALL");

            private static readonly Dictionary<string, KeySpecEnum> StaticFields =
            new Dictionary<string, KeySpecEnum>()
            {
                { "AES_256", AES_256 },
                { "SM4", SM4 },
                { "RSA_2048", RSA_2048 },
                { "RSA_3072", RSA_3072 },
                { "RSA_4096", RSA_4096 },
                { "EC_P256", EC_P256 },
                { "EC_P384", EC_P384 },
                { "SM2", SM2 },
                { "ALL", ALL },
            };

            private string _value;

            public KeySpecEnum()
            {

            }

            public KeySpecEnum(string value)
            {
                _value = value;
            }

            public static KeySpecEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as KeySpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeySpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeySpecEnum a, KeySpecEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(KeySpecEnum a, KeySpecEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        [JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyState { get; set; }

        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeysRequestBody {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  keyState: ").Append(KeyState).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeysRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeysRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.KeyState == input.KeyState ||
                    (this.KeyState != null &&
                    this.KeyState.Equals(input.KeyState))
                ) && 
                (
                    this.KeySpec == input.KeySpec ||
                    (this.KeySpec != null &&
                    this.KeySpec.Equals(input.KeySpec))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.KeyState != null)
                    hashCode = hashCode * 59 + this.KeyState.GetHashCode();
                if (this.KeySpec != null)
                    hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
