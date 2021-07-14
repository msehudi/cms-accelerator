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
    /// Microsoft.Dynamics.CRM.msdyn_aiodtrainingboundingbox
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAiodtrainingboundingbox(string _modifiedbyValue = default(string), string _msdynAiodtrainingimageidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), string _owningteamValue = default(string), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), decimal? msdynLeft = default(decimal?), int? statuscode = default(int?), decimal? msdynHeight = default(decimal?), string _createdonbehalfbyValue = default(string), string msdynAiodtrainingboundingboxid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), decimal? msdynTop = default(decimal?), int? statecode = default(int?), string _owneridValue = default(string), string msdynName = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), decimal? msdynWidth = default(decimal?), string versionnumber = default(string), int? importsequencenumber = default(int?), string _msdynAiodlabelidValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynAiodtrainingboundingboxSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynAiodtrainingboundingboxDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynAiodtrainingboundingboxDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynAiodtrainingboundingboxAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynAiodtrainingboundingboxMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynAiodtrainingboundingboxProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynAiodtrainingboundingboxBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynAiodtrainingboundingboxPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMmsdynAiodlabel msdynAIOdLabelId = default(MicrosoftDynamicsCRMmsdynAiodlabel), MicrosoftDynamicsCRMmsdynAiodtrainingimage msdynAIOdTrainingImageId = default(MicrosoftDynamicsCRMmsdynAiodtrainingimage))
        {
            this._modifiedbyValue = _modifiedbyValue;
            this._msdynAiodtrainingimageidValue = _msdynAiodtrainingimageidValue;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            MsdynLeft = msdynLeft;
            Statuscode = statuscode;
            MsdynHeight = msdynHeight;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            MsdynAiodtrainingboundingboxid = msdynAiodtrainingboundingboxid;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            MsdynTop = msdynTop;
            Statecode = statecode;
            this._owneridValue = _owneridValue;
            MsdynName = msdynName;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdon = createdon;
            MsdynWidth = msdynWidth;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            this._msdynAiodlabelidValue = _msdynAiodlabelidValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynAiodtrainingboundingboxSyncErrors = msdynAiodtrainingboundingboxSyncErrors;
            MsdynAiodtrainingboundingboxDuplicateMatchingRecord = msdynAiodtrainingboundingboxDuplicateMatchingRecord;
            MsdynAiodtrainingboundingboxDuplicateBaseRecord = msdynAiodtrainingboundingboxDuplicateBaseRecord;
            MsdynAiodtrainingboundingboxAsyncOperations = msdynAiodtrainingboundingboxAsyncOperations;
            MsdynAiodtrainingboundingboxMailboxTrackingFolders = msdynAiodtrainingboundingboxMailboxTrackingFolders;
            MsdynAiodtrainingboundingboxProcessSession = msdynAiodtrainingboundingboxProcessSession;
            MsdynAiodtrainingboundingboxBulkDeleteFailures = msdynAiodtrainingboundingboxBulkDeleteFailures;
            MsdynAiodtrainingboundingboxPrincipalObjectAttributeAccesses = msdynAiodtrainingboundingboxPrincipalObjectAttributeAccesses;
            MsdynAIOdLabelId = msdynAIOdLabelId;
            MsdynAIOdTrainingImageId = msdynAIOdTrainingImageId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_aiodtrainingimageid_value")]
        public string _msdynAiodtrainingimageidValue { get; set; }

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
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_left")]
        public decimal? MsdynLeft { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_height")]
        public decimal? MsdynHeight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingboxid")]
        public string MsdynAiodtrainingboundingboxid { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_top")]
        public decimal? MsdynTop { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_width")]
        public decimal? MsdynWidth { get; set; }

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
        [JsonProperty(PropertyName = "_msdyn_aiodlabelid_value")]
        public string _msdynAiodlabelidValue { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynAiodtrainingboundingboxSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynAiodtrainingboundingboxDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynAiodtrainingboundingboxDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynAiodtrainingboundingboxAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynAiodtrainingboundingboxMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynAiodtrainingboundingboxProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynAiodtrainingboundingboxBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynAiodtrainingboundingboxPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_AIOdLabelId")]
        public MicrosoftDynamicsCRMmsdynAiodlabel MsdynAIOdLabelId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_AIOdTrainingImageId")]
        public MicrosoftDynamicsCRMmsdynAiodtrainingimage MsdynAIOdTrainingImageId { get; set; }

    }
}
