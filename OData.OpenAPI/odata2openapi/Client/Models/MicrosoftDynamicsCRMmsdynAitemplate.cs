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
    /// Microsoft.Dynamics.CRM.msdyn_aitemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynAitemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAitemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAitemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAitemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAitemplate(string msdynUxconfiguration = default(string), int? statuscode = default(int?), string versionnumber = default(string), string _owningteamValue = default(string), string _modifiedonbehalfbyValue = default(string), string msdynAitemplateidunique = default(string), bool? msdynIstrainable = default(bool?), string iscustomizable = default(string), string _createdonbehalfbyValue = default(string), string msdynTrainingconfigschema = default(string), string msdynRunconfigschema = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string msdynTrainingdataspecification = default(string), string _owneridValue = default(string), string solutionid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string msdynDatabinding = default(string), string _modifiedbyValue = default(string), string _owninguserValue = default(string), string _owningbusinessunitValue = default(string), string msdynRundataspecification = default(string), int? statecode = default(int?), int? msdynTemplateversion = default(int?), string _createdbyValue = default(string), int? componentstate = default(int?), string msdynAitemplateid = default(string), int? utcconversiontimezonecode = default(int?), string introducedversion = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string msdynUniquename = default(string), int? timezoneruleversionnumber = default(int?), string msdynResourceinfo = default(string), string msdynDefaultrunschedulingoptions = default(string), bool? ismanaged = default(bool?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynAitemplateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynAitemplateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynAitemplateMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynAitemplateProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynAitemplateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynAitemplatePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMmsdynAimodel> msdynAitemplateMsdynAimodel = default(IList<MicrosoftDynamicsCRMmsdynAimodel>))
        {
            MsdynUxconfiguration = msdynUxconfiguration;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            MsdynAitemplateidunique = msdynAitemplateidunique;
            MsdynIstrainable = msdynIstrainable;
            Iscustomizable = iscustomizable;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            MsdynTrainingconfigschema = msdynTrainingconfigschema;
            MsdynRunconfigschema = msdynRunconfigschema;
            Modifiedon = modifiedon;
            Createdon = createdon;
            MsdynTrainingdataspecification = msdynTrainingdataspecification;
            this._owneridValue = _owneridValue;
            Solutionid = solutionid;
            Overriddencreatedon = overriddencreatedon;
            MsdynDatabinding = msdynDatabinding;
            this._modifiedbyValue = _modifiedbyValue;
            this._owninguserValue = _owninguserValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            MsdynRundataspecification = msdynRundataspecification;
            Statecode = statecode;
            MsdynTemplateversion = msdynTemplateversion;
            this._createdbyValue = _createdbyValue;
            Componentstate = componentstate;
            MsdynAitemplateid = msdynAitemplateid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Introducedversion = introducedversion;
            Overwritetime = overwritetime;
            Importsequencenumber = importsequencenumber;
            MsdynUniquename = msdynUniquename;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            MsdynResourceinfo = msdynResourceinfo;
            MsdynDefaultrunschedulingoptions = msdynDefaultrunschedulingoptions;
            Ismanaged = ismanaged;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynAitemplateSyncErrors = msdynAitemplateSyncErrors;
            MsdynAitemplateAsyncOperations = msdynAitemplateAsyncOperations;
            MsdynAitemplateMailboxTrackingFolders = msdynAitemplateMailboxTrackingFolders;
            MsdynAitemplateProcessSession = msdynAitemplateProcessSession;
            MsdynAitemplateBulkDeleteFailures = msdynAitemplateBulkDeleteFailures;
            MsdynAitemplatePrincipalObjectAttributeAccesses = msdynAitemplatePrincipalObjectAttributeAccesses;
            MsdynAitemplateMsdynAimodel = msdynAitemplateMsdynAimodel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_uxconfiguration")]
        public string MsdynUxconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplateidunique")]
        public string MsdynAitemplateidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_istrainable")]
        public bool? MsdynIstrainable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_trainingconfigschema")]
        public string MsdynTrainingconfigschema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_runconfigschema")]
        public string MsdynRunconfigschema { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_trainingdataspecification")]
        public string MsdynTrainingdataspecification { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_databinding")]
        public string MsdynDatabinding { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_rundataspecification")]
        public string MsdynRundataspecification { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_templateversion")]
        public int? MsdynTemplateversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplateid")]
        public string MsdynAitemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_uniquename")]
        public string MsdynUniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_resourceinfo")]
        public string MsdynResourceinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_defaultrunschedulingoptions")]
        public string MsdynDefaultrunschedulingoptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_aitemplate_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynAitemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplate_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynAitemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplate_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynAitemplateMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplate_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynAitemplateProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplate_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynAitemplateBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplate_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynAitemplatePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_aitemplate_msdyn_aimodel")]
        public IList<MicrosoftDynamicsCRMmsdynAimodel> MsdynAitemplateMsdynAimodel { get; set; }

    }
}
