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
    /// Optional A/X split campaign options
    /// </summary>
    [DataContract(Name = "SplitOptions")]
    public partial class SplitOptions : IEquatable<SplitOptions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets OptimizeFor
        /// </summary>
        [DataMember(Name = "OptimizeFor", EmitDefaultValue = false)]
        public SplitOptimizationType? OptimizeFor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitOptions" /> class.
        /// </summary>
        /// <param name="optimizeFor">optimizeFor.</param>
        /// <param name="optimizePeriodMinutes">For how long should the results be measured until determining the winner template (content).</param>
        public SplitOptions(SplitOptimizationType? optimizeFor = default(SplitOptimizationType?), int optimizePeriodMinutes = default(int))
        {
            this.OptimizeFor = optimizeFor;
            this.OptimizePeriodMinutes = optimizePeriodMinutes;
        }

        /// <summary>
        /// For how long should the results be measured until determining the winner template (content)
        /// </summary>
        /// <value>For how long should the results be measured until determining the winner template (content)</value>
        [DataMember(Name = "OptimizePeriodMinutes", EmitDefaultValue = false)]
        public int OptimizePeriodMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SplitOptions {\n");
            sb.Append("  OptimizeFor: ").Append(OptimizeFor).Append("\n");
            sb.Append("  OptimizePeriodMinutes: ").Append(OptimizePeriodMinutes).Append("\n");
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
            return this.Equals(input as SplitOptions);
        }

        /// <summary>
        /// Returns true if SplitOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OptimizeFor == input.OptimizeFor ||
                    this.OptimizeFor.Equals(input.OptimizeFor)
                ) && 
                (
                    this.OptimizePeriodMinutes == input.OptimizePeriodMinutes ||
                    this.OptimizePeriodMinutes.Equals(input.OptimizePeriodMinutes)
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
                hashCode = (hashCode * 59) + this.OptimizeFor.GetHashCode();
                hashCode = (hashCode * 59) + this.OptimizePeriodMinutes.GetHashCode();
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
