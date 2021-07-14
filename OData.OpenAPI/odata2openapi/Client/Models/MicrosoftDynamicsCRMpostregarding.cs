// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRM.Interface.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.postregarding
    /// </summary>
    public partial class MicrosoftDynamicsCRMpostregarding
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostregarding
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostregarding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostregarding
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostregarding(string postregardingid = default(string), System.DateTimeOffset? latestmanualpostmodifiedon = default(System.DateTimeOffset?), string _regardingobjectowningbusinessunitValue = default(string), string regardingobjecttypecodeforsharing = default(string), string _regardingobjectidValue = default(string), string _regardingobjectowneridValue = default(string), System.DateTimeOffset? latestautopostmodifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMtask regardingobjectidTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMappointment regardingobjectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMphonecall regardingobjectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMrecurringappointmentmaster regardingobjectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), IList<MicrosoftDynamicsCRMpost> postPostRegardings = default(IList<MicrosoftDynamicsCRMpost>), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser regardingobjectidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit regardingobjectowningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMteam regardingobjectidTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMqueue regardingobjectidQueue = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMprocesssession regardingobjectidProcesssession = default(MicrosoftDynamicsCRMprocesssession))
        {
            Postregardingid = postregardingid;
            Latestmanualpostmodifiedon = latestmanualpostmodifiedon;
            this._regardingobjectowningbusinessunitValue = _regardingobjectowningbusinessunitValue;
            Regardingobjecttypecodeforsharing = regardingobjecttypecodeforsharing;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._regardingobjectowneridValue = _regardingobjectowneridValue;
            Latestautopostmodifiedon = latestautopostmodifiedon;
            RegardingobjectidTask = regardingobjectidTask;
            RegardingobjectidAppointment = regardingobjectidAppointment;
            RegardingobjectidPhonecall = regardingobjectidPhonecall;
            RegardingobjectidRecurringappointmentmaster = regardingobjectidRecurringappointmentmaster;
            PostPostRegardings = postPostRegardings;
            RegardingobjectidAccount = regardingobjectidAccount;
            RegardingobjectidSystemuser = regardingobjectidSystemuser;
            Regardingobjectowningbusinessunit = regardingobjectowningbusinessunit;
            RegardingobjectidContact = regardingobjectidContact;
            RegardingobjectidTeam = regardingobjectidTeam;
            RegardingobjectidKnowledgearticle = regardingobjectidKnowledgearticle;
            RegardingobjectidQueue = regardingobjectidQueue;
            RegardingobjectidProcesssession = regardingobjectidProcesssession;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postregardingid")]
        public string Postregardingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestmanualpostmodifiedon")]
        public System.DateTimeOffset? Latestmanualpostmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectowningbusinessunit_value")]
        public string _regardingobjectowningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjecttypecodeforsharing")]
        public string Regardingobjecttypecodeforsharing { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectownerid_value")]
        public string _regardingobjectowneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestautopostmodifiedon")]
        public System.DateTimeOffset? Latestautopostmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_task")]
        public MicrosoftDynamicsCRMtask RegardingobjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_appointment")]
        public MicrosoftDynamicsCRMappointment RegardingobjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall RegardingobjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster RegardingobjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "post_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpost> PostPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser RegardingobjectidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectowningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Regardingobjectowningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_team")]
        public MicrosoftDynamicsCRMteam RegardingobjectidTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_queue")]
        public MicrosoftDynamicsCRMqueue RegardingobjectidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_processsession")]
        public MicrosoftDynamicsCRMprocesssession RegardingobjectidProcesssession { get; set; }

    }
}
