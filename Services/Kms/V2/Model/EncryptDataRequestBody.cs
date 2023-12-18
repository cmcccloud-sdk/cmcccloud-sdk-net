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
    public class EncryptDataRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<EncryptionAlgorithmEnum>))]
        public class EncryptionAlgorithmEnum
        {
            /// <summary>
            /// Enum SYMMETRIC_DEFAULT for value: SYMMETRIC_DEFAULT
            /// </summary>
            public static readonly EncryptionAlgorithmEnum SYMMETRIC_DEFAULT = new EncryptionAlgorithmEnum("SYMMETRIC_DEFAULT");

            /// <summary>
            /// Enum RSAES_OAEP_SHA_256 for value: RSAES_OAEP_SHA_256
            /// </summary>
            public static readonly EncryptionAlgorithmEnum RSAES_OAEP_SHA_256 = new EncryptionAlgorithmEnum("RSAES_OAEP_SHA_256");

            /// <summary>
            /// Enum SM2_ENCRYPT for value: SM2_ENCRYPT
            /// </summary>
            public static readonly EncryptionAlgorithmEnum SM2_ENCRYPT = new EncryptionAlgorithmEnum("SM2_ENCRYPT");

            private static readonly Dictionary<string, EncryptionAlgorithmEnum> StaticFields =
            new Dictionary<string, EncryptionAlgorithmEnum>()
            {
                { "SYMMETRIC_DEFAULT", SYMMETRIC_DEFAULT },
                { "RSAES_OAEP_SHA_256", RSAES_OAEP_SHA_256 },
                { "SM2_ENCRYPT", SM2_ENCRYPT },
            };

            private string _value;

            public EncryptionAlgorithmEnum()
            {

            }

            public EncryptionAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static EncryptionAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as EncryptionAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncryptionAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncryptionAlgorithmEnum a, EncryptionAlgorithmEnum b)
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

            public static bool operator !=(EncryptionAlgorithmEnum a, EncryptionAlgorithmEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        [JsonProperty("plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PlainText { get; set; }

        [JsonProperty("encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptionAlgorithmEnum EncryptionAlgorithm { get; set; }
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptDataRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  plainText: ").Append(PlainText).Append("\n");
            sb.Append("  encryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncryptDataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncryptDataRequestBody input)
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
                    this.EncryptionAlgorithm == input.EncryptionAlgorithm ||
                    (this.EncryptionAlgorithm != null &&
                    this.EncryptionAlgorithm.Equals(input.EncryptionAlgorithm))
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
                if (this.EncryptionAlgorithm != null)
                    hashCode = hashCode * 59 + this.EncryptionAlgorithm.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
