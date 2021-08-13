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
    /// Microsoft.Dynamics.CRM.datalakefolder
    /// </summary>
    public partial class MicrosoftDynamicsCRMdatalakefolder
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdatalakefolder class.
        /// </summary>
        public MicrosoftDynamicsCRMdatalakefolder()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdatalakefolder class.
        /// </summary>
        public MicrosoftDynamicsCRMdatalakefolder(int? utcconversiontimezonecode = default(int?), bool? ismanaged = default(bool?), string name = default(string), string _owningbusinessunitValue = default(string), string solutionid = default(string), string extendedproperties = default(string), string _createdbyValue = default(string), string path = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string componentidunique = default(string), int? importsequencenumber = default(int?), string _owningteamValue = default(string), bool? isprivate = default(bool?), int? statuscode = default(int?), string _owninguserValue = default(string), string _modifiedbyValue = default(string), int? componentstate = default(int?), bool? isdeepcopyenabled = default(bool?), string versionnumber = default(string), string containerendpoint = default(string), string datalakefolderUniquename = default(string), bool? iscustomercapacity = default(bool?), string owningappid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string datalakefolderid = default(string), string _owneridValue = default(string), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), string iscustomizable = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> datalakefolderSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> datalakefolderDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> datalakefolderDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> datalakefolderAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> datalakefolderMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> datalakefolderProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> datalakefolderBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> datalakefolderPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMdatalakefolderpermission> datalakefolderDatalakefolderpermission = default(IList<MicrosoftDynamicsCRMdatalakefolderpermission>))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Ismanaged = ismanaged;
            Name = name;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Solutionid = solutionid;
            Extendedproperties = extendedproperties;
            this._createdbyValue = _createdbyValue;
            Path = path;
            Overwritetime = overwritetime;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            Componentidunique = componentidunique;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            Isprivate = isprivate;
            Statuscode = statuscode;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Componentstate = componentstate;
            Isdeepcopyenabled = isdeepcopyenabled;
            Versionnumber = versionnumber;
            Containerendpoint = containerendpoint;
            DatalakefolderUniquename = datalakefolderUniquename;
            Iscustomercapacity = iscustomercapacity;
            Owningappid = owningappid;
            Overriddencreatedon = overriddencreatedon;
            Datalakefolderid = datalakefolderid;
            this._owneridValue = _owneridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            Iscustomizable = iscustomizable;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            DatalakefolderSyncErrors = datalakefolderSyncErrors;
            DatalakefolderDuplicateMatchingRecord = datalakefolderDuplicateMatchingRecord;
            DatalakefolderDuplicateBaseRecord = datalakefolderDuplicateBaseRecord;
            DatalakefolderAsyncOperations = datalakefolderAsyncOperations;
            DatalakefolderMailboxTrackingFolders = datalakefolderMailboxTrackingFolders;
            DatalakefolderProcessSession = datalakefolderProcessSession;
            DatalakefolderBulkDeleteFailures = datalakefolderBulkDeleteFailures;
            DatalakefolderPrincipalObjectAttributeAccesses = datalakefolderPrincipalObjectAttributeAccesses;
            DatalakefolderDatalakefolderpermission = datalakefolderDatalakefolderpermission;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedproperties")]
        public string Extendedproperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isprivate")]
        public bool? Isprivate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdeepcopyenabled")]
        public bool? Isdeepcopyenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "containerendpoint")]
        public string Containerendpoint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_uniquename")]
        public string DatalakefolderUniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomercapacity")]
        public bool? Iscustomercapacity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningappid")]
        public string Owningappid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolderid")]
        public string Datalakefolderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

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
        [JsonProperty(PropertyName = "datalakefolder_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DatalakefolderSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> DatalakefolderDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> DatalakefolderDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DatalakefolderAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DatalakefolderMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> DatalakefolderProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DatalakefolderBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DatalakefolderPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datalakefolder_datalakefolderpermission")]
        public IList<MicrosoftDynamicsCRMdatalakefolderpermission> DatalakefolderDatalakefolderpermission { get; set; }

    }
}