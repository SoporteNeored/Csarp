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
    /// Email data
    /// </summary>
    [DataContract(Name = "EmailTransactionalMessageData")]
    public partial class EmailTransactionalMessageData : IEquatable<EmailTransactionalMessageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTransactionalMessageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailTransactionalMessageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTransactionalMessageData" /> class.
        /// </summary>
        /// <param name="recipients">recipients (required).</param>
        /// <param name="content">content.</param>
        /// <param name="options">options.</param>
        public EmailTransactionalMessageData(TransactionalRecipient recipients = default(TransactionalRecipient), EmailContent content = default(EmailContent), Options options = default(Options))
        {
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients is a required property for EmailTransactionalMessageData and cannot be null");
            }
            this.Recipients = recipients;
            this.Content = content;
            this.Options = options;
        }

        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name = "Recipients", IsRequired = true, EmitDefaultValue = false)]
        public TransactionalRecipient Recipients { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "Content", EmitDefaultValue = false)]
        public EmailContent Content { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "Options", EmitDefaultValue = false)]
        public Options Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailTransactionalMessageData {\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as EmailTransactionalMessageData);
        }

        /// <summary>
        /// Returns true if EmailTransactionalMessageData instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailTransactionalMessageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTransactionalMessageData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Recipients == input.Recipients ||
                    (this.Recipients != null &&
                    this.Recipients.Equals(input.Recipients))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.Recipients != null)
                {
                    hashCode = (hashCode * 59) + this.Recipients.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
