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
    public partial class InlineResponse2008Data : IEquatable<InlineResponse2008Data>
    { 
        /// <summary>
        /// Gets or Sets SCode
        /// </summary>
        [DataMember(Name="sCode")]
        public string SCode { get; set; }

        /// <summary>
        /// Gets or Sets IStatus
        /// </summary>
        [DataMember(Name="iStatus")]
        public int? IStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2008Data {\n");
            sb.Append("  SCode: ").Append(SCode).Append("\n");
            sb.Append("  IStatus: ").Append(IStatus).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse2008Data)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2008Data instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2008Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2008Data other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SCode == other.SCode ||
                    SCode != null &&
                    SCode.Equals(other.SCode)
                ) && 
                (
                    IStatus == other.IStatus ||
                    IStatus != null &&
                    IStatus.Equals(other.IStatus)
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
                    if (SCode != null)
                    hashCode = hashCode * 59 + SCode.GetHashCode();
                    if (IStatus != null)
                    hashCode = hashCode * 59 + IStatus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse2008Data left, InlineResponse2008Data right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2008Data left, InlineResponse2008Data right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
