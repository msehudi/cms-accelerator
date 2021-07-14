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
    /// Microsoft.Dynamics.CRM.appointment
    /// </summary>
    public partial class MicrosoftDynamicsCRMappointment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappointment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMappointment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappointment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMappointment(string subscriptionid = default(string), string category = default(string), int? outlookownerapptid = default(int?), bool? isdraft = default(bool?), string location = default(string), bool? isalldayevent = default(bool?), System.DateTimeOffset? originalstartdate = default(System.DateTimeOffset?), string modifiedfieldsmask = default(string), string globalobjectid = default(string), int? isunsafe = default(int?), int? attachmenterrors = default(int?), string subcategory = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMpostregarding> appointmentPostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMpostfollow> appointmentPostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordAppointment = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMqueueitem> appointmentQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> appointmentAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMsyncerror> appointmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMrecurringappointmentmaster seriesidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMbusinessunit owningbusinessunitAppointment = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> appointmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMactivityparty> appointmentActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMasyncoperation> appointmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyAppointment = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> appointmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMconnection> appointmentConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceAppointment = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMsystemuser modifiedbyAppointment = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitymimeattachment> appointmentActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMbulkdeletefailure> appointmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> appointmentPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> appointmentConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMactioncard> appointmentActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMsla slaAppointmentSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMprocesssession> appointmentProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMcontact regardingobjectidContactAppointment = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser createdonbehalfbyAppointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleAppointment = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMaccount regardingobjectidAccountAppointment = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidAppointment = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsla slainvokedidAppointmentSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsystemuser createdbyAppointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamAppointment = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguserAppointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal owneridAppointment = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMrraApplication regardingobjectidRraApplicationAppointment = default(MicrosoftDynamicsCRMrraApplication))
        {
            Subscriptionid = subscriptionid;
            Category = category;
            Outlookownerapptid = outlookownerapptid;
            Isdraft = isdraft;
            Location = location;
            Isalldayevent = isalldayevent;
            Originalstartdate = originalstartdate;
            Modifiedfieldsmask = modifiedfieldsmask;
            Globalobjectid = globalobjectid;
            Isunsafe = isunsafe;
            Attachmenterrors = attachmenterrors;
            Subcategory = subcategory;
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            AppointmentPostRegardings = appointmentPostRegardings;
            AppointmentPostFollows = appointmentPostFollows;
            RegardingobjectidKnowledgebaserecordAppointment = regardingobjectidKnowledgebaserecordAppointment;
            AppointmentQueueItem = appointmentQueueItem;
            AppointmentAnnotation = appointmentAnnotation;
            AppointmentSyncErrors = appointmentSyncErrors;
            StageidProcessstage = stageidProcessstage;
            SeriesidRecurringappointmentmaster = seriesidRecurringappointmentmaster;
            OwningbusinessunitAppointment = owningbusinessunitAppointment;
            AppointmentDuplicateBaseRecord = appointmentDuplicateBaseRecord;
            AppointmentActivityParties = appointmentActivityParties;
            AppointmentAsyncOperations = appointmentAsyncOperations;
            ModifiedonbehalfbyAppointment = modifiedonbehalfbyAppointment;
            AppointmentDuplicateMatchingRecord = appointmentDuplicateMatchingRecord;
            AppointmentConnections1 = appointmentConnections1;
            SlakpiinstanceAppointment = slakpiinstanceAppointment;
            ModifiedbyAppointment = modifiedbyAppointment;
            AppointmentActivityMimeAttachment = appointmentActivityMimeAttachment;
            AppointmentBulkDeleteFailures = appointmentBulkDeleteFailures;
            AppointmentPrincipalobjectattributeaccess = appointmentPrincipalobjectattributeaccess;
            AppointmentConnections2 = appointmentConnections2;
            AppointmentActioncard = appointmentActioncard;
            SlaAppointmentSla = slaAppointmentSla;
            AppointmentProcessSessions = appointmentProcessSessions;
            RegardingobjectidContactAppointment = regardingobjectidContactAppointment;
            CreatedonbehalfbyAppointment = createdonbehalfbyAppointment;
            RegardingobjectidKnowledgearticleAppointment = regardingobjectidKnowledgearticleAppointment;
            RegardingobjectidAccountAppointment = regardingobjectidAccountAppointment;
            ActivityidActivitypointer = activityidActivitypointer;
            TransactioncurrencyidAppointment = transactioncurrencyidAppointment;
            SlainvokedidAppointmentSla = slainvokedidAppointmentSla;
            CreatedbyAppointment = createdbyAppointment;
            OwningteamAppointment = owningteamAppointment;
            OwninguserAppointment = owninguserAppointment;
            OwneridAppointment = owneridAppointment;
            RegardingobjectidRraApplicationAppointment = regardingobjectidRraApplicationAppointment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outlookownerapptid")]
        public int? Outlookownerapptid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdraft")]
        public bool? Isdraft { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isalldayevent")]
        public bool? Isalldayevent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originalstartdate")]
        public System.DateTimeOffset? Originalstartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedfieldsmask")]
        public string Modifiedfieldsmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "globalobjectid")]
        public string Globalobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isunsafe")]
        public int? Isunsafe { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmenterrors")]
        public int? Attachmenterrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> AppointmentPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> AppointmentPostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_appointment")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> AppointmentQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> AppointmentAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AppointmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "seriesid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster SeriesidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_appointment")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AppointmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> AppointmentActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AppointmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_appointment")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AppointmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> AppointmentConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_appointment")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_appointment")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_activity_mime_attachment")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> AppointmentActivityMimeAttachment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AppointmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AppointmentPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> AppointmentConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> AppointmentActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_appointment_sla")]
        public MicrosoftDynamicsCRMsla SlaAppointmentSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> AppointmentProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_appointment")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_appointment")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_appointment")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_appointment")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_appointment")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_appointment_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidAppointmentSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_appointment")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_appointment")]
        public MicrosoftDynamicsCRMteam OwningteamAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_appointment")]
        public MicrosoftDynamicsCRMsystemuser OwninguserAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_appointment")]
        public MicrosoftDynamicsCRMprincipal OwneridAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_rra_application_appointment")]
        public MicrosoftDynamicsCRMrraApplication RegardingobjectidRraApplicationAppointment { get; set; }

    }
}
