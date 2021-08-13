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
    /// Microsoft.Dynamics.CRM.environmentvariabledefinition
    /// </summary>
    public partial class MicrosoftDynamicsCRMenvironmentvariabledefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMenvironmentvariabledefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMenvironmentvariabledefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMenvironmentvariabledefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMenvironmentvariabledefinition(string displayname = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string versionnumber = default(string), int? type = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), string _parentdefinitionidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string schemaname = default(string), string _owningteamValue = default(string), int? importsequencenumber = default(int?), string _owninguserValue = default(string), string hint = default(string), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), string environmentvariabledefinitionid = default(string), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), string _connectionreferenceidValue = default(string), string defaultvalue = default(string), string description = default(string), bool? ismanaged = default(bool?), string environmentvariabledefinitionidunique = default(string), int? utcconversiontimezonecode = default(int?), string iscustomizable = default(string), string parameterkey = default(string), string apiid = default(string), int? statuscode = default(int?), string _owneridValue = default(string), string introducedversion = default(string), string solutionid = default(string), string valueschema = default(string), bool? isrequired = default(bool?), string _createdbyValue = default(string), int? componentstate = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> environmentvariabledefinitionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> environmentvariabledefinitionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> environmentvariabledefinitionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> environmentvariabledefinitionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> environmentvariabledefinitionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> environmentvariabledefinitionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> environmentvariabledefinitionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> environmentvariabledefinitionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMenvironmentvariablevalue> environmentvariabledefinitionEnvironmentvariablevalue = default(IList<MicrosoftDynamicsCRMenvironmentvariablevalue>), MicrosoftDynamicsCRMenvironmentvariabledefinition parentDefinitionId = default(MicrosoftDynamicsCRMenvironmentvariabledefinition), IList<MicrosoftDynamicsCRMenvironmentvariabledefinition> envdefinitionEnvdefinition = default(IList<MicrosoftDynamicsCRMenvironmentvariabledefinition>), IList<MicrosoftDynamicsCRMbot> botEnvironmentvariabledefinition = default(IList<MicrosoftDynamicsCRMbot>), IList<MicrosoftDynamicsCRMbotcomponent> botcomponentEnvironmentvariabledefinition = default(IList<MicrosoftDynamicsCRMbotcomponent>))
        {
            Displayname = displayname;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            Type = type;
            Overwritetime = overwritetime;
            Modifiedon = modifiedon;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._parentdefinitionidValue = _parentdefinitionidValue;
            Createdon = createdon;
            Schemaname = schemaname;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            Hint = hint;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Environmentvariabledefinitionid = environmentvariabledefinitionid;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._connectionreferenceidValue = _connectionreferenceidValue;
            Defaultvalue = defaultvalue;
            Description = description;
            Ismanaged = ismanaged;
            Environmentvariabledefinitionidunique = environmentvariabledefinitionidunique;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Iscustomizable = iscustomizable;
            Parameterkey = parameterkey;
            Apiid = apiid;
            Statuscode = statuscode;
            this._owneridValue = _owneridValue;
            Introducedversion = introducedversion;
            Solutionid = solutionid;
            Valueschema = valueschema;
            Isrequired = isrequired;
            this._createdbyValue = _createdbyValue;
            Componentstate = componentstate;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            EnvironmentvariabledefinitionSyncErrors = environmentvariabledefinitionSyncErrors;
            EnvironmentvariabledefinitionDuplicateMatchingRecord = environmentvariabledefinitionDuplicateMatchingRecord;
            EnvironmentvariabledefinitionDuplicateBaseRecord = environmentvariabledefinitionDuplicateBaseRecord;
            EnvironmentvariabledefinitionAsyncOperations = environmentvariabledefinitionAsyncOperations;
            EnvironmentvariabledefinitionMailboxTrackingFolders = environmentvariabledefinitionMailboxTrackingFolders;
            EnvironmentvariabledefinitionProcessSession = environmentvariabledefinitionProcessSession;
            EnvironmentvariabledefinitionBulkDeleteFailures = environmentvariabledefinitionBulkDeleteFailures;
            EnvironmentvariabledefinitionPrincipalObjectAttributeAccesses = environmentvariabledefinitionPrincipalObjectAttributeAccesses;
            EnvironmentvariabledefinitionEnvironmentvariablevalue = environmentvariabledefinitionEnvironmentvariablevalue;
            ParentDefinitionId = parentDefinitionId;
            EnvdefinitionEnvdefinition = envdefinitionEnvdefinition;
            BotEnvironmentvariabledefinition = botEnvironmentvariabledefinition;
            BotcomponentEnvironmentvariabledefinition = botcomponentEnvironmentvariabledefinition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayname")]
        public string Displayname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentdefinitionid_value")]
        public string _parentdefinitionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaname")]
        public string Schemaname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hint")]
        public string Hint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinitionid")]
        public string Environmentvariabledefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_connectionreferenceid_value")]
        public string _connectionreferenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvalue")]
        public string Defaultvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinitionidunique")]
        public string Environmentvariabledefinitionidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameterkey")]
        public string Parameterkey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiid")]
        public string Apiid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valueschema")]
        public string Valueschema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isrequired")]
        public bool? Isrequired { get; set; }

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
        [JsonProperty(PropertyName = "environmentvariabledefinition_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EnvironmentvariabledefinitionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EnvironmentvariabledefinitionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EnvironmentvariabledefinitionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EnvironmentvariabledefinitionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EnvironmentvariabledefinitionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> EnvironmentvariabledefinitionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EnvironmentvariabledefinitionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EnvironmentvariabledefinitionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environmentvariabledefinition_environmentvariablevalue")]
        public IList<MicrosoftDynamicsCRMenvironmentvariablevalue> EnvironmentvariabledefinitionEnvironmentvariablevalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentDefinitionId")]
        public MicrosoftDynamicsCRMenvironmentvariabledefinition ParentDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "envdefinition_envdefinition")]
        public IList<MicrosoftDynamicsCRMenvironmentvariabledefinition> EnvdefinitionEnvdefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bot_environmentvariabledefinition")]
        public IList<MicrosoftDynamicsCRMbot> BotEnvironmentvariabledefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "botcomponent_environmentvariabledefinition")]
        public IList<MicrosoftDynamicsCRMbotcomponent> BotcomponentEnvironmentvariabledefinition { get; set; }

    }
}