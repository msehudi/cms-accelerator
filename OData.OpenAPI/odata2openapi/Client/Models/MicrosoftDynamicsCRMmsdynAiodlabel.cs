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
    /// Microsoft.Dynamics.CRM.msdyn_aiodlabel
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynAiodlabel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAiodlabel class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAiodlabel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAiodlabel class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAiodlabel(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), int? timezoneruleversionnumber = default(int?), string msdynName = default(string), string _createdbyValue = default(string), string msdynLabelstring = default(string), string _owninguserValue = default(string), string msdynSourceattributelogicalname = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string msdynSourceentitysetname = default(string), string msdynAiodlabelid = default(string), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string _modifiedonbehalfbyValue = default(string), string _owningteamValue = default(string), int? statuscode = default(int?), int? statecode = default(int?), string msdynSourcerecordid = default(string), string versionnumber = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynAiodlabelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynAiodlabelDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynAiodlabelDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynAiodlabelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynAiodlabelMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynAiodlabelProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynAiodlabelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynAiodlabelPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMmsdynAiconfiguration> msdynAiodlabelMsdynAiconfiguration = default(IList<MicrosoftDynamicsCRMmsdynAiconfiguration>), IList<MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox> msdynAiodlabelMsdynAiodtrainingboundingbox = default(IList<MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox>))
        {
            Overriddencreatedon = overriddencreatedon;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            MsdynName = msdynName;
            this._createdbyValue = _createdbyValue;
            MsdynLabelstring = msdynLabelstring;
            this._owninguserValue = _owninguserValue;
            MsdynSourceattributelogicalname = msdynSourceattributelogicalname;
            Createdon = createdon;
            MsdynSourceentitysetname = msdynSourceentitysetname;
            MsdynAiodlabelid = msdynAiodlabelid;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            Statuscode = statuscode;
            Statecode = statecode;
            MsdynSourcerecordid = msdynSourcerecordid;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynAiodlabelSyncErrors = msdynAiodlabelSyncErrors;
            MsdynAiodlabelDuplicateMatchingRecord = msdynAiodlabelDuplicateMatchingRecord;
            MsdynAiodlabelDuplicateBaseRecord = msdynAiodlabelDuplicateBaseRecord;
            MsdynAiodlabelAsyncOperations = msdynAiodlabelAsyncOperations;
            MsdynAiodlabelMailboxTrackingFolders = msdynAiodlabelMailboxTrackingFolders;
            MsdynAiodlabelProcessSession = msdynAiodlabelProcessSession;
            MsdynAiodlabelBulkDeleteFailures = msdynAiodlabelBulkDeleteFailures;
            MsdynAiodlabelPrincipalObjectAttributeAccesses = msdynAiodlabelPrincipalObjectAttributeAccesses;
            MsdynAiodlabelMsdynAiconfiguration = msdynAiodlabelMsdynAiconfiguration;
            MsdynAiodlabelMsdynAiodtrainingboundingbox = msdynAiodlabelMsdynAiodtrainingboundingbox;
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
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_labelstring")]
        public string MsdynLabelstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_sourceattributelogicalname")]
        public string MsdynSourceattributelogicalname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_sourceentitysetname")]
        public string MsdynSourceentitysetname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabelid")]
        public string MsdynAiodlabelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

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
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_sourcerecordid")]
        public string MsdynSourcerecordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_aiodlabel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynAiodlabelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynAiodlabelDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynAiodlabelDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynAiodlabelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynAiodlabelMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynAiodlabelProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynAiodlabelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynAiodlabelPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_msdyn_aiconfiguration")]
        public IList<MicrosoftDynamicsCRMmsdynAiconfiguration> MsdynAiodlabelMsdynAiconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_msdyn_aiodtrainingboundingbox")]
        public IList<MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox> MsdynAiodlabelMsdynAiodtrainingboundingbox { get; set; }

    }
}