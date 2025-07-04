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
    /// EdFiPostSecondaryInstitutionMediumOfInstruction
    /// </summary>
    [DataContract(Name = "edFi_postSecondaryInstitutionMediumOfInstruction")]
    public partial class EdFiPostSecondaryInstitutionMediumOfInstruction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPostSecondaryInstitutionMediumOfInstruction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiPostSecondaryInstitutionMediumOfInstruction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPostSecondaryInstitutionMediumOfInstruction" /> class.
        /// </summary>
        /// <param name="mediumOfInstructionDescriptor">The categories in which an institution serves the students. (required).</param>
        /// <param name="ext">Extensions to the PostSecondaryInstitutionMediumOfInstruction entity..</param>
        public EdFiPostSecondaryInstitutionMediumOfInstruction(string mediumOfInstructionDescriptor = default, Object ext = default)
        {
            // to ensure "mediumOfInstructionDescriptor" is required (not null)
            if (mediumOfInstructionDescriptor == null)
            {
                throw new ArgumentNullException("mediumOfInstructionDescriptor is a required property for EdFiPostSecondaryInstitutionMediumOfInstruction and cannot be null");
            }
            this.MediumOfInstructionDescriptor = mediumOfInstructionDescriptor;
            this.Ext = ext;
        }

        /// <summary>
        /// The categories in which an institution serves the students.
        /// </summary>
        /// <value>The categories in which an institution serves the students.</value>
        [DataMember(Name = "mediumOfInstructionDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string MediumOfInstructionDescriptor { get; set; }

        /// <summary>
        /// Extensions to the PostSecondaryInstitutionMediumOfInstruction entity.
        /// </summary>
        /// <value>Extensions to the PostSecondaryInstitutionMediumOfInstruction entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiPostSecondaryInstitutionMediumOfInstruction {\n");
            sb.Append("  MediumOfInstructionDescriptor: ").Append(MediumOfInstructionDescriptor).Append("\n");
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
            // MediumOfInstructionDescriptor (string) maxLength
            if (this.MediumOfInstructionDescriptor != null && this.MediumOfInstructionDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for MediumOfInstructionDescriptor, length must be less than 306.", new [] { "MediumOfInstructionDescriptor" });
            }

            yield break;
        }
    }

}
