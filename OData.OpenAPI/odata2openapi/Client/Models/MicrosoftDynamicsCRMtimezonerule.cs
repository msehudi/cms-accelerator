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
    /// Microsoft.Dynamics.CRM.timezonerule
    /// </summary>
    public partial class MicrosoftDynamicsCRMtimezonerule
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtimezonerule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtimezonerule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtimezonerule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtimezonerule(int? daylighthour = default(int?), int? daylightminute = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string timezoneruleid = default(string), int? bias = default(int?), string _timezonedefinitionidValue = default(string), string versionnumber = default(string), int? standardday = default(int?), int? daylightdayofweek = default(int?), string _createdonbehalfbyValue = default(string), int? daylightyear = default(int?), int? standardbias = default(int?), int? timezoneruleversionnumber = default(int?), int? standardsecond = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? standarddayofweek = default(int?), int? daylightbias = default(int?), int? daylightmonth = default(int?), string _organizationidValue = default(string), System.DateTimeOffset? effectivedatetime = default(System.DateTimeOffset?), int? daylightsecond = default(int?), int? standardmonth = default(int?), int? standardyear = default(int?), int? standardhour = default(int?), int? daylightday = default(int?), int? standardminute = default(int?), string _modifiedbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtimezonedefinition timezonedefinitionid = default(MicrosoftDynamicsCRMtimezonedefinition), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Daylighthour = daylighthour;
            Daylightminute = daylightminute;
            Createdon = createdon;
            Timezoneruleid = timezoneruleid;
            Bias = bias;
            this._timezonedefinitionidValue = _timezonedefinitionidValue;
            Versionnumber = versionnumber;
            Standardday = standardday;
            Daylightdayofweek = daylightdayofweek;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Daylightyear = daylightyear;
            Standardbias = standardbias;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Standardsecond = standardsecond;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Standarddayofweek = standarddayofweek;
            Daylightbias = daylightbias;
            Daylightmonth = daylightmonth;
            this._organizationidValue = _organizationidValue;
            Effectivedatetime = effectivedatetime;
            Daylightsecond = daylightsecond;
            Standardmonth = standardmonth;
            Standardyear = standardyear;
            Standardhour = standardhour;
            Daylightday = daylightday;
            Standardminute = standardminute;
            this._modifiedbyValue = _modifiedbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Timezonedefinitionid = timezonedefinitionid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylighthour")]
        public int? Daylighthour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightminute")]
        public int? Daylightminute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleid")]
        public string Timezoneruleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bias")]
        public int? Bias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_timezonedefinitionid_value")]
        public string _timezonedefinitionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardday")]
        public int? Standardday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightdayofweek")]
        public int? Daylightdayofweek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightyear")]
        public int? Daylightyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardbias")]
        public int? Standardbias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardsecond")]
        public int? Standardsecond { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "standarddayofweek")]
        public int? Standarddayofweek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightbias")]
        public int? Daylightbias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightmonth")]
        public int? Daylightmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivedatetime")]
        public System.DateTimeOffset? Effectivedatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightsecond")]
        public int? Daylightsecond { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardmonth")]
        public int? Standardmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardyear")]
        public int? Standardyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardhour")]
        public int? Standardhour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightday")]
        public int? Daylightday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardminute")]
        public int? Standardminute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonedefinitionid")]
        public MicrosoftDynamicsCRMtimezonedefinition Timezonedefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}