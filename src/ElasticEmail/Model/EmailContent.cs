/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://app.elasticemail.com/marketing/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
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
    /// Proper e-mail content
    /// </summary>
    [DataContract(Name = "EmailContent")]
    public partial class EmailContent : IEquatable<EmailContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailContent" /> class.
        /// </summary>
        /// <param name="body">List of e-mail body parts, with user-provided MIME types (text/html, text/plain etc).</param>
        /// <param name="merge">A key-value collection of custom merge fields, shared between recipients. Should be used in e-mail body like so: {firstname}, {lastname} etc..</param>
        /// <param name="attachments">Attachments provided by sending binary data.</param>
        /// <param name="headers">A key-value collection of custom e-mail headers..</param>
        /// <param name="postback">Postback header..</param>
        /// <param name="envelopeFrom">E-mail with an optional name to be used as the envelope from address (e.g.: John Doe &lt;email@domain.com&gt;).</param>
        /// <param name="from">Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;).</param>
        /// <param name="replyTo">To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;).</param>
        /// <param name="subject">Default subject of email..</param>
        /// <param name="templateName">Name of template..</param>
        /// <param name="attachFiles">Names of previously uploaded files that should be sent as downloadable attachments.</param>
        /// <param name="utm">utm.</param>
        public EmailContent(List<BodyPart> body = default(List<BodyPart>), Dictionary<string, string> merge = default(Dictionary<string, string>), List<MessageAttachment> attachments = default(List<MessageAttachment>), Dictionary<string, string> headers = default(Dictionary<string, string>), string postback = default(string), string envelopeFrom = default(string), string from = default(string), string replyTo = default(string), string subject = default(string), string templateName = default(string), List<string> attachFiles = default(List<string>), Utm utm = default(Utm))
        {
            this.Body = body;
            this.Merge = merge;
            this.Attachments = attachments;
            this.Headers = headers;
            this.Postback = postback;
            this.EnvelopeFrom = envelopeFrom;
            this.From = from;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.TemplateName = templateName;
            this.AttachFiles = attachFiles;
            this.Utm = utm;
        }

        /// <summary>
        /// List of e-mail body parts, with user-provided MIME types (text/html, text/plain etc)
        /// </summary>
        /// <value>List of e-mail body parts, with user-provided MIME types (text/html, text/plain etc)</value>
        [DataMember(Name = "Body", EmitDefaultValue = false)]
        public List<BodyPart> Body { get; set; }

        /// <summary>
        /// A key-value collection of custom merge fields, shared between recipients. Should be used in e-mail body like so: {firstname}, {lastname} etc.
        /// </summary>
        /// <value>A key-value collection of custom merge fields, shared between recipients. Should be used in e-mail body like so: {firstname}, {lastname} etc.</value>
        [DataMember(Name = "Merge", EmitDefaultValue = false)]
        public Dictionary<string, string> Merge { get; set; }

        /// <summary>
        /// Attachments provided by sending binary data
        /// </summary>
        /// <value>Attachments provided by sending binary data</value>
        [DataMember(Name = "Attachments", EmitDefaultValue = false)]
        public List<MessageAttachment> Attachments { get; set; }

        /// <summary>
        /// A key-value collection of custom e-mail headers.
        /// </summary>
        /// <value>A key-value collection of custom e-mail headers.</value>
        [DataMember(Name = "Headers", EmitDefaultValue = false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Postback header.
        /// </summary>
        /// <value>Postback header.</value>
        [DataMember(Name = "Postback", EmitDefaultValue = false)]
        public string Postback { get; set; }

        /// <summary>
        /// E-mail with an optional name to be used as the envelope from address (e.g.: John Doe &lt;email@domain.com&gt;)
        /// </summary>
        /// <value>E-mail with an optional name to be used as the envelope from address (e.g.: John Doe &lt;email@domain.com&gt;)</value>
        [DataMember(Name = "EnvelopeFrom", EmitDefaultValue = false)]
        public string EnvelopeFrom { get; set; }

        /// <summary>
        /// Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;)
        /// </summary>
        /// <value>Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;)</value>
        [DataMember(Name = "From", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;)
        /// </summary>
        /// <value>To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;)</value>
        [DataMember(Name = "ReplyTo", EmitDefaultValue = false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        /// <value>Default subject of email.</value>
        [DataMember(Name = "Subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Name of template.
        /// </summary>
        /// <value>Name of template.</value>
        [DataMember(Name = "TemplateName", EmitDefaultValue = false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Names of previously uploaded files that should be sent as downloadable attachments
        /// </summary>
        /// <value>Names of previously uploaded files that should be sent as downloadable attachments</value>
        [DataMember(Name = "AttachFiles", EmitDefaultValue = false)]
        public List<string> AttachFiles { get; set; }

        /// <summary>
        /// Gets or Sets Utm
        /// </summary>
        [DataMember(Name = "Utm", EmitDefaultValue = false)]
        public Utm Utm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailContent {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Merge: ").Append(Merge).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Postback: ").Append(Postback).Append("\n");
            sb.Append("  EnvelopeFrom: ").Append(EnvelopeFrom).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  AttachFiles: ").Append(AttachFiles).Append("\n");
            sb.Append("  Utm: ").Append(Utm).Append("\n");
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
            return this.Equals(input as EmailContent);
        }

        /// <summary>
        /// Returns true if EmailContent instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Body == input.Body ||
                    this.Body != null &&
                    input.Body != null &&
                    this.Body.SequenceEqual(input.Body)
                ) && 
                (
                    this.Merge == input.Merge ||
                    this.Merge != null &&
                    input.Merge != null &&
                    this.Merge.SequenceEqual(input.Merge)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Postback == input.Postback ||
                    (this.Postback != null &&
                    this.Postback.Equals(input.Postback))
                ) && 
                (
                    this.EnvelopeFrom == input.EnvelopeFrom ||
                    (this.EnvelopeFrom != null &&
                    this.EnvelopeFrom.Equals(input.EnvelopeFrom))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.AttachFiles == input.AttachFiles ||
                    this.AttachFiles != null &&
                    input.AttachFiles != null &&
                    this.AttachFiles.SequenceEqual(input.AttachFiles)
                ) && 
                (
                    this.Utm == input.Utm ||
                    (this.Utm != null &&
                    this.Utm.Equals(input.Utm))
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
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Merge != null)
                {
                    hashCode = (hashCode * 59) + this.Merge.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Headers != null)
                {
                    hashCode = (hashCode * 59) + this.Headers.GetHashCode();
                }
                if (this.Postback != null)
                {
                    hashCode = (hashCode * 59) + this.Postback.GetHashCode();
                }
                if (this.EnvelopeFrom != null)
                {
                    hashCode = (hashCode * 59) + this.EnvelopeFrom.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.ReplyTo != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyTo.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.TemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateName.GetHashCode();
                }
                if (this.AttachFiles != null)
                {
                    hashCode = (hashCode * 59) + this.AttachFiles.GetHashCode();
                }
                if (this.Utm != null)
                {
                    hashCode = (hashCode * 59) + this.Utm.GetHashCode();
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
