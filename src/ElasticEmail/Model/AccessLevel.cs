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
    /// Defines AccessLevel
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessLevel
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum ViewAccount for value: ViewAccount
        /// </summary>
        [EnumMember(Value = "ViewAccount")]
        ViewAccount = 2,

        /// <summary>
        /// Enum ViewContacts for value: ViewContacts
        /// </summary>
        [EnumMember(Value = "ViewContacts")]
        ViewContacts = 3,

        /// <summary>
        /// Enum ViewForms for value: ViewForms
        /// </summary>
        [EnumMember(Value = "ViewForms")]
        ViewForms = 4,

        /// <summary>
        /// Enum ViewTemplates for value: ViewTemplates
        /// </summary>
        [EnumMember(Value = "ViewTemplates")]
        ViewTemplates = 5,

        /// <summary>
        /// Enum ViewCampaigns for value: ViewCampaigns
        /// </summary>
        [EnumMember(Value = "ViewCampaigns")]
        ViewCampaigns = 6,

        /// <summary>
        /// Enum ViewChannels for value: ViewChannels
        /// </summary>
        [EnumMember(Value = "ViewChannels")]
        ViewChannels = 7,

        /// <summary>
        /// Enum ViewAutomations for value: ViewAutomations
        /// </summary>
        [EnumMember(Value = "ViewAutomations")]
        ViewAutomations = 8,

        /// <summary>
        /// Enum ViewSurveys for value: ViewSurveys
        /// </summary>
        [EnumMember(Value = "ViewSurveys")]
        ViewSurveys = 9,

        /// <summary>
        /// Enum ViewSettings for value: ViewSettings
        /// </summary>
        [EnumMember(Value = "ViewSettings")]
        ViewSettings = 10,

        /// <summary>
        /// Enum ViewBilling for value: ViewBilling
        /// </summary>
        [EnumMember(Value = "ViewBilling")]
        ViewBilling = 11,

        /// <summary>
        /// Enum ViewSubAccounts for value: ViewSubAccounts
        /// </summary>
        [EnumMember(Value = "ViewSubAccounts")]
        ViewSubAccounts = 12,

        /// <summary>
        /// Enum ViewUsers for value: ViewUsers
        /// </summary>
        [EnumMember(Value = "ViewUsers")]
        ViewUsers = 13,

        /// <summary>
        /// Enum ViewFiles for value: ViewFiles
        /// </summary>
        [EnumMember(Value = "ViewFiles")]
        ViewFiles = 14,

        /// <summary>
        /// Enum ViewReports for value: ViewReports
        /// </summary>
        [EnumMember(Value = "ViewReports")]
        ViewReports = 15,

        /// <summary>
        /// Enum ModifyAccount for value: ModifyAccount
        /// </summary>
        [EnumMember(Value = "ModifyAccount")]
        ModifyAccount = 16,

        /// <summary>
        /// Enum ModifyContacts for value: ModifyContacts
        /// </summary>
        [EnumMember(Value = "ModifyContacts")]
        ModifyContacts = 17,

        /// <summary>
        /// Enum ModifyForms for value: ModifyForms
        /// </summary>
        [EnumMember(Value = "ModifyForms")]
        ModifyForms = 18,

        /// <summary>
        /// Enum ModifyTemplates for value: ModifyTemplates
        /// </summary>
        [EnumMember(Value = "ModifyTemplates")]
        ModifyTemplates = 19,

        /// <summary>
        /// Enum ModifyCampaigns for value: ModifyCampaigns
        /// </summary>
        [EnumMember(Value = "ModifyCampaigns")]
        ModifyCampaigns = 20,

        /// <summary>
        /// Enum ModifyChannels for value: ModifyChannels
        /// </summary>
        [EnumMember(Value = "ModifyChannels")]
        ModifyChannels = 21,

        /// <summary>
        /// Enum ModifyAutomations for value: ModifyAutomations
        /// </summary>
        [EnumMember(Value = "ModifyAutomations")]
        ModifyAutomations = 22,

        /// <summary>
        /// Enum ModifySurveys for value: ModifySurveys
        /// </summary>
        [EnumMember(Value = "ModifySurveys")]
        ModifySurveys = 23,

        /// <summary>
        /// Enum ModifyFiles for value: ModifyFiles
        /// </summary>
        [EnumMember(Value = "ModifyFiles")]
        ModifyFiles = 24,

        /// <summary>
        /// Enum Export for value: Export
        /// </summary>
        [EnumMember(Value = "Export")]
        Export = 25,

        /// <summary>
        /// Enum SendSmtp for value: SendSmtp
        /// </summary>
        [EnumMember(Value = "SendSmtp")]
        SendSmtp = 26,

        /// <summary>
        /// Enum SendSMS for value: SendSMS
        /// </summary>
        [EnumMember(Value = "SendSMS")]
        SendSMS = 27,

        /// <summary>
        /// Enum ModifySettings for value: ModifySettings
        /// </summary>
        [EnumMember(Value = "ModifySettings")]
        ModifySettings = 28,

        /// <summary>
        /// Enum ModifyBilling for value: ModifyBilling
        /// </summary>
        [EnumMember(Value = "ModifyBilling")]
        ModifyBilling = 29,

        /// <summary>
        /// Enum ModifyProfile for value: ModifyProfile
        /// </summary>
        [EnumMember(Value = "ModifyProfile")]
        ModifyProfile = 30,

        /// <summary>
        /// Enum ModifySubAccounts for value: ModifySubAccounts
        /// </summary>
        [EnumMember(Value = "ModifySubAccounts")]
        ModifySubAccounts = 31,

        /// <summary>
        /// Enum ModifyUsers for value: ModifyUsers
        /// </summary>
        [EnumMember(Value = "ModifyUsers")]
        ModifyUsers = 32,

        /// <summary>
        /// Enum Security for value: Security
        /// </summary>
        [EnumMember(Value = "Security")]
        Security = 33,

        /// <summary>
        /// Enum ModifyLanguage for value: ModifyLanguage
        /// </summary>
        [EnumMember(Value = "ModifyLanguage")]
        ModifyLanguage = 34,

        /// <summary>
        /// Enum ViewSupport for value: ViewSupport
        /// </summary>
        [EnumMember(Value = "ViewSupport")]
        ViewSupport = 35,

        /// <summary>
        /// Enum SendHttp for value: SendHttp
        /// </summary>
        [EnumMember(Value = "SendHttp")]
        SendHttp = 36,

        /// <summary>
        /// Enum Modify2FAEmail for value: Modify2FAEmail
        /// </summary>
        [EnumMember(Value = "Modify2FAEmail")]
        Modify2FAEmail = 37,

        /// <summary>
        /// Enum ModifySupport for value: ModifySupport
        /// </summary>
        [EnumMember(Value = "ModifySupport")]
        ModifySupport = 38,

        /// <summary>
        /// Enum ViewCustomFields for value: ViewCustomFields
        /// </summary>
        [EnumMember(Value = "ViewCustomFields")]
        ViewCustomFields = 39,

        /// <summary>
        /// Enum ModifyCustomFields for value: ModifyCustomFields
        /// </summary>
        [EnumMember(Value = "ModifyCustomFields")]
        ModifyCustomFields = 40,

        /// <summary>
        /// Enum ModifyWebNotifications for value: ModifyWebNotifications
        /// </summary>
        [EnumMember(Value = "ModifyWebNotifications")]
        ModifyWebNotifications = 41,

        /// <summary>
        /// Enum ExtendedLogs for value: ExtendedLogs
        /// </summary>
        [EnumMember(Value = "ExtendedLogs")]
        ExtendedLogs = 42,

        /// <summary>
        /// Enum VerifyEmails for value: VerifyEmails
        /// </summary>
        [EnumMember(Value = "VerifyEmails")]
        VerifyEmails = 43,

        /// <summary>
        /// Enum Modify2FASms for value: Modify2FASms
        /// </summary>
        [EnumMember(Value = "Modify2FASms")]
        Modify2FASms = 44,

        /// <summary>
        /// Enum DisableContactsStore for value: DisableContactsStore
        /// </summary>
        [EnumMember(Value = "DisableContactsStore")]
        DisableContactsStore = 45,

        /// <summary>
        /// Enum ModifyLandingPages for value: ModifyLandingPages
        /// </summary>
        [EnumMember(Value = "ModifyLandingPages")]
        ModifyLandingPages = 46,

        /// <summary>
        /// Enum ViewLandingPages for value: ViewLandingPages
        /// </summary>
        [EnumMember(Value = "ViewLandingPages")]
        ViewLandingPages = 47,

        /// <summary>
        /// Enum ModifySuppressions for value: ModifySuppressions
        /// </summary>
        [EnumMember(Value = "ModifySuppressions")]
        ModifySuppressions = 48,

        /// <summary>
        /// Enum ViewSuppressions for value: ViewSuppressions
        /// </summary>
        [EnumMember(Value = "ViewSuppressions")]
        ViewSuppressions = 49,

        /// <summary>
        /// Enum ViewDragDropEditor for value: ViewDragDropEditor
        /// </summary>
        [EnumMember(Value = "ViewDragDropEditor")]
        ViewDragDropEditor = 50,

        /// <summary>
        /// Enum ViewTemplateEditor for value: ViewTemplateEditor
        /// </summary>
        [EnumMember(Value = "ViewTemplateEditor")]
        ViewTemplateEditor = 51

    }

}
