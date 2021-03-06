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
    /// Microsoft.Dynamics.CRM.msdyn_knowledgesearchfilter
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynKnowledgesearchfilter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynKnowledgesearchfilter class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynKnowledgesearchfilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynKnowledgesearchfilter class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynKnowledgesearchfilter(string msdynKnowledgesearchfilterid = default(string), int? utcconversiontimezonecode = default(int?), string _owneridValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), int? statecode = default(int?), bool? msdynEnabled = default(bool?), bool? msdynIscustom = default(bool?), string iscustomizable = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string solutionid = default(string), int? statuscode = default(int?), string componentidunique = default(string), int? componentstate = default(int?), int? importsequencenumber = default(int?), string msdynEntityname = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? msdynOrderid = default(int?), string _modifiedonbehalfbyValue = default(string), bool? ismanaged = default(bool?), string msdynUniquename = default(string), string _createdbyValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _owninguserValue = default(string), string msdynName = default(string), int? timezoneruleversionnumber = default(int?), string _owningteamValue = default(string), string msdynDefaultvalues = default(string), string msdynSelectedvalues = default(string), string msdynAttributename = default(string), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynKnowledgesearchfilterSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynKnowledgesearchfilterDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynKnowledgesearchfilterDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynKnowledgesearchfilterAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynKnowledgesearchfilterMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynKnowledgesearchfilterProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynKnowledgesearchfilterBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynKnowledgesearchfilterPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            MsdynKnowledgesearchfilterid = msdynKnowledgesearchfilterid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owneridValue = _owneridValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            MsdynEnabled = msdynEnabled;
            MsdynIscustom = msdynIscustom;
            Iscustomizable = iscustomizable;
            Overriddencreatedon = overriddencreatedon;
            Solutionid = solutionid;
            Statuscode = statuscode;
            Componentidunique = componentidunique;
            Componentstate = componentstate;
            Importsequencenumber = importsequencenumber;
            MsdynEntityname = msdynEntityname;
            Createdon = createdon;
            MsdynOrderid = msdynOrderid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Ismanaged = ismanaged;
            MsdynUniquename = msdynUniquename;
            this._createdbyValue = _createdbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            Overwritetime = overwritetime;
            this._owninguserValue = _owninguserValue;
            MsdynName = msdynName;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningteamValue = _owningteamValue;
            MsdynDefaultvalues = msdynDefaultvalues;
            MsdynSelectedvalues = msdynSelectedvalues;
            MsdynAttributename = msdynAttributename;
            Versionnumber = versionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynKnowledgesearchfilterSyncErrors = msdynKnowledgesearchfilterSyncErrors;
            MsdynKnowledgesearchfilterDuplicateMatchingRecord = msdynKnowledgesearchfilterDuplicateMatchingRecord;
            MsdynKnowledgesearchfilterDuplicateBaseRecord = msdynKnowledgesearchfilterDuplicateBaseRecord;
            MsdynKnowledgesearchfilterAsyncOperations = msdynKnowledgesearchfilterAsyncOperations;
            MsdynKnowledgesearchfilterMailboxTrackingFolders = msdynKnowledgesearchfilterMailboxTrackingFolders;
            MsdynKnowledgesearchfilterProcessSession = msdynKnowledgesearchfilterProcessSession;
            MsdynKnowledgesearchfilterBulkDeleteFailures = msdynKnowledgesearchfilterBulkDeleteFailures;
            MsdynKnowledgesearchfilterPrincipalObjectAttributeAccesses = msdynKnowledgesearchfilterPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilterid")]
        public string MsdynKnowledgesearchfilterid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_enabled")]
        public bool? MsdynEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_iscustom")]
        public bool? MsdynIscustom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_entityname")]
        public string MsdynEntityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_orderid")]
        public int? MsdynOrderid { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_uniquename")]
        public string MsdynUniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_defaultvalues")]
        public string MsdynDefaultvalues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_selectedvalues")]
        public string MsdynSelectedvalues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_attributename")]
        public string MsdynAttributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynKnowledgesearchfilterSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynKnowledgesearchfilterDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynKnowledgesearchfilterDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynKnowledgesearchfilterAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynKnowledgesearchfilterMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynKnowledgesearchfilterProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynKnowledgesearchfilterBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_knowledgesearchfilter_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynKnowledgesearchfilterPrincipalObjectAttributeAccesses { get; set; }

    }
}
