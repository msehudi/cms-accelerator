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
    /// Microsoft.Dynamics.CRM.letter
    /// </summary>
    public partial class MicrosoftDynamicsCRMletter
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMletter class.
        /// </summary>
        public MicrosoftDynamicsCRMletter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMletter class.
        /// </summary>
        public MicrosoftDynamicsCRMletter(string category = default(string), string subscriptionid = default(string), string subcategory = default(string), bool? directioncode = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string address = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordLetter = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMactioncard> letterActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> letterPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceLetter = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMprocesssession> letterProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyLetter = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> letterConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMbulkdeletefailure> letterBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleLetter = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMsyncerror> letterSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitLetter = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMannotation> letterAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMsla slainvokedidLetterSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMteam owningteamLetter = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMactivityparty> letterActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMasyncoperation> letterAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidLetter = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMconnection> letterConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser owninguserLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> letterDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMqueueitem> letterQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMsystemuser modifiedbyLetter = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaLetterSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsystemuser createdbyLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> letterDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMaccount regardingobjectidAccountLetter = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact regardingobjectidContactLetter = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMprincipal owneridLetter = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMrraApplication regardingobjectidRraApplicationLetter = default(MicrosoftDynamicsCRMrraApplication))
        {
            Category = category;
            Subscriptionid = subscriptionid;
            Subcategory = subcategory;
            Directioncode = directioncode;
            Overriddencreatedon = overriddencreatedon;
            Address = address;
            Importsequencenumber = importsequencenumber;
            RegardingobjectidKnowledgebaserecordLetter = regardingobjectidKnowledgebaserecordLetter;
            LetterActioncard = letterActioncard;
            LetterPrincipalobjectattributeaccess = letterPrincipalobjectattributeaccess;
            SlakpiinstanceLetter = slakpiinstanceLetter;
            LetterProcessSessions = letterProcessSessions;
            StageidProcessstage = stageidProcessstage;
            ModifiedonbehalfbyLetter = modifiedonbehalfbyLetter;
            CreatedonbehalfbyLetter = createdonbehalfbyLetter;
            LetterConnections2 = letterConnections2;
            LetterBulkDeleteFailures = letterBulkDeleteFailures;
            RegardingobjectidKnowledgearticleLetter = regardingobjectidKnowledgearticleLetter;
            LetterSyncErrors = letterSyncErrors;
            OwningbusinessunitLetter = owningbusinessunitLetter;
            LetterAnnotation = letterAnnotation;
            SlainvokedidLetterSla = slainvokedidLetterSla;
            OwningteamLetter = owningteamLetter;
            LetterActivityParties = letterActivityParties;
            LetterAsyncOperations = letterAsyncOperations;
            TransactioncurrencyidLetter = transactioncurrencyidLetter;
            LetterConnections1 = letterConnections1;
            OwninguserLetter = owninguserLetter;
            LetterDuplicateBaseRecord = letterDuplicateBaseRecord;
            LetterQueueItem = letterQueueItem;
            ActivityidActivitypointer = activityidActivitypointer;
            ModifiedbyLetter = modifiedbyLetter;
            SlaLetterSla = slaLetterSla;
            CreatedbyLetter = createdbyLetter;
            LetterDuplicateMatchingRecord = letterDuplicateMatchingRecord;
            RegardingobjectidAccountLetter = regardingobjectidAccountLetter;
            RegardingobjectidContactLetter = regardingobjectidContactLetter;
            OwneridLetter = owneridLetter;
            RegardingobjectidRraApplicationLetter = regardingobjectidRraApplicationLetter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_letter")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> LetterActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> LetterPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_letter")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> LetterProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_letter")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_letter")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> LetterConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> LetterBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_letter")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> LetterSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_letter")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> LetterAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_letter_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidLetterSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_letter")]
        public MicrosoftDynamicsCRMteam OwningteamLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> LetterActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> LetterAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_letter")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> LetterConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_letter")]
        public MicrosoftDynamicsCRMsystemuser OwninguserLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> LetterDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> LetterQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_letter")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_letter_sla")]
        public MicrosoftDynamicsCRMsla SlaLetterSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_letter")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> LetterDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_letter")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_letter")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_letter")]
        public MicrosoftDynamicsCRMprincipal OwneridLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_rra_application_letter")]
        public MicrosoftDynamicsCRMrraApplication RegardingobjectidRraApplicationLetter { get; set; }

    }
}
