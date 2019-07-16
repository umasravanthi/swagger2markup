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
    public partial class InlineResponse20011Data : IEquatable<InlineResponse20011Data>
    { 
        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="ReportId")]
        public int? ReportId { get; set; }

        /// <summary>
        /// Gets or Sets LinkId
        /// </summary>
        [DataMember(Name="LinkId")]
        public int? LinkId { get; set; }

        /// <summary>
        /// Gets or Sets ReportModule
        /// </summary>
        [DataMember(Name="ReportModule")]
        public int? ReportModule { get; set; }

        /// <summary>
        /// Gets or Sets ReportType
        /// </summary>
        [DataMember(Name="ReportType")]
        public int? ReportType { get; set; }

        /// <summary>
        /// Gets or Sets ReportName
        /// </summary>
        [DataMember(Name="ReportName")]
        public string ReportName { get; set; }

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="SourceType")]
        public int? SourceType { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="Parameters")]
        public List<InlineResponse20011Parameters> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets LayoutDtls
        /// </summary>
        [DataMember(Name="LayoutDtls")]
        public List<InlineResponse20011LayoutDtls> LayoutDtls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20011Data {\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  ReportModule: ").Append(ReportModule).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  LayoutDtls: ").Append(LayoutDtls).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse20011Data)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse20011Data instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20011Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20011Data other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ReportId == other.ReportId ||
                    ReportId != null &&
                    ReportId.Equals(other.ReportId)
                ) && 
                (
                    LinkId == other.LinkId ||
                    LinkId != null &&
                    LinkId.Equals(other.LinkId)
                ) && 
                (
                    ReportModule == other.ReportModule ||
                    ReportModule != null &&
                    ReportModule.Equals(other.ReportModule)
                ) && 
                (
                    ReportType == other.ReportType ||
                    ReportType != null &&
                    ReportType.Equals(other.ReportType)
                ) && 
                (
                    ReportName == other.ReportName ||
                    ReportName != null &&
                    ReportName.Equals(other.ReportName)
                ) && 
                (
                    SourceType == other.SourceType ||
                    SourceType != null &&
                    SourceType.Equals(other.SourceType)
                ) && 
                (
                    Parameters == other.Parameters ||
                    Parameters != null &&
                    Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    LayoutDtls == other.LayoutDtls ||
                    LayoutDtls != null &&
                    LayoutDtls.SequenceEqual(other.LayoutDtls)
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
                    if (ReportId != null)
                    hashCode = hashCode * 59 + ReportId.GetHashCode();
                    if (LinkId != null)
                    hashCode = hashCode * 59 + LinkId.GetHashCode();
                    if (ReportModule != null)
                    hashCode = hashCode * 59 + ReportModule.GetHashCode();
                    if (ReportType != null)
                    hashCode = hashCode * 59 + ReportType.GetHashCode();
                    if (ReportName != null)
                    hashCode = hashCode * 59 + ReportName.GetHashCode();
                    if (SourceType != null)
                    hashCode = hashCode * 59 + SourceType.GetHashCode();
                    if (Parameters != null)
                    hashCode = hashCode * 59 + Parameters.GetHashCode();
                    if (LayoutDtls != null)
                    hashCode = hashCode * 59 + LayoutDtls.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse20011Data left, InlineResponse20011Data right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse20011Data left, InlineResponse20011Data right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
