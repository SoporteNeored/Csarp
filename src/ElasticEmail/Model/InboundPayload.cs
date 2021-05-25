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
    /// InboundPayload
    /// </summary>
    [DataContract(Name = "InboundPayload")]
    public partial class InboundPayload : IEquatable<InboundPayload>, IValidatableObject
    {
        /// <summary>
        /// Type of the filter
        /// </summary>
        /// <value>Type of the filter</value>
        [DataMember(Name = "FilterType", EmitDefaultValue = false)]
        public InboundRouteFilterType? FilterType { get; set; }
        /// <summary>
        /// Type of action to take
        /// </summary>
        /// <value>Type of action to take</value>
        [DataMember(Name = "ActionType", EmitDefaultValue = false)]
        public InboundRouteActionType? ActionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPayload" /> class.
        /// </summary>
        /// <param name="filter">Filter of the inbound data.</param>
        /// <param name="name">Name of this route.</param>
        /// <param name="filterType">Type of the filter.</param>
        /// <param name="actionType">Type of action to take.</param>
        /// <param name="emailAddress">Email to forward the inbound to.</param>
        /// <param name="httpAddress">Address to notify about the inbound.</param>
        public InboundPayload(string filter = default(string), string name = default(string), InboundRouteFilterType? filterType = default(InboundRouteFilterType?), InboundRouteActionType? actionType = default(InboundRouteActionType?), string emailAddress = default(string), string httpAddress = default(string))
        {
            this.Filter = filter;
            this.Name = name;
            this.FilterType = filterType;
            this.ActionType = actionType;
            this.EmailAddress = emailAddress;
            this.HttpAddress = httpAddress;
        }

        /// <summary>
        /// Filter of the inbound data
        /// </summary>
        /// <value>Filter of the inbound data</value>
        [DataMember(Name = "Filter", EmitDefaultValue = false)]
        public string Filter { get; set; }

        /// <summary>
        /// Name of this route
        /// </summary>
        /// <value>Name of this route</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Email to forward the inbound to
        /// </summary>
        /// <value>Email to forward the inbound to</value>
        [DataMember(Name = "EmailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Address to notify about the inbound
        /// </summary>
        /// <value>Address to notify about the inbound</value>
        [DataMember(Name = "HttpAddress", EmitDefaultValue = false)]
        public string HttpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundPayload {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  HttpAddress: ").Append(HttpAddress).Append("\n");
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
            return this.Equals(input as InboundPayload);
        }

        /// <summary>
        /// Returns true if InboundPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FilterType == input.FilterType ||
                    this.FilterType.Equals(input.FilterType)
                ) && 
                (
                    this.ActionType == input.ActionType ||
                    this.ActionType.Equals(input.ActionType)
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.HttpAddress == input.HttpAddress ||
                    (this.HttpAddress != null &&
                    this.HttpAddress.Equals(input.HttpAddress))
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
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.FilterType.GetHashCode();
                hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.HttpAddress != null)
                    hashCode = hashCode * 59 + this.HttpAddress.GetHashCode();
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
