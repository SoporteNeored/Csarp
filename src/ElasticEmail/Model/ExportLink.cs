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
    /// ExportLink
    /// </summary>
    [DataContract(Name = "ExportLink")]
    public partial class ExportLink : IEquatable<ExportLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportLink" /> class.
        /// </summary>
        /// <param name="link">Direct URL to the exported file.</param>
        /// <param name="publicExportID">ID of the exported file.</param>
        public ExportLink(string link = default(string), string publicExportID = default(string))
        {
            this.Link = link;
            this.PublicExportID = publicExportID;
        }

        /// <summary>
        /// Direct URL to the exported file
        /// </summary>
        /// <value>Direct URL to the exported file</value>
        [DataMember(Name = "Link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// ID of the exported file
        /// </summary>
        /// <value>ID of the exported file</value>
        [DataMember(Name = "PublicExportID", EmitDefaultValue = false)]
        public string PublicExportID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportLink {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  PublicExportID: ").Append(PublicExportID).Append("\n");
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
            return this.Equals(input as ExportLink);
        }

        /// <summary>
        /// Returns true if ExportLink instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.PublicExportID == input.PublicExportID ||
                    (this.PublicExportID != null &&
                    this.PublicExportID.Equals(input.PublicExportID))
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
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                if (this.PublicExportID != null)
                {
                    hashCode = (hashCode * 59) + this.PublicExportID.GetHashCode();
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
