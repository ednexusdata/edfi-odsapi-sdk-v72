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
    /// TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_studentEducationOrganizationResponsibilityAssociationKey")]
    public partial class TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationKey" /> class.
        /// </summary>
        /// <param name="responsibilityDescriptor">Indications of an education organization&#39;s responsibility for a student, such as accountability, attendance, funding, etc..</param>
        /// <param name="beginDate">Month, day, and year of the start date of an education organization&#39;s responsibility for a student..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationKey(string responsibilityDescriptor = default, DateOnly beginDate = default, long educationOrganizationId = default, string studentUniqueId = default)
        {
            this.ResponsibilityDescriptor = responsibilityDescriptor;
            this.BeginDate = beginDate;
            this.EducationOrganizationId = educationOrganizationId;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// Indications of an education organization&#39;s responsibility for a student, such as accountability, attendance, funding, etc.
        /// </summary>
        /// <value>Indications of an education organization&#39;s responsibility for a student, such as accountability, attendance, funding, etc.</value>
        [DataMember(Name = "responsibilityDescriptor", EmitDefaultValue = false)]
        public string ResponsibilityDescriptor { get; set; }

        /// <summary>
        /// Month, day, and year of the start date of an education organization&#39;s responsibility for a student.
        /// </summary>
        /// <value>Month, day, and year of the start date of an education organization&#39;s responsibility for a student.</value>
        [DataMember(Name = "beginDate", EmitDefaultValue = false)]
        public DateOnly BeginDate { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationKey {\n");
            sb.Append("  ResponsibilityDescriptor: ").Append(ResponsibilityDescriptor).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            // ResponsibilityDescriptor (string) maxLength
            if (this.ResponsibilityDescriptor != null && this.ResponsibilityDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ResponsibilityDescriptor, length must be less than 306.", new [] { "ResponsibilityDescriptor" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
