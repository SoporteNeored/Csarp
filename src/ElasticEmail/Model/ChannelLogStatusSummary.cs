/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://elasticemail.com/account#/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    This is the documentation for REST API. If you’d like to read our legacy documentation regarding Web API v2 click <a target=\"_blank\" href=\"https://api.elasticemail.com/public/help\">here</a>.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
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
    /// Summary of channel log status
    /// </summary>
    [DataContract(Name = "ChannelLogStatusSummary")]
    public partial class ChannelLogStatusSummary : IEquatable<ChannelLogStatusSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelLogStatusSummary" /> class.
        /// </summary>
        /// <param name="channelName">Channel name.</param>
        /// <param name="recipients">Number of recipients.</param>
        /// <param name="emailTotal">Number of emails.</param>
        /// <param name="smsTotal">Number of SMS.</param>
        /// <param name="delivered">Number of delivered messages.</param>
        /// <param name="bounced">Number of bounced messages.</param>
        /// <param name="inProgress">Number of messages in progress.</param>
        /// <param name="opened">Number of opened messages.</param>
        /// <param name="clicked">Number of clicked messages.</param>
        /// <param name="unsubscribed">Number of unsubscribed messages.</param>
        /// <param name="complaints">Number of complaint messages.</param>
        /// <param name="inbound">Number of inbound messages.</param>
        /// <param name="manualCancel">Number of manually cancelled messages.</param>
        /// <param name="notDelivered">Number of messages flagged with &#39;Not Delivered&#39;.</param>
        public ChannelLogStatusSummary(string channelName = default(string), long recipients = default(long), long emailTotal = default(long), long smsTotal = default(long), long delivered = default(long), long bounced = default(long), long inProgress = default(long), long opened = default(long), long clicked = default(long), long unsubscribed = default(long), long complaints = default(long), long inbound = default(long), long manualCancel = default(long), long notDelivered = default(long))
        {
            this.ChannelName = channelName;
            this.Recipients = recipients;
            this.EmailTotal = emailTotal;
            this.SmsTotal = smsTotal;
            this.Delivered = delivered;
            this.Bounced = bounced;
            this.InProgress = inProgress;
            this.Opened = opened;
            this.Clicked = clicked;
            this.Unsubscribed = unsubscribed;
            this.Complaints = complaints;
            this.Inbound = inbound;
            this.ManualCancel = manualCancel;
            this.NotDelivered = notDelivered;
        }

        /// <summary>
        /// Channel name
        /// </summary>
        /// <value>Channel name</value>
        [DataMember(Name = "ChannelName", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Number of recipients
        /// </summary>
        /// <value>Number of recipients</value>
        [DataMember(Name = "Recipients", EmitDefaultValue = false)]
        public long Recipients { get; set; }

        /// <summary>
        /// Number of emails
        /// </summary>
        /// <value>Number of emails</value>
        [DataMember(Name = "EmailTotal", EmitDefaultValue = false)]
        public long EmailTotal { get; set; }

        /// <summary>
        /// Number of SMS
        /// </summary>
        /// <value>Number of SMS</value>
        [DataMember(Name = "SmsTotal", EmitDefaultValue = false)]
        public long SmsTotal { get; set; }

        /// <summary>
        /// Number of delivered messages
        /// </summary>
        /// <value>Number of delivered messages</value>
        [DataMember(Name = "Delivered", EmitDefaultValue = false)]
        public long Delivered { get; set; }

        /// <summary>
        /// Number of bounced messages
        /// </summary>
        /// <value>Number of bounced messages</value>
        [DataMember(Name = "Bounced", EmitDefaultValue = false)]
        public long Bounced { get; set; }

        /// <summary>
        /// Number of messages in progress
        /// </summary>
        /// <value>Number of messages in progress</value>
        [DataMember(Name = "InProgress", EmitDefaultValue = false)]
        public long InProgress { get; set; }

        /// <summary>
        /// Number of opened messages
        /// </summary>
        /// <value>Number of opened messages</value>
        [DataMember(Name = "Opened", EmitDefaultValue = false)]
        public long Opened { get; set; }

        /// <summary>
        /// Number of clicked messages
        /// </summary>
        /// <value>Number of clicked messages</value>
        [DataMember(Name = "Clicked", EmitDefaultValue = false)]
        public long Clicked { get; set; }

        /// <summary>
        /// Number of unsubscribed messages
        /// </summary>
        /// <value>Number of unsubscribed messages</value>
        [DataMember(Name = "Unsubscribed", EmitDefaultValue = false)]
        public long Unsubscribed { get; set; }

        /// <summary>
        /// Number of complaint messages
        /// </summary>
        /// <value>Number of complaint messages</value>
        [DataMember(Name = "Complaints", EmitDefaultValue = false)]
        public long Complaints { get; set; }

        /// <summary>
        /// Number of inbound messages
        /// </summary>
        /// <value>Number of inbound messages</value>
        [DataMember(Name = "Inbound", EmitDefaultValue = false)]
        public long Inbound { get; set; }

        /// <summary>
        /// Number of manually cancelled messages
        /// </summary>
        /// <value>Number of manually cancelled messages</value>
        [DataMember(Name = "ManualCancel", EmitDefaultValue = false)]
        public long ManualCancel { get; set; }

        /// <summary>
        /// Number of messages flagged with &#39;Not Delivered&#39;
        /// </summary>
        /// <value>Number of messages flagged with &#39;Not Delivered&#39;</value>
        [DataMember(Name = "NotDelivered", EmitDefaultValue = false)]
        public long NotDelivered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelLogStatusSummary {\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  EmailTotal: ").Append(EmailTotal).Append("\n");
            sb.Append("  SmsTotal: ").Append(SmsTotal).Append("\n");
            sb.Append("  Delivered: ").Append(Delivered).Append("\n");
            sb.Append("  Bounced: ").Append(Bounced).Append("\n");
            sb.Append("  InProgress: ").Append(InProgress).Append("\n");
            sb.Append("  Opened: ").Append(Opened).Append("\n");
            sb.Append("  Clicked: ").Append(Clicked).Append("\n");
            sb.Append("  Unsubscribed: ").Append(Unsubscribed).Append("\n");
            sb.Append("  Complaints: ").Append(Complaints).Append("\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  ManualCancel: ").Append(ManualCancel).Append("\n");
            sb.Append("  NotDelivered: ").Append(NotDelivered).Append("\n");
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
            return this.Equals(input as ChannelLogStatusSummary);
        }

        /// <summary>
        /// Returns true if ChannelLogStatusSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelLogStatusSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelLogStatusSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients.Equals(input.Recipients)
                ) && 
                (
                    this.EmailTotal == input.EmailTotal ||
                    this.EmailTotal.Equals(input.EmailTotal)
                ) && 
                (
                    this.SmsTotal == input.SmsTotal ||
                    this.SmsTotal.Equals(input.SmsTotal)
                ) && 
                (
                    this.Delivered == input.Delivered ||
                    this.Delivered.Equals(input.Delivered)
                ) && 
                (
                    this.Bounced == input.Bounced ||
                    this.Bounced.Equals(input.Bounced)
                ) && 
                (
                    this.InProgress == input.InProgress ||
                    this.InProgress.Equals(input.InProgress)
                ) && 
                (
                    this.Opened == input.Opened ||
                    this.Opened.Equals(input.Opened)
                ) && 
                (
                    this.Clicked == input.Clicked ||
                    this.Clicked.Equals(input.Clicked)
                ) && 
                (
                    this.Unsubscribed == input.Unsubscribed ||
                    this.Unsubscribed.Equals(input.Unsubscribed)
                ) && 
                (
                    this.Complaints == input.Complaints ||
                    this.Complaints.Equals(input.Complaints)
                ) && 
                (
                    this.Inbound == input.Inbound ||
                    this.Inbound.Equals(input.Inbound)
                ) && 
                (
                    this.ManualCancel == input.ManualCancel ||
                    this.ManualCancel.Equals(input.ManualCancel)
                ) && 
                (
                    this.NotDelivered == input.NotDelivered ||
                    this.NotDelivered.Equals(input.NotDelivered)
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
                if (this.ChannelName != null)
                    hashCode = hashCode * 59 + this.ChannelName.GetHashCode();
                hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                hashCode = hashCode * 59 + this.EmailTotal.GetHashCode();
                hashCode = hashCode * 59 + this.SmsTotal.GetHashCode();
                hashCode = hashCode * 59 + this.Delivered.GetHashCode();
                hashCode = hashCode * 59 + this.Bounced.GetHashCode();
                hashCode = hashCode * 59 + this.InProgress.GetHashCode();
                hashCode = hashCode * 59 + this.Opened.GetHashCode();
                hashCode = hashCode * 59 + this.Clicked.GetHashCode();
                hashCode = hashCode * 59 + this.Unsubscribed.GetHashCode();
                hashCode = hashCode * 59 + this.Complaints.GetHashCode();
                hashCode = hashCode * 59 + this.Inbound.GetHashCode();
                hashCode = hashCode * 59 + this.ManualCancel.GetHashCode();
                hashCode = hashCode * 59 + this.NotDelivered.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
