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
    /// Defines MessageCategory
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MessageCategory
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Ignore for value: Ignore
        /// </summary>
        [EnumMember(Value = "Ignore")]
        Ignore = 2,

        /// <summary>
        /// Enum Spam for value: Spam
        /// </summary>
        [EnumMember(Value = "Spam")]
        Spam = 3,

        /// <summary>
        /// Enum BlackListed for value: BlackListed
        /// </summary>
        [EnumMember(Value = "BlackListed")]
        BlackListed = 4,

        /// <summary>
        /// Enum NoMailbox for value: NoMailbox
        /// </summary>
        [EnumMember(Value = "NoMailbox")]
        NoMailbox = 5,

        /// <summary>
        /// Enum GreyListed for value: GreyListed
        /// </summary>
        [EnumMember(Value = "GreyListed")]
        GreyListed = 6,

        /// <summary>
        /// Enum Throttled for value: Throttled
        /// </summary>
        [EnumMember(Value = "Throttled")]
        Throttled = 7,

        /// <summary>
        /// Enum Timeout for value: Timeout
        /// </summary>
        [EnumMember(Value = "Timeout")]
        Timeout = 8,

        /// <summary>
        /// Enum ConnectionProblem for value: ConnectionProblem
        /// </summary>
        [EnumMember(Value = "ConnectionProblem")]
        ConnectionProblem = 9,

        /// <summary>
        /// Enum SPFProblem for value: SPFProblem
        /// </summary>
        [EnumMember(Value = "SPFProblem")]
        SPFProblem = 10,

        /// <summary>
        /// Enum AccountProblem for value: AccountProblem
        /// </summary>
        [EnumMember(Value = "AccountProblem")]
        AccountProblem = 11,

        /// <summary>
        /// Enum DNSProblem for value: DNSProblem
        /// </summary>
        [EnumMember(Value = "DNSProblem")]
        DNSProblem = 12,

        /// <summary>
        /// Enum NotDeliveredCancelled for value: NotDeliveredCancelled
        /// </summary>
        [EnumMember(Value = "NotDeliveredCancelled")]
        NotDeliveredCancelled = 13,

        /// <summary>
        /// Enum CodeError for value: CodeError
        /// </summary>
        [EnumMember(Value = "CodeError")]
        CodeError = 14,

        /// <summary>
        /// Enum ManualCancel for value: ManualCancel
        /// </summary>
        [EnumMember(Value = "ManualCancel")]
        ManualCancel = 15,

        /// <summary>
        /// Enum ConnectionTerminated for value: ConnectionTerminated
        /// </summary>
        [EnumMember(Value = "ConnectionTerminated")]
        ConnectionTerminated = 16,

        /// <summary>
        /// Enum NotDelivered for value: NotDelivered
        /// </summary>
        [EnumMember(Value = "NotDelivered")]
        NotDelivered = 17

    }

}
