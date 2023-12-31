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
    /// Status information of the specified email
    /// </summary>
    [DataContract(Name = "EmailStatus")]
    public partial class EmailStatus : IEquatable<EmailStatus>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public LogJobStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailStatus" /> class.
        /// </summary>
        /// <param name="from">Email address this email was sent from..</param>
        /// <param name="to">Email address this email was sent to..</param>
        /// <param name="date">Date the email was submitted..</param>
        /// <param name="status">status.</param>
        /// <param name="statusName">Name of email&#39;s status.</param>
        /// <param name="statusChangeDate">Date of last status change..</param>
        /// <param name="dateSent">Date when the email was sent.</param>
        /// <param name="dateOpened">Date when the email changed the status to &#39;opened&#39;.</param>
        /// <param name="dateClicked">Date when the email changed the status to &#39;clicked&#39;.</param>
        /// <param name="errorMessage">Detailed error or bounced message..</param>
        /// <param name="transactionID">ID number of transaction.</param>
        /// <param name="envelopeFrom">Envelope from address.</param>
        public EmailStatus(string from = default(string), string to = default(string), DateTime date = default(DateTime), LogJobStatus? status = default(LogJobStatus?), string statusName = default(string), DateTime statusChangeDate = default(DateTime), DateTime dateSent = default(DateTime), DateTime? dateOpened = default(DateTime?), DateTime? dateClicked = default(DateTime?), string errorMessage = default(string), string transactionID = default(string), string envelopeFrom = default(string))
        {
            this.From = from;
            this.To = to;
            this.Date = date;
            this.Status = status;
            this.StatusName = statusName;
            this.StatusChangeDate = statusChangeDate;
            this.DateSent = dateSent;
            this.DateOpened = dateOpened;
            this.DateClicked = dateClicked;
            this.ErrorMessage = errorMessage;
            this.TransactionID = transactionID;
            this.EnvelopeFrom = envelopeFrom;
        }

        /// <summary>
        /// Email address this email was sent from.
        /// </summary>
        /// <value>Email address this email was sent from.</value>
        [DataMember(Name = "From", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Email address this email was sent to.
        /// </summary>
        /// <value>Email address this email was sent to.</value>
        [DataMember(Name = "To", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Date the email was submitted.
        /// </summary>
        /// <value>Date the email was submitted.</value>
        [DataMember(Name = "Date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Name of email&#39;s status
        /// </summary>
        /// <value>Name of email&#39;s status</value>
        [DataMember(Name = "StatusName", EmitDefaultValue = false)]
        public string StatusName { get; set; }

        /// <summary>
        /// Date of last status change.
        /// </summary>
        /// <value>Date of last status change.</value>
        [DataMember(Name = "StatusChangeDate", EmitDefaultValue = false)]
        public DateTime StatusChangeDate { get; set; }

        /// <summary>
        /// Date when the email was sent
        /// </summary>
        /// <value>Date when the email was sent</value>
        [DataMember(Name = "DateSent", EmitDefaultValue = false)]
        public DateTime DateSent { get; set; }

        /// <summary>
        /// Date when the email changed the status to &#39;opened&#39;
        /// </summary>
        /// <value>Date when the email changed the status to &#39;opened&#39;</value>
        [DataMember(Name = "DateOpened", EmitDefaultValue = true)]
        public DateTime? DateOpened { get; set; }

        /// <summary>
        /// Date when the email changed the status to &#39;clicked&#39;
        /// </summary>
        /// <value>Date when the email changed the status to &#39;clicked&#39;</value>
        [DataMember(Name = "DateClicked", EmitDefaultValue = true)]
        public DateTime? DateClicked { get; set; }

        /// <summary>
        /// Detailed error or bounced message.
        /// </summary>
        /// <value>Detailed error or bounced message.</value>
        [DataMember(Name = "ErrorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// ID number of transaction
        /// </summary>
        /// <value>ID number of transaction</value>
        [DataMember(Name = "TransactionID", EmitDefaultValue = false)]
        public string TransactionID { get; set; }

        /// <summary>
        /// Envelope from address
        /// </summary>
        /// <value>Envelope from address</value>
        [DataMember(Name = "EnvelopeFrom", EmitDefaultValue = false)]
        public string EnvelopeFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailStatus {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusName: ").Append(StatusName).Append("\n");
            sb.Append("  StatusChangeDate: ").Append(StatusChangeDate).Append("\n");
            sb.Append("  DateSent: ").Append(DateSent).Append("\n");
            sb.Append("  DateOpened: ").Append(DateOpened).Append("\n");
            sb.Append("  DateClicked: ").Append(DateClicked).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  TransactionID: ").Append(TransactionID).Append("\n");
            sb.Append("  EnvelopeFrom: ").Append(EnvelopeFrom).Append("\n");
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
            return this.Equals(input as EmailStatus);
        }

        /// <summary>
        /// Returns true if EmailStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusName == input.StatusName ||
                    (this.StatusName != null &&
                    this.StatusName.Equals(input.StatusName))
                ) && 
                (
                    this.StatusChangeDate == input.StatusChangeDate ||
                    (this.StatusChangeDate != null &&
                    this.StatusChangeDate.Equals(input.StatusChangeDate))
                ) && 
                (
                    this.DateSent == input.DateSent ||
                    (this.DateSent != null &&
                    this.DateSent.Equals(input.DateSent))
                ) && 
                (
                    this.DateOpened == input.DateOpened ||
                    (this.DateOpened != null &&
                    this.DateOpened.Equals(input.DateOpened))
                ) && 
                (
                    this.DateClicked == input.DateClicked ||
                    (this.DateClicked != null &&
                    this.DateClicked.Equals(input.DateClicked))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.TransactionID == input.TransactionID ||
                    (this.TransactionID != null &&
                    this.TransactionID.Equals(input.TransactionID))
                ) && 
                (
                    this.EnvelopeFrom == input.EnvelopeFrom ||
                    (this.EnvelopeFrom != null &&
                    this.EnvelopeFrom.Equals(input.EnvelopeFrom))
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
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusName != null)
                {
                    hashCode = (hashCode * 59) + this.StatusName.GetHashCode();
                }
                if (this.StatusChangeDate != null)
                {
                    hashCode = (hashCode * 59) + this.StatusChangeDate.GetHashCode();
                }
                if (this.DateSent != null)
                {
                    hashCode = (hashCode * 59) + this.DateSent.GetHashCode();
                }
                if (this.DateOpened != null)
                {
                    hashCode = (hashCode * 59) + this.DateOpened.GetHashCode();
                }
                if (this.DateClicked != null)
                {
                    hashCode = (hashCode * 59) + this.DateClicked.GetHashCode();
                }
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                if (this.TransactionID != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionID.GetHashCode();
                }
                if (this.EnvelopeFrom != null)
                {
                    hashCode = (hashCode * 59) + this.EnvelopeFrom.GetHashCode();
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
