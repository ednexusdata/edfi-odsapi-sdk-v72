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
    /// EdFiClassPeriodMeetingTime
    /// </summary>
    [DataContract(Name = "edFi_classPeriodMeetingTime")]
    public partial class EdFiClassPeriodMeetingTime : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodMeetingTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiClassPeriodMeetingTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodMeetingTime" /> class.
        /// </summary>
        /// <param name="endTime">An indication of the time of day the meeting time ends. (required).</param>
        /// <param name="startTime">An indication of the time of day the meeting time begins. (required).</param>
        /// <param name="ext">Extensions to the ClassPeriodMeetingTime entity..</param>
        public EdFiClassPeriodMeetingTime(string endTime = default, string startTime = default, Object ext = default)
        {
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new ArgumentNullException("endTime is a required property for EdFiClassPeriodMeetingTime and cannot be null");
            }
            this.EndTime = endTime;
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new ArgumentNullException("startTime is a required property for EdFiClassPeriodMeetingTime and cannot be null");
            }
            this.StartTime = startTime;
            this.Ext = ext;
        }

        /// <summary>
        /// An indication of the time of day the meeting time ends.
        /// </summary>
        /// <value>An indication of the time of day the meeting time ends.</value>
        [DataMember(Name = "endTime", IsRequired = true, EmitDefaultValue = true)]
        public string EndTime { get; set; }

        /// <summary>
        /// An indication of the time of day the meeting time begins.
        /// </summary>
        /// <value>An indication of the time of day the meeting time begins.</value>
        [DataMember(Name = "startTime", IsRequired = true, EmitDefaultValue = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Extensions to the ClassPeriodMeetingTime entity.
        /// </summary>
        /// <value>Extensions to the ClassPeriodMeetingTime entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiClassPeriodMeetingTime {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            yield break;
        }
    }

}
