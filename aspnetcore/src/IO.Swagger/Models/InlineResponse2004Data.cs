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
    public partial class InlineResponse2004Data : IEquatable<InlineResponse2004Data>
    { 
        /// <summary>
        /// Gets or Sets APIMasterName
        /// </summary>
        [DataMember(Name="APIMasterName")]
        public bool? APIMasterName { get; set; }

        /// <summary>
        /// Gets or Sets MasterTypeId
        /// </summary>
        [DataMember(Name="MasterTypeId")]
        public int? MasterTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name="Caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2004Data {\n");
            sb.Append("  APIMasterName: ").Append(APIMasterName).Append("\n");
            sb.Append("  MasterTypeId: ").Append(MasterTypeId).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse2004Data)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2004Data instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2004Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2004Data other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    APIMasterName == other.APIMasterName ||
                    APIMasterName != null &&
                    APIMasterName.Equals(other.APIMasterName)
                ) && 
                (
                    MasterTypeId == other.MasterTypeId ||
                    MasterTypeId != null &&
                    MasterTypeId.Equals(other.MasterTypeId)
                ) && 
                (
                    Caption == other.Caption ||
                    Caption != null &&
                    Caption.Equals(other.Caption)
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
                    if (APIMasterName != null)
                    hashCode = hashCode * 59 + APIMasterName.GetHashCode();
                    if (MasterTypeId != null)
                    hashCode = hashCode * 59 + MasterTypeId.GetHashCode();
                    if (Caption != null)
                    hashCode = hashCode * 59 + Caption.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse2004Data left, InlineResponse2004Data right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2004Data left, InlineResponse2004Data right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
