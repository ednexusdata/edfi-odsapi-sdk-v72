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
    /// EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode
    /// </summary>
    [DataContract(Name = "edFi_studentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode")]
    public partial class EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode" /> class.
        /// </summary>
        /// <param name="disciplineIncidentParticipationCodeDescriptor">The role or type of participation of a student in a discipline incident. (required).</param>
        /// <param name="ext">Extensions to the StudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode entity..</param>
        public EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode(string disciplineIncidentParticipationCodeDescriptor = default, Object ext = default)
        {
            // to ensure "disciplineIncidentParticipationCodeDescriptor" is required (not null)
            if (disciplineIncidentParticipationCodeDescriptor == null)
            {
                throw new ArgumentNullException("disciplineIncidentParticipationCodeDescriptor is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode and cannot be null");
            }
            this.DisciplineIncidentParticipationCodeDescriptor = disciplineIncidentParticipationCodeDescriptor;
            this.Ext = ext;
        }

        /// <summary>
        /// The role or type of participation of a student in a discipline incident.
        /// </summary>
        /// <value>The role or type of participation of a student in a discipline incident.</value>
        [DataMember(Name = "disciplineIncidentParticipationCodeDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string DisciplineIncidentParticipationCodeDescriptor { get; set; }

        /// <summary>
        /// Extensions to the StudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode entity.
        /// </summary>
        /// <value>Extensions to the StudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode {\n");
            sb.Append("  DisciplineIncidentParticipationCodeDescriptor: ").Append(DisciplineIncidentParticipationCodeDescriptor).Append("\n");
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
            // DisciplineIncidentParticipationCodeDescriptor (string) maxLength
            if (this.DisciplineIncidentParticipationCodeDescriptor != null && this.DisciplineIncidentParticipationCodeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for DisciplineIncidentParticipationCodeDescriptor, length must be less than 306.", new [] { "DisciplineIncidentParticipationCodeDescriptor" });
            }

            yield break;
        }
    }

}
