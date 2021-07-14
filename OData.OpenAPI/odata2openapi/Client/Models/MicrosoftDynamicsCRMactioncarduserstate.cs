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
    /// Microsoft.Dynamics.CRM.actioncarduserstate
    /// </summary>
    public partial class MicrosoftDynamicsCRMactioncarduserstate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactioncarduserstate class.
        /// </summary>
        public MicrosoftDynamicsCRMactioncarduserstate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactioncarduserstate class.
        /// </summary>
        public MicrosoftDynamicsCRMactioncarduserstate(string actioncarduserstateid = default(string), string versionnumber = default(string), string _transactioncurrencyidValue = default(string), decimal? exchangerate = default(decimal?), string _owningbusinessunitValue = default(string), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? startdate = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string _actioncardidValue = default(string), int? state = default(int?), MicrosoftDynamicsCRMactioncard actioncardid = default(MicrosoftDynamicsCRMactioncard), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal))
        {
            Actioncarduserstateid = actioncarduserstateid;
            Versionnumber = versionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Exchangerate = exchangerate;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Startdate = startdate;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._actioncardidValue = _actioncardidValue;
            State = state;
            Actioncardid = actioncardid;
            Transactioncurrencyid = transactioncurrencyid;
            Ownerid = ownerid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actioncarduserstateid")]
        public string Actioncarduserstateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        public System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_actioncardid_value")]
        public string _actioncardidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actioncardid")]
        public MicrosoftDynamicsCRMactioncard Actioncardid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

    }
}
