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
    /// ListPayload
    /// </summary>
    [DataContract(Name = "ListPayload")]
    public partial class ListPayload : IEquatable<ListPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPayload" /> class.
        /// </summary>
        /// <param name="listName">Name of your list..</param>
        /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false.</param>
        /// <param name="emails">Comma delimited list of existing contact emails that should be added to this list.</param>
        public ListPayload(string listName = default(string), bool allowUnsubscribe = default(bool), List<string> emails = default(List<string>))
        {
            this.ListName = listName;
            this.AllowUnsubscribe = allowUnsubscribe;
            this.Emails = emails;
        }

        /// <summary>
        /// Name of your list.
        /// </summary>
        /// <value>Name of your list.</value>
        [DataMember(Name = "ListName", EmitDefaultValue = false)]
        public string ListName { get; set; }

        /// <summary>
        /// True: Allow unsubscribing from this list. Otherwise, false
        /// </summary>
        /// <value>True: Allow unsubscribing from this list. Otherwise, false</value>
        [DataMember(Name = "AllowUnsubscribe", EmitDefaultValue = false)]
        public bool AllowUnsubscribe { get; set; }

        /// <summary>
        /// Comma delimited list of existing contact emails that should be added to this list
        /// </summary>
        /// <value>Comma delimited list of existing contact emails that should be added to this list</value>
        [DataMember(Name = "Emails", EmitDefaultValue = false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPayload {\n");
            sb.Append("  ListName: ").Append(ListName).Append("\n");
            sb.Append("  AllowUnsubscribe: ").Append(AllowUnsubscribe).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
            return this.Equals(input as ListPayload);
        }

        /// <summary>
        /// Returns true if ListPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ListPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListName == input.ListName ||
                    (this.ListName != null &&
                    this.ListName.Equals(input.ListName))
                ) && 
                (
                    this.AllowUnsubscribe == input.AllowUnsubscribe ||
                    this.AllowUnsubscribe.Equals(input.AllowUnsubscribe)
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
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
                if (this.ListName != null)
                    hashCode = hashCode * 59 + this.ListName.GetHashCode();
                hashCode = hashCode * 59 + this.AllowUnsubscribe.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
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
