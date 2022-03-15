/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://elasticemail.com/account#/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
 *
 * The version of the OpenAPI document: 4.0.0
 * Contact: support@elasticemail.com
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
using OpenAPIDateConverter = ElasticEmail.Client.OpenAPIDateConverter;

namespace ElasticEmail.Model
{
    /// <summary>
    /// EmailData
    /// </summary>
    [DataContract(Name = "EmailData")]
    public partial class EmailData : IEquatable<EmailData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailData" /> class.
        /// </summary>
        /// <param name="preview">preview.</param>
        /// <param name="attachments">Attachments sent with the email.</param>
        /// <param name="status">status.</param>
        public EmailData(EmailView preview = default(EmailView), List<FileInfo> attachments = default(List<FileInfo>), EmailStatus status = default(EmailStatus))
        {
            this.Preview = preview;
            this.Attachments = attachments;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name = "Preview", EmitDefaultValue = false)]
        public EmailView Preview { get; set; }

        /// <summary>
        /// Attachments sent with the email
        /// </summary>
        /// <value>Attachments sent with the email</value>
        [DataMember(Name = "Attachments", EmitDefaultValue = false)]
        public List<FileInfo> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public EmailStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailData {\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as EmailData);
        }

        /// <summary>
        /// Returns true if EmailData instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Preview != null)
                {
                    hashCode = (hashCode * 59) + this.Preview.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
