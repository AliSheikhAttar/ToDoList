/*
 * Project_web1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
using OpenAPIDateConverter = To_DoApiCli.Client.OpenAPIDateConverter;

namespace To_DoApiCli.Model
{
    /// <summary>
    /// ToDo
    /// </summary>
    [DataContract(Name = "To_Do")]
    public partial class ToDo : IEquatable<ToDo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToDo" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="message">message.</param>
        /// <param name="subjectId">subjectId.</param>
        public ToDo(DateTime date = default(DateTime), string message = default(string), string subjectId = default(string))
        {
            this.Date = date;
            this.Message = message;
            this.SubjectId = subjectId;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SubjectId
        /// </summary>
        [DataMember(Name = "subjectId", EmitDefaultValue = true)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToDo {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ToDo);
        }

        /// <summary>
        /// Returns true if ToDo instances are equal
        /// </summary>
        /// <param name="input">Instance of ToDo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToDo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SubjectId == input.SubjectId ||
                    (this.SubjectId != null &&
                    this.SubjectId.Equals(input.SubjectId))
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
                int hashCode = 41;
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.SubjectId != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
