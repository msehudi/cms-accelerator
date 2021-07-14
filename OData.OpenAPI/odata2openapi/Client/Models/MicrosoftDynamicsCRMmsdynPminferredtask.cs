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
    /// Microsoft.Dynamics.CRM.msdyn_pminferredtask
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynPminferredtask
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPminferredtask class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPminferredtask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPminferredtask class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPminferredtask(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), bool? ismanaged = default(bool?), string msdynOutputdata = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string msdynIterationid = default(string), string _owninguserValue = default(string), string msdynSharedrecordingmetadata = default(string), int? msdynAutomationstatus = default(int?), string _modifiedbyValue = default(string), string _owningteamValue = default(string), int? timezoneruleversionnumber = default(int?), string iscustomizable = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string msdynAutomationdata = default(string), string msdynPminferredtaskid = default(string), string _createdbyValue = default(string), int? statuscode = default(int?), string msdynName = default(string), string msdynDescription = default(string), string componentidunique = default(string), string _owneridValue = default(string), string versionnumber = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? statecode = default(int?), string solutionid = default(string), int? componentstate = default(int?), string msdynLasterrors = default(string), int? utcconversiontimezonecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynPminferredtaskSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynPminferredtaskDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynPminferredtaskDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynPminferredtaskAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynPminferredtaskMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynPminferredtaskProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynPminferredtaskBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynPminferredtaskPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMmsdynPmrecording> msdynMsdynPminferredtaskMsdynPmrecordingParenttask = default(IList<MicrosoftDynamicsCRMmsdynPmrecording>))
        {
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Ismanaged = ismanaged;
            MsdynOutputdata = msdynOutputdata;
            Modifiedon = modifiedon;
            MsdynIterationid = msdynIterationid;
            this._owninguserValue = _owninguserValue;
            MsdynSharedrecordingmetadata = msdynSharedrecordingmetadata;
            MsdynAutomationstatus = msdynAutomationstatus;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningteamValue = _owningteamValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Iscustomizable = iscustomizable;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overwritetime = overwritetime;
            MsdynAutomationdata = msdynAutomationdata;
            MsdynPminferredtaskid = msdynPminferredtaskid;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            MsdynName = msdynName;
            MsdynDescription = msdynDescription;
            Componentidunique = componentidunique;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statecode = statecode;
            Solutionid = solutionid;
            Componentstate = componentstate;
            MsdynLasterrors = msdynLasterrors;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynPminferredtaskSyncErrors = msdynPminferredtaskSyncErrors;
            MsdynPminferredtaskDuplicateMatchingRecord = msdynPminferredtaskDuplicateMatchingRecord;
            MsdynPminferredtaskDuplicateBaseRecord = msdynPminferredtaskDuplicateBaseRecord;
            MsdynPminferredtaskAsyncOperations = msdynPminferredtaskAsyncOperations;
            MsdynPminferredtaskMailboxTrackingFolders = msdynPminferredtaskMailboxTrackingFolders;
            MsdynPminferredtaskProcessSession = msdynPminferredtaskProcessSession;
            MsdynPminferredtaskBulkDeleteFailures = msdynPminferredtaskBulkDeleteFailures;
            MsdynPminferredtaskPrincipalObjectAttributeAccesses = msdynPminferredtaskPrincipalObjectAttributeAccesses;
            MsdynMsdynPminferredtaskMsdynPmrecordingParenttask = msdynMsdynPminferredtaskMsdynPmrecordingParenttask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_outputdata")]
        public string MsdynOutputdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_iterationid")]
        public string MsdynIterationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_sharedrecordingmetadata")]
        public string MsdynSharedrecordingmetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_automationstatus")]
        public int? MsdynAutomationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_automationdata")]
        public string MsdynAutomationdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtaskid")]
        public string MsdynPminferredtaskid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_description")]
        public string MsdynDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_lasterrors")]
        public string MsdynLasterrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_pminferredtask_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynPminferredtaskSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtask_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynPminferredtaskDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtask_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynPminferredtaskDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtask_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynPminferredtaskAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtask_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynPminferredtaskMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtask_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynPminferredtaskProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtask_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynPminferredtaskBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_pminferredtask_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynPminferredtaskPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msdyn_pminferredtask_msdyn_pmrecording_parenttask")]
        public IList<MicrosoftDynamicsCRMmsdynPmrecording> MsdynMsdynPminferredtaskMsdynPmrecordingParenttask { get; set; }

    }
}
