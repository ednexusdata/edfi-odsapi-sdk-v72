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
    /// EdFiStudentInterventionAttendanceEvent
    /// </summary>
    [DataContract(Name = "edFi_studentInterventionAttendanceEvent")]
    public partial class EdFiStudentInterventionAttendanceEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAttendanceEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentInterventionAttendanceEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAttendanceEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attendanceEventCategoryDescriptor">A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. (required).</param>
        /// <param name="eventDate">Date for this attendance event. (required).</param>
        /// <param name="interventionReference">interventionReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="attendanceEventReason">The reported reason for a student&#39;s absence..</param>
        /// <param name="educationalEnvironmentDescriptor">The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section..</param>
        /// <param name="eventDuration">The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33..</param>
        /// <param name="interventionDuration">The duration in minutes in which the student participated in the intervention during this instance..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        /// <param name="ext">Extensions to the StudentInterventionAttendanceEvent entity..</param>
        public EdFiStudentInterventionAttendanceEvent(string id = default, string attendanceEventCategoryDescriptor = default, DateOnly eventDate = default, EdFiInterventionReference interventionReference = default, EdFiStudentReference studentReference = default, string attendanceEventReason = default, string educationalEnvironmentDescriptor = default, double? eventDuration = default, int? interventionDuration = default, string etag = default, DateTime lastModifiedDate = default, Object ext = default)
        {
            // to ensure "attendanceEventCategoryDescriptor" is required (not null)
            if (attendanceEventCategoryDescriptor == null)
            {
                throw new ArgumentNullException("attendanceEventCategoryDescriptor is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            this.AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor;
            this.EventDate = eventDate;
            // to ensure "interventionReference" is required (not null)
            if (interventionReference == null)
            {
                throw new ArgumentNullException("interventionReference is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            this.InterventionReference = interventionReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.AttendanceEventReason = attendanceEventReason;
            this.EducationalEnvironmentDescriptor = educationalEnvironmentDescriptor;
            this.EventDuration = eventDuration;
            this.InterventionDuration = interventionDuration;
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
        /// A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.
        /// </summary>
        /// <value>A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.</value>
        [DataMember(Name = "attendanceEventCategoryDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string AttendanceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// Date for this attendance event.
        /// </summary>
        /// <value>Date for this attendance event.</value>
        [DataMember(Name = "eventDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly EventDate { get; set; }

        /// <summary>
        /// Gets or Sets InterventionReference
        /// </summary>
        [DataMember(Name = "interventionReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiInterventionReference InterventionReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The reported reason for a student&#39;s absence.
        /// </summary>
        /// <value>The reported reason for a student&#39;s absence.</value>
        [DataMember(Name = "attendanceEventReason", EmitDefaultValue = true)]
        public string AttendanceEventReason { get; set; }

        /// <summary>
        /// The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section.
        /// </summary>
        /// <value>The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section.</value>
        [DataMember(Name = "educationalEnvironmentDescriptor", EmitDefaultValue = true)]
        public string EducationalEnvironmentDescriptor { get; set; }

        /// <summary>
        /// The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33.
        /// </summary>
        /// <value>The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33.</value>
        [DataMember(Name = "eventDuration", EmitDefaultValue = true)]
        public double? EventDuration { get; set; }

        /// <summary>
        /// The duration in minutes in which the student participated in the intervention during this instance.
        /// </summary>
        /// <value>The duration in minutes in which the student participated in the intervention during this instance.</value>
        [DataMember(Name = "interventionDuration", EmitDefaultValue = true)]
        public int? InterventionDuration { get; set; }

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
        /// Extensions to the StudentInterventionAttendanceEvent entity.
        /// </summary>
        /// <value>Extensions to the StudentInterventionAttendanceEvent entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentInterventionAttendanceEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttendanceEventCategoryDescriptor: ").Append(AttendanceEventCategoryDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  InterventionReference: ").Append(InterventionReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  AttendanceEventReason: ").Append(AttendanceEventReason).Append("\n");
            sb.Append("  EducationalEnvironmentDescriptor: ").Append(EducationalEnvironmentDescriptor).Append("\n");
            sb.Append("  EventDuration: ").Append(EventDuration).Append("\n");
            sb.Append("  InterventionDuration: ").Append(InterventionDuration).Append("\n");
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
            // AttendanceEventCategoryDescriptor (string) maxLength
            if (this.AttendanceEventCategoryDescriptor != null && this.AttendanceEventCategoryDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for AttendanceEventCategoryDescriptor, length must be less than 306.", new [] { "AttendanceEventCategoryDescriptor" });
            }

            // AttendanceEventReason (string) maxLength
            if (this.AttendanceEventReason != null && this.AttendanceEventReason.Length > 255)
            {
                yield return new ValidationResult("Invalid value for AttendanceEventReason, length must be less than 255.", new [] { "AttendanceEventReason" });
            }

            // EducationalEnvironmentDescriptor (string) maxLength
            if (this.EducationalEnvironmentDescriptor != null && this.EducationalEnvironmentDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for EducationalEnvironmentDescriptor, length must be less than 306.", new [] { "EducationalEnvironmentDescriptor" });
            }

            // EventDuration (double?) maximum
            if (this.EventDuration > (double?)1.0)
            {
                yield return new ValidationResult("Invalid value for EventDuration, must be a value less than or equal to 1.0.", new [] { "EventDuration" });
            }

            // EventDuration (double?) minimum
            if (this.EventDuration < (double?)0.0)
            {
                yield return new ValidationResult("Invalid value for EventDuration, must be a value greater than or equal to 0.0.", new [] { "EventDuration" });
            }

            // InterventionDuration (int?) maximum
            if (this.InterventionDuration > (int?)1440)
            {
                yield return new ValidationResult("Invalid value for InterventionDuration, must be a value less than or equal to 1440.", new [] { "InterventionDuration" });
            }

            // InterventionDuration (int?) minimum
            if (this.InterventionDuration < (int?)0)
            {
                yield return new ValidationResult("Invalid value for InterventionDuration, must be a value greater than or equal to 0.", new [] { "InterventionDuration" });
            }

            yield break;
        }
    }

}
