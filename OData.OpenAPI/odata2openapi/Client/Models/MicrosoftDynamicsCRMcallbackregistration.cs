// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRM.Interface.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.callbackregistration
    /// </summary>
    public partial class MicrosoftDynamicsCRMcallbackregistration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcallbackregistration class.
        /// </summary>
        public MicrosoftDynamicsCRMcallbackregistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcallbackregistration class.
        /// </summary>
        public MicrosoftDynamicsCRMcallbackregistration(string _modifiedonbehalfbyValue = default(string), int? runas = default(int?), string _owninguserValue = default(string), int? version = default(int?), string sdkmessagename = default(string), string url = default(string), string name = default(string), string postponeuntil = default(string), string _createdonbehalfbyValue = default(string), int? scope = default(int?), string _owningbusinessunitValue = default(string), int? message = default(int?), string filteringattributes = default(string), string _owningteamValue = default(string), string entityname = default(string), string runtimeintegrationproperties = default(string), string _modifiedbyValue = default(string), string callbackregistrationid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? softdeletestatus = default(int?), string _owneridValue = default(string), string filterexpression = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser callbackregistrationModifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser callbackregistrationModifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser callbackregistrationCreatedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser callbackregistrationCreatedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Runas = runas;
            this._owninguserValue = _owninguserValue;
            Version = version;
            Sdkmessagename = sdkmessagename;
            Url = url;
            Name = name;
            Postponeuntil = postponeuntil;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Scope = scope;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Message = message;
            Filteringattributes = filteringattributes;
            this._owningteamValue = _owningteamValue;
            Entityname = entityname;
            Runtimeintegrationproperties = runtimeintegrationproperties;
            this._modifiedbyValue = _modifiedbyValue;
            Callbackregistrationid = callbackregistrationid;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Softdeletestatus = softdeletestatus;
            this._owneridValue = _owneridValue;
            Filterexpression = filterexpression;
            Createdon = createdon;
            CallbackregistrationModifiedonbehalfby = callbackregistrationModifiedonbehalfby;
            CallbackregistrationModifiedby = callbackregistrationModifiedby;
            CallbackregistrationCreatedonbehalfby = callbackregistrationCreatedonbehalfby;
            CallbackregistrationCreatedby = callbackregistrationCreatedby;
            Owningbusinessunit = owningbusinessunit;
            Ownerid = ownerid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runas")]
        public int? Runas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagename")]
        public string Sdkmessagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponeuntil")]
        public string Postponeuntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public int? Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public int? Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filteringattributes")]
        public string Filteringattributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityname")]
        public string Entityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runtimeintegrationproperties")]
        public string Runtimeintegrationproperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callbackregistrationid")]
        public string Callbackregistrationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "softdeletestatus")]
        public int? Softdeletestatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filterexpression")]
        public string Filterexpression { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callbackregistration_modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser CallbackregistrationModifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callbackregistration_modifiedby")]
        public MicrosoftDynamicsCRMsystemuser CallbackregistrationModifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callbackregistration_createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser CallbackregistrationCreatedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callbackregistration_createdby")]
        public MicrosoftDynamicsCRMsystemuser CallbackregistrationCreatedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

    }
}