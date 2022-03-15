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
    /// ContactHistory
    /// </summary>
    [DataContract(Name = "ContactHistory")]
    public partial class ContactHistory : IEquatable<ContactHistory>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "EventType", EmitDefaultValue = false)]
        public ContactHistEventType? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactHistory" /> class.
        /// </summary>
        /// <param name="eventType">eventType.</param>
        /// <param name="eventDate">Formatted date of event..</param>
        /// <param name="channelName">Name of channel this event occured on.</param>
        /// <param name="templateName">Name of template this event occured on.</param>
        /// <param name="iPAddress">IP Address of the event..</param>
        /// <param name="country">Country of the event..</param>
        /// <param name="data">Additional information about the event.</param>
        public ContactHistory(ContactHistEventType? eventType = default(ContactHistEventType?), DateTime eventDate = default(DateTime), string channelName = default(string), string templateName = default(string), string iPAddress = default(string), string country = default(string), string data = default(string))
        {
            this.EventType = eventType;
            this.EventDate = eventDate;
            this.ChannelName = channelName;
            this.TemplateName = templateName;
            this.IPAddress = iPAddress;
            this.Country = country;
            this.Data = data;
        }

        /// <summary>
        /// Formatted date of event.
        /// </summary>
        /// <value>Formatted date of event.</value>
        [DataMember(Name = "EventDate", EmitDefaultValue = false)]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Name of channel this event occured on
        /// </summary>
        /// <value>Name of channel this event occured on</value>
        [DataMember(Name = "ChannelName", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Name of template this event occured on
        /// </summary>
        /// <value>Name of template this event occured on</value>
        [DataMember(Name = "TemplateName", EmitDefaultValue = false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// IP Address of the event.
        /// </summary>
        /// <value>IP Address of the event.</value>
        [DataMember(Name = "IPAddress", EmitDefaultValue = false)]
        public string IPAddress { get; set; }

        /// <summary>
        /// Country of the event.
        /// </summary>
        /// <value>Country of the event.</value>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Additional information about the event
        /// </summary>
        /// <value>Additional information about the event</value>
        [DataMember(Name = "Data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactHistory {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  IPAddress: ").Append(IPAddress).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as ContactHistory);
        }

        /// <summary>
        /// Returns true if ContactHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactHistory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.IPAddress == input.IPAddress ||
                    (this.IPAddress != null &&
                    this.IPAddress.Equals(input.IPAddress))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                if (this.EventDate != null)
                {
                    hashCode = (hashCode * 59) + this.EventDate.GetHashCode();
                }
                if (this.ChannelName != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelName.GetHashCode();
                }
                if (this.TemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateName.GetHashCode();
                }
                if (this.IPAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IPAddress.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
