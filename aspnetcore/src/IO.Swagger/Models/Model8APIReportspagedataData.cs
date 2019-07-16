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
    public partial class Model8APIReportspagedataData : IEquatable<Model8APIReportspagedataData>
    { 
        /// <summary>
        /// Gets or Sets StartingDate
        /// </summary>
        [DataMember(Name="StartingDate")]
        public int? StartingDate { get; set; }

        /// <summary>
        /// Gets or Sets Masters
        /// </summary>
        [DataMember(Name="Masters")]
        public List<Model8APIReportspagedataMasters> Masters { get; set; }

        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name="UniqueId")]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or Sets EndingDate
        /// </summary>
        [DataMember(Name="EndingDate")]
        public int? EndingDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="CurrentPage")]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets LayoutId
        /// </summary>
        [DataMember(Name="LayoutId")]
        public int? LayoutId { get; set; }

        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="ReportId")]
        public string ReportId { get; set; }

        /// <summary>
        /// Gets or Sets RowsPerPage
        /// </summary>
        [DataMember(Name="RowsPerPage")]
        public int? RowsPerPage { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="Inputs")]
        public List<Model8APIReportspagedataInputs> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name="LanguageId")]
        public int? LanguageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model8APIReportspagedataData {\n");
            sb.Append("  StartingDate: ").Append(StartingDate).Append("\n");
            sb.Append("  Masters: ").Append(Masters).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  EndingDate: ").Append(EndingDate).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  RowsPerPage: ").Append(RowsPerPage).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Model8APIReportspagedataData)obj);
        }

        /// <summary>
        /// Returns true if Model8APIReportspagedataData instances are equal
        /// </summary>
        /// <param name="other">Instance of Model8APIReportspagedataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model8APIReportspagedataData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StartingDate == other.StartingDate ||
                    StartingDate != null &&
                    StartingDate.Equals(other.StartingDate)
                ) && 
                (
                    Masters == other.Masters ||
                    Masters != null &&
                    Masters.SequenceEqual(other.Masters)
                ) && 
                (
                    UniqueId == other.UniqueId ||
                    UniqueId != null &&
                    UniqueId.Equals(other.UniqueId)
                ) && 
                (
                    EndingDate == other.EndingDate ||
                    EndingDate != null &&
                    EndingDate.Equals(other.EndingDate)
                ) && 
                (
                    CurrentPage == other.CurrentPage ||
                    CurrentPage != null &&
                    CurrentPage.Equals(other.CurrentPage)
                ) && 
                (
                    LayoutId == other.LayoutId ||
                    LayoutId != null &&
                    LayoutId.Equals(other.LayoutId)
                ) && 
                (
                    ReportId == other.ReportId ||
                    ReportId != null &&
                    ReportId.Equals(other.ReportId)
                ) && 
                (
                    RowsPerPage == other.RowsPerPage ||
                    RowsPerPage != null &&
                    RowsPerPage.Equals(other.RowsPerPage)
                ) && 
                (
                    Inputs == other.Inputs ||
                    Inputs != null &&
                    Inputs.SequenceEqual(other.Inputs)
                ) && 
                (
                    LanguageId == other.LanguageId ||
                    LanguageId != null &&
                    LanguageId.Equals(other.LanguageId)
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
                    if (StartingDate != null)
                    hashCode = hashCode * 59 + StartingDate.GetHashCode();
                    if (Masters != null)
                    hashCode = hashCode * 59 + Masters.GetHashCode();
                    if (UniqueId != null)
                    hashCode = hashCode * 59 + UniqueId.GetHashCode();
                    if (EndingDate != null)
                    hashCode = hashCode * 59 + EndingDate.GetHashCode();
                    if (CurrentPage != null)
                    hashCode = hashCode * 59 + CurrentPage.GetHashCode();
                    if (LayoutId != null)
                    hashCode = hashCode * 59 + LayoutId.GetHashCode();
                    if (ReportId != null)
                    hashCode = hashCode * 59 + ReportId.GetHashCode();
                    if (RowsPerPage != null)
                    hashCode = hashCode * 59 + RowsPerPage.GetHashCode();
                    if (Inputs != null)
                    hashCode = hashCode * 59 + Inputs.GetHashCode();
                    if (LanguageId != null)
                    hashCode = hashCode * 59 + LanguageId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Model8APIReportspagedataData left, Model8APIReportspagedataData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Model8APIReportspagedataData left, Model8APIReportspagedataData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
