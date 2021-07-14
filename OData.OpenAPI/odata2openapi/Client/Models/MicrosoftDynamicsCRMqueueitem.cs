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
    /// Microsoft.Dynamics.CRM.queueitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMqueueitem
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueueitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMqueueitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueueitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMqueueitem(string _transactioncurrencyidValue = default(string), string _workeridValue = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string title = default(string), string _modifiedonbehalfbyValue = default(string), string versionnumber = default(string), string _queueidValue = default(string), int? statecode = default(int?), System.DateTimeOffset? enteredon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), string queueitemid = default(string), int? statuscode = default(int?), string _objectidValue = default(string), System.DateTimeOffset? workeridmodifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), decimal? exchangerate = default(decimal?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), int? objecttypecode = default(int?), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMknowledgearticle objectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMprocesssession> queueItemProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMappointment objectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser workeridSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer objectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMqueue queueid = default(MicrosoftDynamicsCRMqueue), IList<MicrosoftDynamicsCRMasyncoperation> queueItemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMteam workeridTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMfax objectidFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMrecurringappointmentmaster objectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), IList<MicrosoftDynamicsCRMsyncerror> queueItemSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMletter objectidLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMsocialactivity objectidSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMphonecall objectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMtask objectidTask = default(MicrosoftDynamicsCRMtask), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> queueitemPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMbulkdeletefailure> queueItemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMemail objectidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMmsdynKnowledgearticletemplate objectidMsdynKnowledgearticletemplate = default(MicrosoftDynamicsCRMmsdynKnowledgearticletemplate), MicrosoftDynamicsCRMrraApplication objectidRraApplication = default(MicrosoftDynamicsCRMrraApplication))
        {
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._workeridValue = _workeridValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Title = title;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            this._queueidValue = _queueidValue;
            Statecode = statecode;
            Enteredon = enteredon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            Queueitemid = queueitemid;
            Statuscode = statuscode;
            this._objectidValue = _objectidValue;
            Workeridmodifiedon = workeridmodifiedon;
            this._owninguserValue = _owninguserValue;
            Exchangerate = exchangerate;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Objecttypecode = objecttypecode;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            ObjectidKnowledgearticle = objectidKnowledgearticle;
            QueueItemProcessSessions = queueItemProcessSessions;
            Createdby = createdby;
            ObjectidAppointment = objectidAppointment;
            Modifiedby = modifiedby;
            WorkeridSystemuser = workeridSystemuser;
            ObjectidActivitypointer = objectidActivitypointer;
            Queueid = queueid;
            QueueItemAsyncOperations = queueItemAsyncOperations;
            WorkeridTeam = workeridTeam;
            ObjectidFax = objectidFax;
            ObjectidRecurringappointmentmaster = objectidRecurringappointmentmaster;
            QueueItemSyncErrors = queueItemSyncErrors;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            ObjectidLetter = objectidLetter;
            ObjectidSocialactivity = objectidSocialactivity;
            ObjectidPhonecall = objectidPhonecall;
            Transactioncurrencyid = transactioncurrencyid;
            ObjectidTask = objectidTask;
            QueueitemPrincipalobjectattributeaccess = queueitemPrincipalobjectattributeaccess;
            QueueItemBulkDeleteFailures = queueItemBulkDeleteFailures;
            ObjectidEmail = objectidEmail;
            Createdonbehalfby = createdonbehalfby;
            ObjectidMsdynKnowledgearticletemplate = objectidMsdynKnowledgearticletemplate;
            ObjectidRraApplication = objectidRraApplication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_workerid_value")]
        public string _workeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_queueid_value")]
        public string _queueidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enteredon")]
        public System.DateTimeOffset? Enteredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueitemid")]
        public string Queueitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workeridmodifiedon")]
        public System.DateTimeOffset? Workeridmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle ObjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> QueueItemProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_appointment")]
        public MicrosoftDynamicsCRMappointment ObjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workerid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser WorkeridSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ObjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueid")]
        public MicrosoftDynamicsCRMqueue Queueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QueueItemAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workerid_team")]
        public MicrosoftDynamicsCRMteam WorkeridTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_fax")]
        public MicrosoftDynamicsCRMfax ObjectidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster ObjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QueueItemSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_letter")]
        public MicrosoftDynamicsCRMletter ObjectidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity ObjectidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall ObjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_task")]
        public MicrosoftDynamicsCRMtask ObjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueitem_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> QueueitemPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QueueItemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_email")]
        public MicrosoftDynamicsCRMemail ObjectidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_msdyn_knowledgearticletemplate")]
        public MicrosoftDynamicsCRMmsdynKnowledgearticletemplate ObjectidMsdynKnowledgearticletemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_rra_application")]
        public MicrosoftDynamicsCRMrraApplication ObjectidRraApplication { get; set; }

    }
}
