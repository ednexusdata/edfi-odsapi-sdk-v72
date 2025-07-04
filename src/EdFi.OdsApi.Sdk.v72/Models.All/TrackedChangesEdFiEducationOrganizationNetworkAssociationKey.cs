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
    /// TrackedChangesEdFiEducationOrganizationNetworkAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_educationOrganizationNetworkAssociationKey")]
    public partial class TrackedChangesEdFiEducationOrganizationNetworkAssociationKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiEducationOrganizationNetworkAssociationKey" /> class.
        /// </summary>
        /// <param name="memberEducationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="educationOrganizationNetworkId">The identifier assigned to a network of education organizations. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication..</param>
        public TrackedChangesEdFiEducationOrganizationNetworkAssociationKey(long memberEducationOrganizationId = default, long educationOrganizationNetworkId = default)
        {
            this.MemberEducationOrganizationId = memberEducationOrganizationId;
            this.EducationOrganizationNetworkId = educationOrganizationNetworkId;
        }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "memberEducationOrganizationId", EmitDefaultValue = false)]
        public long MemberEducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier assigned to a network of education organizations. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.
        /// </summary>
        /// <value>The identifier assigned to a network of education organizations. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.</value>
        [DataMember(Name = "educationOrganizationNetworkId", EmitDefaultValue = false)]
        public long EducationOrganizationNetworkId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiEducationOrganizationNetworkAssociationKey {\n");
            sb.Append("  MemberEducationOrganizationId: ").Append(MemberEducationOrganizationId).Append("\n");
            sb.Append("  EducationOrganizationNetworkId: ").Append(EducationOrganizationNetworkId).Append("\n");
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
            yield break;
        }
    }

}
