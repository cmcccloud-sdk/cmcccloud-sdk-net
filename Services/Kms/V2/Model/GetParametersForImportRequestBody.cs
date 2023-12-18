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
    public class GetParametersForImportRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<WrappingAlgorithmEnum>))]
        public class WrappingAlgorithmEnum
        {
            /// <summary>
            /// Enum RSAES_OAEP_SHA_256 for value: RSAES_OAEP_SHA_256
            /// </summary>
            public static readonly WrappingAlgorithmEnum RSAES_OAEP_SHA_256 = new WrappingAlgorithmEnum("RSAES_OAEP_SHA_256");

            /// <summary>
            /// Enum SM2_ENCRYPT for value: SM2_ENCRYPT
            /// </summary>
            public static readonly WrappingAlgorithmEnum SM2_ENCRYPT = new WrappingAlgorithmEnum("SM2_ENCRYPT");

            private static readonly Dictionary<string, WrappingAlgorithmEnum> StaticFields =
            new Dictionary<string, WrappingAlgorithmEnum>()
            {
                { "RSAES_OAEP_SHA_256", RSAES_OAEP_SHA_256 },
                { "SM2_ENCRYPT", SM2_ENCRYPT },
            };

            private string _value;

            public WrappingAlgorithmEnum()
            {

            }

            public WrappingAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static WrappingAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as WrappingAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WrappingAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WrappingAlgorithmEnum a, WrappingAlgorithmEnum b)
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

            public static bool operator !=(WrappingAlgorithmEnum a, WrappingAlgorithmEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("wrapping_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public WrappingAlgorithmEnum WrappingAlgorithm { get; set; }
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetParametersForImportRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  wrappingAlgorithm: ").Append(WrappingAlgorithm).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetParametersForImportRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetParametersForImportRequestBody input)
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
                    this.WrappingAlgorithm == input.WrappingAlgorithm ||
                    (this.WrappingAlgorithm != null &&
                    this.WrappingAlgorithm.Equals(input.WrappingAlgorithm))
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
                if (this.WrappingAlgorithm != null)
                    hashCode = hashCode * 59 + this.WrappingAlgorithm.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
