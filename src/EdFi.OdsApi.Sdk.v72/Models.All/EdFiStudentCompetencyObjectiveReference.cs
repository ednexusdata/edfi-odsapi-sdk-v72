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
    /// EdFiStudentCompetencyObjectiveReference
    /// </summary>
    [DataContract(Name = "edFi_studentCompetencyObjectiveReference")]
    public partial class EdFiStudentCompetencyObjectiveReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentCompetencyObjectiveReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentCompetencyObjectiveReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentCompetencyObjectiveReference" /> class.
        /// </summary>
        /// <param name="gradingPeriodDescriptor">The state&#39;s name of the period for which grades are reported. (required).</param>
        /// <param name="gradingPeriodName">The school&#39;s descriptive name of the grading period. (required).</param>
        /// <param name="gradingPeriodSchoolId">The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. (required).</param>
        /// <param name="gradingPeriodSchoolYear">The identifier for the grading period school year. (required).</param>
        /// <param name="objective">The designated title of the competency objective. (required).</param>
        /// <param name="objectiveEducationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="objectiveGradeLevelDescriptor">The grade level for which the competency objective is targeted. (required).</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStudentCompetencyObjectiveReference(string gradingPeriodDescriptor = default, string gradingPeriodName = default, long gradingPeriodSchoolId = default, int gradingPeriodSchoolYear = default, string objective = default, long objectiveEducationOrganizationId = default, string objectiveGradeLevelDescriptor = default, string studentUniqueId = default, Link link = default)
        {
            // to ensure "gradingPeriodDescriptor" is required (not null)
            if (gradingPeriodDescriptor == null)
            {
                throw new ArgumentNullException("gradingPeriodDescriptor is a required property for EdFiStudentCompetencyObjectiveReference and cannot be null");
            }
            this.GradingPeriodDescriptor = gradingPeriodDescriptor;
            // to ensure "gradingPeriodName" is required (not null)
            if (gradingPeriodName == null)
            {
                throw new ArgumentNullException("gradingPeriodName is a required property for EdFiStudentCompetencyObjectiveReference and cannot be null");
            }
            this.GradingPeriodName = gradingPeriodName;
            this.GradingPeriodSchoolId = gradingPeriodSchoolId;
            this.GradingPeriodSchoolYear = gradingPeriodSchoolYear;
            // to ensure "objective" is required (not null)
            if (objective == null)
            {
                throw new ArgumentNullException("objective is a required property for EdFiStudentCompetencyObjectiveReference and cannot be null");
            }
            this.Objective = objective;
            this.ObjectiveEducationOrganizationId = objectiveEducationOrganizationId;
            // to ensure "objectiveGradeLevelDescriptor" is required (not null)
            if (objectiveGradeLevelDescriptor == null)
            {
                throw new ArgumentNullException("objectiveGradeLevelDescriptor is a required property for EdFiStudentCompetencyObjectiveReference and cannot be null");
            }
            this.ObjectiveGradeLevelDescriptor = objectiveGradeLevelDescriptor;
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new ArgumentNullException("studentUniqueId is a required property for EdFiStudentCompetencyObjectiveReference and cannot be null");
            }
            this.StudentUniqueId = studentUniqueId;
            this.Link = link;
        }

        /// <summary>
        /// The state&#39;s name of the period for which grades are reported.
        /// </summary>
        /// <value>The state&#39;s name of the period for which grades are reported.</value>
        [DataMember(Name = "gradingPeriodDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The school&#39;s descriptive name of the grading period.
        /// </summary>
        /// <value>The school&#39;s descriptive name of the grading period.</value>
        [DataMember(Name = "gradingPeriodName", IsRequired = true, EmitDefaultValue = true)]
        public string GradingPeriodName { get; set; }

        /// <summary>
        /// The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.
        /// </summary>
        /// <value>The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.</value>
        [DataMember(Name = "gradingPeriodSchoolId", IsRequired = true, EmitDefaultValue = true)]
        public long GradingPeriodSchoolId { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name = "gradingPeriodSchoolYear", IsRequired = true, EmitDefaultValue = true)]
        public int GradingPeriodSchoolYear { get; set; }

        /// <summary>
        /// The designated title of the competency objective.
        /// </summary>
        /// <value>The designated title of the competency objective.</value>
        [DataMember(Name = "objective", IsRequired = true, EmitDefaultValue = true)]
        public string Objective { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "objectiveEducationOrganizationId", IsRequired = true, EmitDefaultValue = true)]
        public long ObjectiveEducationOrganizationId { get; set; }

        /// <summary>
        /// The grade level for which the competency objective is targeted.
        /// </summary>
        /// <value>The grade level for which the competency objective is targeted.</value>
        [DataMember(Name = "objectiveGradeLevelDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string ObjectiveGradeLevelDescriptor { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", IsRequired = true, EmitDefaultValue = true)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentCompetencyObjectiveReference {\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  GradingPeriodName: ").Append(GradingPeriodName).Append("\n");
            sb.Append("  GradingPeriodSchoolId: ").Append(GradingPeriodSchoolId).Append("\n");
            sb.Append("  GradingPeriodSchoolYear: ").Append(GradingPeriodSchoolYear).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  ObjectiveEducationOrganizationId: ").Append(ObjectiveEducationOrganizationId).Append("\n");
            sb.Append("  ObjectiveGradeLevelDescriptor: ").Append(ObjectiveGradeLevelDescriptor).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            // GradingPeriodDescriptor (string) maxLength
            if (this.GradingPeriodDescriptor != null && this.GradingPeriodDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for GradingPeriodDescriptor, length must be less than 306.", new [] { "GradingPeriodDescriptor" });
            }

            // GradingPeriodName (string) maxLength
            if (this.GradingPeriodName != null && this.GradingPeriodName.Length > 60)
            {
                yield return new ValidationResult("Invalid value for GradingPeriodName, length must be less than 60.", new [] { "GradingPeriodName" });
            }

            // Objective (string) maxLength
            if (this.Objective != null && this.Objective.Length > 60)
            {
                yield return new ValidationResult("Invalid value for Objective, length must be less than 60.", new [] { "Objective" });
            }

            // ObjectiveGradeLevelDescriptor (string) maxLength
            if (this.ObjectiveGradeLevelDescriptor != null && this.ObjectiveGradeLevelDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ObjectiveGradeLevelDescriptor, length must be less than 306.", new [] { "ObjectiveGradeLevelDescriptor" });
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
