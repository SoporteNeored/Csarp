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
    /// Different send options for a Campaign
    /// </summary>
    [DataContract(Name = "CampaignOptions")]
    public partial class CampaignOptions : IEquatable<CampaignOptions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DeliveryOptimization
        /// </summary>
        [DataMember(Name = "DeliveryOptimization", EmitDefaultValue = false)]
        public DeliveryOptimizationType? DeliveryOptimization { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignOptions" /> class.
        /// </summary>
        /// <param name="deliveryOptimization">deliveryOptimization.</param>
        /// <param name="trackOpens">Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used..</param>
        /// <param name="trackClicks">Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used..</param>
        /// <param name="scheduleFor">Date when this Campaign is scheduled to be sent on.</param>
        /// <param name="splitOptions">splitOptions.</param>
        public CampaignOptions(DeliveryOptimizationType? deliveryOptimization = default(DeliveryOptimizationType?), bool? trackOpens = default(bool?), bool? trackClicks = default(bool?), DateTime? scheduleFor = default(DateTime?), SplitOptions splitOptions = default(SplitOptions))
        {
            this.DeliveryOptimization = deliveryOptimization;
            this.TrackOpens = trackOpens;
            this.TrackClicks = trackClicks;
            this.ScheduleFor = scheduleFor;
            this.SplitOptions = splitOptions;
        }

        /// <summary>
        /// Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used.
        /// </summary>
        /// <value>Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used.</value>
        [DataMember(Name = "TrackOpens", EmitDefaultValue = true)]
        public bool? TrackOpens { get; set; }

        /// <summary>
        /// Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used.
        /// </summary>
        /// <value>Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used.</value>
        [DataMember(Name = "TrackClicks", EmitDefaultValue = true)]
        public bool? TrackClicks { get; set; }

        /// <summary>
        /// Date when this Campaign is scheduled to be sent on
        /// </summary>
        /// <value>Date when this Campaign is scheduled to be sent on</value>
        [DataMember(Name = "ScheduleFor", EmitDefaultValue = true)]
        public DateTime? ScheduleFor { get; set; }

        /// <summary>
        /// Gets or Sets SplitOptions
        /// </summary>
        [DataMember(Name = "SplitOptions", EmitDefaultValue = false)]
        public SplitOptions SplitOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CampaignOptions {\n");
            sb.Append("  DeliveryOptimization: ").Append(DeliveryOptimization).Append("\n");
            sb.Append("  TrackOpens: ").Append(TrackOpens).Append("\n");
            sb.Append("  TrackClicks: ").Append(TrackClicks).Append("\n");
            sb.Append("  ScheduleFor: ").Append(ScheduleFor).Append("\n");
            sb.Append("  SplitOptions: ").Append(SplitOptions).Append("\n");
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
            return this.Equals(input as CampaignOptions);
        }

        /// <summary>
        /// Returns true if CampaignOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryOptimization == input.DeliveryOptimization ||
                    this.DeliveryOptimization.Equals(input.DeliveryOptimization)
                ) && 
                (
                    this.TrackOpens == input.TrackOpens ||
                    (this.TrackOpens != null &&
                    this.TrackOpens.Equals(input.TrackOpens))
                ) && 
                (
                    this.TrackClicks == input.TrackClicks ||
                    (this.TrackClicks != null &&
                    this.TrackClicks.Equals(input.TrackClicks))
                ) && 
                (
                    this.ScheduleFor == input.ScheduleFor ||
                    (this.ScheduleFor != null &&
                    this.ScheduleFor.Equals(input.ScheduleFor))
                ) && 
                (
                    this.SplitOptions == input.SplitOptions ||
                    (this.SplitOptions != null &&
                    this.SplitOptions.Equals(input.SplitOptions))
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
                hashCode = (hashCode * 59) + this.DeliveryOptimization.GetHashCode();
                if (this.TrackOpens != null)
                {
                    hashCode = (hashCode * 59) + this.TrackOpens.GetHashCode();
                }
                if (this.TrackClicks != null)
                {
                    hashCode = (hashCode * 59) + this.TrackClicks.GetHashCode();
                }
                if (this.ScheduleFor != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduleFor.GetHashCode();
                }
                if (this.SplitOptions != null)
                {
                    hashCode = (hashCode * 59) + this.SplitOptions.GetHashCode();
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
