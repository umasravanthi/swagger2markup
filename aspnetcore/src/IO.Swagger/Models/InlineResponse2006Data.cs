/*
 * API Documentation
 *
 * defaultDeription
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse2006Data : IEquatable<InlineResponse2006Data>
    { 
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body")]
        public List<InlineResponse2006Body> Body { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="header")]
        public List<InlineResponse2006Header> Header { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="Footer")]
        public List<Object> Footer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006Data {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse2006Data)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2006Data instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2006Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2006Data other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Body == other.Body ||
                    Body != null &&
                    Body.SequenceEqual(other.Body)
                ) && 
                (
                    Header == other.Header ||
                    Header != null &&
                    Header.SequenceEqual(other.Header)
                ) && 
                (
                    Footer == other.Footer ||
                    Footer != null &&
                    Footer.SequenceEqual(other.Footer)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Body != null)
                    hashCode = hashCode * 59 + Body.GetHashCode();
                    if (Header != null)
                    hashCode = hashCode * 59 + Header.GetHashCode();
                    if (Footer != null)
                    hashCode = hashCode * 59 + Footer.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse2006Data left, InlineResponse2006Data right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2006Data left, InlineResponse2006Data right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
