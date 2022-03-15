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
    /// A change to SubAccount email credits pool, with an additional note.
    /// </summary>
    [DataContract(Name = "SubaccountEmailCreditsPayload")]
    public partial class SubaccountEmailCreditsPayload : IEquatable<SubaccountEmailCreditsPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubaccountEmailCreditsPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubaccountEmailCreditsPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubaccountEmailCreditsPayload" /> class.
        /// </summary>
        /// <param name="credits">Positive or negative value; this will be added or subtracted from Subaccount&#39;s current email Credits pool. (required).</param>
        /// <param name="notes">Note to append to this credits change, for history..</param>
        public SubaccountEmailCreditsPayload(int credits = default(int), string notes = default(string))
        {
            this.Credits = credits;
            this.Notes = notes;
        }

        /// <summary>
        /// Positive or negative value; this will be added or subtracted from Subaccount&#39;s current email Credits pool.
        /// </summary>
        /// <value>Positive or negative value; this will be added or subtracted from Subaccount&#39;s current email Credits pool.</value>
        [DataMember(Name = "Credits", IsRequired = true, EmitDefaultValue = false)]
        public int Credits { get; set; }

        /// <summary>
        /// Note to append to this credits change, for history.
        /// </summary>
        /// <value>Note to append to this credits change, for history.</value>
        [DataMember(Name = "Notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubaccountEmailCreditsPayload {\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as SubaccountEmailCreditsPayload);
        }

        /// <summary>
        /// Returns true if SubaccountEmailCreditsPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of SubaccountEmailCreditsPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubaccountEmailCreditsPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Credits == input.Credits ||
                    this.Credits.Equals(input.Credits)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                hashCode = (hashCode * 59) + this.Credits.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
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
