/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.v72.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.v72.Models.All
{
    /// <summary>
    /// EdFiSession
    /// </summary>
    [DataContract(Name = "edFi_session")]
    public partial class EdFiSession : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSession" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        /// <param name="academicWeeks">An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year..</param>
        /// <param name="beginDate">Month, day, and year of the first day of the session. (required).</param>
        /// <param name="endDate">Month, day and year of the last day of the session. (required).</param>
        /// <param name="gradingPeriods">An unordered collection of sessionGradingPeriods. Grading periods associated with the session..</param>
        /// <param name="termDescriptor">A descriptor value to indicate the term that the session is associated with. (required).</param>
        /// <param name="totalInstructionalDays">The total number of instructional days in the school calendar. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        /// <param name="ext">Extensions to the Session entity..</param>
        public EdFiSession(string id = default, string sessionName = default, EdFiSchoolReference schoolReference = default, EdFiSchoolYearTypeReference schoolYearTypeReference = default, List<EdFiSessionAcademicWeek> academicWeeks = default, DateOnly beginDate = default, DateOnly endDate = default, List<EdFiSessionGradingPeriod> gradingPeriods = default, string termDescriptor = default, int totalInstructionalDays = default, string etag = default, DateTime lastModifiedDate = default, Object ext = default)
        {
            // to ensure "sessionName" is required (not null)
            if (sessionName == null)
            {
                throw new ArgumentNullException("sessionName is a required property for EdFiSession and cannot be null");
            }
            this.SessionName = sessionName;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiSession and cannot be null");
            }
            this.SchoolReference = schoolReference;
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new ArgumentNullException("schoolYearTypeReference is a required property for EdFiSession and cannot be null");
            }
            this.SchoolYearTypeReference = schoolYearTypeReference;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            // to ensure "termDescriptor" is required (not null)
            if (termDescriptor == null)
            {
                throw new ArgumentNullException("termDescriptor is a required property for EdFiSession and cannot be null");
            }
            this.TermDescriptor = termDescriptor;
            this.TotalInstructionalDays = totalInstructionalDays;
            this.Id = id;
            this.AcademicWeeks = academicWeeks;
            this.GradingPeriods = gradingPeriods;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session.
        /// </summary>
        /// <value>The identifier for the calendar for the academic session.</value>
        [DataMember(Name = "sessionName", IsRequired = true, EmitDefaultValue = true)]
        public string SessionName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name = "schoolYearTypeReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year.
        /// </summary>
        /// <value>An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year.</value>
        [DataMember(Name = "academicWeeks", EmitDefaultValue = false)]
        public List<EdFiSessionAcademicWeek> AcademicWeeks { get; set; }

        /// <summary>
        /// Month, day, and year of the first day of the session.
        /// </summary>
        /// <value>Month, day, and year of the first day of the session.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly BeginDate { get; set; }

        /// <summary>
        /// Month, day and year of the last day of the session.
        /// </summary>
        /// <value>Month, day and year of the last day of the session.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly EndDate { get; set; }

        /// <summary>
        /// An unordered collection of sessionGradingPeriods. Grading periods associated with the session.
        /// </summary>
        /// <value>An unordered collection of sessionGradingPeriods. Grading periods associated with the session.</value>
        [DataMember(Name = "gradingPeriods", EmitDefaultValue = false)]
        public List<EdFiSessionGradingPeriod> GradingPeriods { get; set; }

        /// <summary>
        /// A descriptor value to indicate the term that the session is associated with.
        /// </summary>
        /// <value>A descriptor value to indicate the term that the session is associated with.</value>
        [DataMember(Name = "termDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// The total number of instructional days in the school calendar.
        /// </summary>
        /// <value>The total number of instructional days in the school calendar.</value>
        [DataMember(Name = "totalInstructionalDays", IsRequired = true, EmitDefaultValue = true)]
        public int TotalInstructionalDays { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [DataMember(Name = "_lastModifiedDate", EmitDefaultValue = false)]
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Extensions to the Session entity.
        /// </summary>
        /// <value>Extensions to the Session entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  AcademicWeeks: ").Append(AcademicWeeks).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  GradingPeriods: ").Append(GradingPeriods).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
            sb.Append("  TotalInstructionalDays: ").Append(TotalInstructionalDays).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // SessionName (string) maxLength
            if (this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
            }

            // TermDescriptor (string) maxLength
            if (this.TermDescriptor != null && this.TermDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for TermDescriptor, length must be less than 306.", new [] { "TermDescriptor" });
            }

            // TotalInstructionalDays (int) minimum
            if (this.TotalInstructionalDays < (int)0)
            {
                yield return new ValidationResult("Invalid value for TotalInstructionalDays, must be a value greater than or equal to 0.", new [] { "TotalInstructionalDays" });
            }

            yield break;
        }
    }

}
