// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRM.Interface.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.msdyn_aiconfiguration
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynAiconfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAiconfiguration class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAiconfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAiconfiguration class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAiconfiguration(string iscustomizable = default(string), int? timezoneruleversionnumber = default(int?), string msdynModelprovisioningmetadata = default(string), string versionnumber = default(string), string _owningbusinessunitValue = default(string), byte[] msdynModel = default(byte[]), string _msdynAimodelidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? msdynMajoriterationnumber = default(int?), string msdynRunconfiguration = default(string), string _owningteamValue = default(string), string msdynModelprovisioningstatus = default(string), string msdynModelperformance = default(string), string msdynModelrundataspecification = default(string), string _owninguserValue = default(string), string solutionid = default(string), string msdynAiconfigurationid = default(string), string msdynLasterrors = default(string), System.DateTimeOffset? msdynLasttrainorrundate = default(System.DateTimeOffset?), string msdynModeldata = default(string), int? utcconversiontimezonecode = default(int?), string msdynModelName = default(string), int? importsequencenumber = default(int?), string msdynAiconfigurationidunique = default(string), string msdynCustomconfiguration = default(string), string msdynName = default(string), string msdynSchedulingoptions = default(string), int? msdynTemplateversion = default(int?), string _msdynConnectionreferenceidValue = default(string), string _msdynTrainedmodelaiconfigurationpareidValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string msdynModelglobalexplainability = default(string), int? msdynType = default(int?), int? msdynMinoriterationnumber = default(int?), string _createdbyValue = default(string), int? statuscode = default(int?), string introducedversion = default(string), int? componentstate = default(int?), string msdynResourceinfo = default(string), string _createdonbehalfbyValue = default(string), string msdynDatabinding = default(string), int? statecode = default(int?), string _owneridValue = default(string), string _msdynCreatedfromconfigurationidValue = default(string), bool? ismanaged = default(bool?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynAiconfigurationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynAiconfigurationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynAiconfigurationMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynAiconfigurationProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynAiconfigurationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynAiconfigurationPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMfileattachment> msdynAiconfigurationFileAttachments = default(IList<MicrosoftDynamicsCRMfileattachment>), MicrosoftDynamicsCRMmsdynAiconfiguration msdynTrainedModelAIConfigurationPareId = default(MicrosoftDynamicsCRMmsdynAiconfiguration), IList<MicrosoftDynamicsCRMmsdynAiconfiguration> msdynAiconfigurationMsdynAiconfiguration = default(IList<MicrosoftDynamicsCRMmsdynAiconfiguration>), MicrosoftDynamicsCRMmsdynAiconfiguration msdynCreatedFromConfigurationId = default(MicrosoftDynamicsCRMmsdynAiconfiguration), IList<MicrosoftDynamicsCRMmsdynAiconfiguration> msdynCreatedfromconfigurationMsdynToconfiguration = default(IList<MicrosoftDynamicsCRMmsdynAiconfiguration>), MicrosoftDynamicsCRMmsdynAimodel msdynAIModelId = default(MicrosoftDynamicsCRMmsdynAimodel), MicrosoftDynamicsCRMconnectionreference msdynConnectionReferenceId = default(MicrosoftDynamicsCRMconnectionreference), IList<MicrosoftDynamicsCRMmsdynAiodtrainingimage> msdynAiconfigurationMsdynAiodtrainingimage = default(IList<MicrosoftDynamicsCRMmsdynAiodtrainingimage>), IList<MicrosoftDynamicsCRMmsdynAiodlabel> msdynAiodlabelMsdynAiconfiguration = default(IList<MicrosoftDynamicsCRMmsdynAiodlabel>), IList<MicrosoftDynamicsCRMmsdynAifptrainingdocument> msdynMsdynAiconfigurationMsdynAifptrainingdocumentAIConfigurationId = default(IList<MicrosoftDynamicsCRMmsdynAifptrainingdocument>))
        {
            Iscustomizable = iscustomizable;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            MsdynModelprovisioningmetadata = msdynModelprovisioningmetadata;
            Versionnumber = versionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            MsdynModel = msdynModel;
            this._msdynAimodelidValue = _msdynAimodelidValue;
            Overriddencreatedon = overriddencreatedon;
            MsdynMajoriterationnumber = msdynMajoriterationnumber;
            MsdynRunconfiguration = msdynRunconfiguration;
            this._owningteamValue = _owningteamValue;
            MsdynModelprovisioningstatus = msdynModelprovisioningstatus;
            MsdynModelperformance = msdynModelperformance;
            MsdynModelrundataspecification = msdynModelrundataspecification;
            this._owninguserValue = _owninguserValue;
            Solutionid = solutionid;
            MsdynAiconfigurationid = msdynAiconfigurationid;
            MsdynLasterrors = msdynLasterrors;
            MsdynLasttrainorrundate = msdynLasttrainorrundate;
            MsdynModeldata = msdynModeldata;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            MsdynModelName = msdynModelName;
            Importsequencenumber = importsequencenumber;
            MsdynAiconfigurationidunique = msdynAiconfigurationidunique;
            MsdynCustomconfiguration = msdynCustomconfiguration;
            MsdynName = msdynName;
            MsdynSchedulingoptions = msdynSchedulingoptions;
            MsdynTemplateversion = msdynTemplateversion;
            this._msdynConnectionreferenceidValue = _msdynConnectionreferenceidValue;
            this._msdynTrainedmodelaiconfigurationpareidValue = _msdynTrainedmodelaiconfigurationpareidValue;
            Overwritetime = overwritetime;
            this._modifiedbyValue = _modifiedbyValue;
            MsdynModelglobalexplainability = msdynModelglobalexplainability;
            MsdynType = msdynType;
            MsdynMinoriterationnumber = msdynMinoriterationnumber;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            Introducedversion = introducedversion;
            Componentstate = componentstate;
            MsdynResourceinfo = msdynResourceinfo;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            MsdynDatabinding = msdynDatabinding;
            Statecode = statecode;
            this._owneridValue = _owneridValue;
            this._msdynCreatedfromconfigurationidValue = _msdynCreatedfromconfigurationidValue;
            Ismanaged = ismanaged;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            Createdon = createdon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynAiconfigurationSyncErrors = msdynAiconfigurationSyncErrors;
            MsdynAiconfigurationAsyncOperations = msdynAiconfigurationAsyncOperations;
            MsdynAiconfigurationMailboxTrackingFolders = msdynAiconfigurationMailboxTrackingFolders;
            MsdynAiconfigurationProcessSession = msdynAiconfigurationProcessSession;
            MsdynAiconfigurationBulkDeleteFailures = msdynAiconfigurationBulkDeleteFailures;
            MsdynAiconfigurationPrincipalObjectAttributeAccesses = msdynAiconfigurationPrincipalObjectAttributeAccesses;
            MsdynAiconfigurationFileAttachments = msdynAiconfigurationFileAttachments;
            MsdynTrainedModelAIConfigurationPareId = msdynTrainedModelAIConfigurationPareId;
            MsdynAiconfigurationMsdynAiconfiguration = msdynAiconfigurationMsdynAiconfiguration;
            MsdynCreatedFromConfigurationId = msdynCreatedFromConfigurationId;
            MsdynCreatedfromconfigurationMsdynToconfiguration = msdynCreatedfromconfigurationMsdynToconfiguration;
            MsdynAIModelId = msdynAIModelId;
            MsdynConnectionReferenceId = msdynConnectionReferenceId;
            MsdynAiconfigurationMsdynAiodtrainingimage = msdynAiconfigurationMsdynAiodtrainingimage;
            MsdynAiodlabelMsdynAiconfiguration = msdynAiodlabelMsdynAiconfiguration;
            MsdynMsdynAiconfigurationMsdynAifptrainingdocumentAIConfigurationId = msdynMsdynAiconfigurationMsdynAifptrainingdocumentAIConfigurationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_modelprovisioningmetadata")]
        public string MsdynModelprovisioningmetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "msdyn_model")]
        public byte[] MsdynModel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_aimodelid_value")]
        public string _msdynAimodelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_majoriterationnumber")]
        public int? MsdynMajoriterationnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_runconfiguration")]
        public string MsdynRunconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_modelprovisioningstatus")]
        public string MsdynModelprovisioningstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_modelperformance")]
        public string MsdynModelperformance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_modelrundataspecification")]
        public string MsdynModelrundataspecification { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfigurationid")]
        public string MsdynAiconfigurationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_lasterrors")]
        public string MsdynLasterrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_lasttrainorrundate")]
        public System.DateTimeOffset? MsdynLasttrainorrundate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_modeldata")]
        public string MsdynModeldata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_model_name")]
        public string MsdynModelName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfigurationidunique")]
        public string MsdynAiconfigurationidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_customconfiguration")]
        public string MsdynCustomconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_schedulingoptions")]
        public string MsdynSchedulingoptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_templateversion")]
        public int? MsdynTemplateversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_connectionreferenceid_value")]
        public string _msdynConnectionreferenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_trainedmodelaiconfigurationpareid_value")]
        public string _msdynTrainedmodelaiconfigurationpareidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_modelglobalexplainability")]
        public string MsdynModelglobalexplainability { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_type")]
        public int? MsdynType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_minoriterationnumber")]
        public int? MsdynMinoriterationnumber { get; set; }

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
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_resourceinfo")]
        public string MsdynResourceinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_databinding")]
        public string MsdynDatabinding { get; set; }

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
        [JsonProperty(PropertyName = "_msdyn_createdfromconfigurationid_value")]
        public string _msdynCreatedfromconfigurationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynAiconfigurationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynAiconfigurationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynAiconfigurationMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynAiconfigurationProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynAiconfigurationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynAiconfigurationPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_FileAttachments")]
        public IList<MicrosoftDynamicsCRMfileattachment> MsdynAiconfigurationFileAttachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_TrainedModelAIConfigurationPareId")]
        public MicrosoftDynamicsCRMmsdynAiconfiguration MsdynTrainedModelAIConfigurationPareId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_msdyn_aiconfiguration")]
        public IList<MicrosoftDynamicsCRMmsdynAiconfiguration> MsdynAiconfigurationMsdynAiconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_CreatedFromConfigurationId")]
        public MicrosoftDynamicsCRMmsdynAiconfiguration MsdynCreatedFromConfigurationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_createdfromconfiguration_msdyn_toconfiguration")]
        public IList<MicrosoftDynamicsCRMmsdynAiconfiguration> MsdynCreatedfromconfigurationMsdynToconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_AIModelId")]
        public MicrosoftDynamicsCRMmsdynAimodel MsdynAIModelId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_ConnectionReferenceId")]
        public MicrosoftDynamicsCRMconnectionreference MsdynConnectionReferenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiconfiguration_msdyn_aiodtrainingimage")]
        public IList<MicrosoftDynamicsCRMmsdynAiodtrainingimage> MsdynAiconfigurationMsdynAiodtrainingimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aiodlabel_msdyn_aiconfiguration")]
        public IList<MicrosoftDynamicsCRMmsdynAiodlabel> MsdynAiodlabelMsdynAiconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId")]
        public IList<MicrosoftDynamicsCRMmsdynAifptrainingdocument> MsdynMsdynAiconfigurationMsdynAifptrainingdocumentAIConfigurationId { get; set; }

    }
}
