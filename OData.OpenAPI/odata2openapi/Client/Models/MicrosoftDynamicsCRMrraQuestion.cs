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
    /// Microsoft.Dynamics.CRM.rra_question
    /// </summary>
    public partial class MicrosoftDynamicsCRMrraQuestion
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrraQuestion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMrraQuestion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrraQuestion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMrraQuestion(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string rraName = default(string), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), string _createdonbehalfbyValue = default(string), string _owneridValue = default(string), int? rraDisplayquestionlabel = default(int?), int? statecode = default(int?), string _rraWebpageidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? rraDisplayorder = default(int?), string versionnumber = default(string), string rraQuestionid = default(string), string _rraQuestiontypeValue = default(string), int? utcconversiontimezonecode = default(int?), string rraErrormessage = default(string), string _owninguserValue = default(string), int? timezoneruleversionnumber = default(int?), string rraQuestiontooltip = default(string), string _modifiedonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> rraQuestionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> rraQuestionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> rraQuestionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> rraQuestionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> rraQuestionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> rraQuestionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> rraQuestionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> rraQuestionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMrraQuestiontype rraQuestionType = default(MicrosoftDynamicsCRMrraQuestiontype), IList<MicrosoftDynamicsCRMrraResponse> rraQuestionRraResponseQuestion = default(IList<MicrosoftDynamicsCRMrraResponse>), MicrosoftDynamicsCRMrraWebpage rraWebPageId = default(MicrosoftDynamicsCRMrraWebpage))
        {
            Modifiedon = modifiedon;
            this._owningteamValue = _owningteamValue;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            RraName = rraName;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owneridValue = _owneridValue;
            RraDisplayquestionlabel = rraDisplayquestionlabel;
            Statecode = statecode;
            this._rraWebpageidValue = _rraWebpageidValue;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            RraDisplayorder = rraDisplayorder;
            Versionnumber = versionnumber;
            RraQuestionid = rraQuestionid;
            this._rraQuestiontypeValue = _rraQuestiontypeValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            RraErrormessage = rraErrormessage;
            this._owninguserValue = _owninguserValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            RraQuestiontooltip = rraQuestiontooltip;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            RraQuestionSyncErrors = rraQuestionSyncErrors;
            RraQuestionDuplicateMatchingRecord = rraQuestionDuplicateMatchingRecord;
            RraQuestionDuplicateBaseRecord = rraQuestionDuplicateBaseRecord;
            RraQuestionAsyncOperations = rraQuestionAsyncOperations;
            RraQuestionMailboxTrackingFolders = rraQuestionMailboxTrackingFolders;
            RraQuestionProcessSession = rraQuestionProcessSession;
            RraQuestionBulkDeleteFailures = rraQuestionBulkDeleteFailures;
            RraQuestionPrincipalObjectAttributeAccesses = rraQuestionPrincipalObjectAttributeAccesses;
            RraQuestionType = rraQuestionType;
            RraQuestionRraResponseQuestion = rraQuestionRraResponseQuestion;
            RraWebPageId = rraWebPageId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_name")]
        public string RraName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_displayquestionlabel")]
        public int? RraDisplayquestionlabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rra_webpageid_value")]
        public string _rraWebpageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_displayorder")]
        public int? RraDisplayorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_questionid")]
        public string RraQuestionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rra_questiontype_value")]
        public string _rraQuestiontypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_errormessage")]
        public string RraErrormessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_questiontooltip")]
        public string RraQuestiontooltip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RraQuestionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RraQuestionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RraQuestionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RraQuestionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> RraQuestionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> RraQuestionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> RraQuestionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> RraQuestionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_QuestionType")]
        public MicrosoftDynamicsCRMrraQuestiontype RraQuestionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_question_rra_response_Question")]
        public IList<MicrosoftDynamicsCRMrraResponse> RraQuestionRraResponseQuestion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rra_WebPageId")]
        public MicrosoftDynamicsCRMrraWebpage RraWebPageId { get; set; }

    }
}
