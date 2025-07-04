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
    /// EdFiStudentHealth
    /// </summary>
    [DataContract(Name = "edFi_studentHealth")]
    public partial class EdFiStudentHealth : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHealth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentHealth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHealth" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="additionalImmunizations">An unordered collection of studentHealthAdditionalImmunizations. A record of additional immunizations satisfactorily received and reported..</param>
        /// <param name="asOfDate">Date of last update of the student&#39;s health record. (required).</param>
        /// <param name="nonMedicalImmunizationExemptionDate">The year, month and day of the nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian..</param>
        /// <param name="nonMedicalImmunizationExemptionDescriptor">The type of nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian..</param>
        /// <param name="requiredImmunizations">An unordered collection of studentHealthRequiredImmunizations. A record of the immunizations satisfactorily  received for those recommended to protect the student against vaccine-preventable diseases..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        /// <param name="ext">Extensions to the StudentHealth entity..</param>
        public EdFiStudentHealth(string id = default, EdFiEducationOrganizationReference educationOrganizationReference = default, EdFiStudentReference studentReference = default, List<EdFiStudentHealthAdditionalImmunization> additionalImmunizations = default, DateOnly asOfDate = default, DateOnly? nonMedicalImmunizationExemptionDate = default, string nonMedicalImmunizationExemptionDescriptor = default, List<EdFiStudentHealthRequiredImmunization> requiredImmunizations = default, string etag = default, DateTime lastModifiedDate = default, Object ext = default)
        {
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new ArgumentNullException("educationOrganizationReference is a required property for EdFiStudentHealth and cannot be null");
            }
            this.EducationOrganizationReference = educationOrganizationReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiStudentHealth and cannot be null");
            }
            this.StudentReference = studentReference;
            this.AsOfDate = asOfDate;
            this.Id = id;
            this.AdditionalImmunizations = additionalImmunizations;
            this.NonMedicalImmunizationExemptionDate = nonMedicalImmunizationExemptionDate;
            this.NonMedicalImmunizationExemptionDescriptor = nonMedicalImmunizationExemptionDescriptor;
            this.RequiredImmunizations = requiredImmunizations;
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
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// An unordered collection of studentHealthAdditionalImmunizations. A record of additional immunizations satisfactorily received and reported.
        /// </summary>
        /// <value>An unordered collection of studentHealthAdditionalImmunizations. A record of additional immunizations satisfactorily received and reported.</value>
        [DataMember(Name = "additionalImmunizations", EmitDefaultValue = false)]
        public List<EdFiStudentHealthAdditionalImmunization> AdditionalImmunizations { get; set; }

        /// <summary>
        /// Date of last update of the student&#39;s health record.
        /// </summary>
        /// <value>Date of last update of the student&#39;s health record.</value>
        [DataMember(Name = "asOfDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly AsOfDate { get; set; }

        /// <summary>
        /// The year, month and day of the nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian.
        /// </summary>
        /// <value>The year, month and day of the nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian.</value>
        [DataMember(Name = "nonMedicalImmunizationExemptionDate", EmitDefaultValue = true)]
        public DateOnly? NonMedicalImmunizationExemptionDate { get; set; }

        /// <summary>
        /// The type of nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian.
        /// </summary>
        /// <value>The type of nonmedical exemption from vaccination claimed by the student&#39;s parent or guardian.</value>
        [DataMember(Name = "nonMedicalImmunizationExemptionDescriptor", EmitDefaultValue = true)]
        public string NonMedicalImmunizationExemptionDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentHealthRequiredImmunizations. A record of the immunizations satisfactorily  received for those recommended to protect the student against vaccine-preventable diseases.
        /// </summary>
        /// <value>An unordered collection of studentHealthRequiredImmunizations. A record of the immunizations satisfactorily  received for those recommended to protect the student against vaccine-preventable diseases.</value>
        [DataMember(Name = "requiredImmunizations", EmitDefaultValue = false)]
        public List<EdFiStudentHealthRequiredImmunization> RequiredImmunizations { get; set; }

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
        /// Extensions to the StudentHealth entity.
        /// </summary>
        /// <value>Extensions to the StudentHealth entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentHealth {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  AdditionalImmunizations: ").Append(AdditionalImmunizations).Append("\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  NonMedicalImmunizationExemptionDate: ").Append(NonMedicalImmunizationExemptionDate).Append("\n");
            sb.Append("  NonMedicalImmunizationExemptionDescriptor: ").Append(NonMedicalImmunizationExemptionDescriptor).Append("\n");
            sb.Append("  RequiredImmunizations: ").Append(RequiredImmunizations).Append("\n");
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
            // NonMedicalImmunizationExemptionDescriptor (string) maxLength
            if (this.NonMedicalImmunizationExemptionDescriptor != null && this.NonMedicalImmunizationExemptionDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for NonMedicalImmunizationExemptionDescriptor, length must be less than 306.", new [] { "NonMedicalImmunizationExemptionDescriptor" });
            }

            yield break;
        }
    }

}
