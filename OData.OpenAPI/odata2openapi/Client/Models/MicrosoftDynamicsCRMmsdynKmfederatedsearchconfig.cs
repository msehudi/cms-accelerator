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
    /// Microsoft.Dynamics.CRM.msdyn_kmfederatedsearchconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig(string connectionid = default(string), int? utcconversiontimezonecode = default(int?), string sharepointurl = default(string), string organization = default(string), int? searchtype = default(int?), string _owneridValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), string msdynDescription = default(string), string msdynKmfederatedsearchconfigid = default(string), string versionnumber = default(string), int? statecode = default(int?), string _modifiedbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string msdynName = default(string), string _owninguserValue = default(string), int? importsequencenumber = default(int?), bool? isdefault = default(bool?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynKmfederatedsearchconfigSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynKmfederatedsearchconfigDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynKmfederatedsearchconfigDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynKmfederatedsearchconfigAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynKmfederatedsearchconfigMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynKmfederatedsearchconfigProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynKmfederatedsearchconfigBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynKmfederatedsearchconfigPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMmsdynFederatedarticle> iKMsdynKmfederatedsearchconfigMsdynFederatedarticleSearchproviderid = default(IList<MicrosoftDynamicsCRMmsdynFederatedarticle>))
        {
            Connectionid = connectionid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Sharepointurl = sharepointurl;
            Organization = organization;
            Searchtype = searchtype;
            this._owneridValue = _owneridValue;
            Overriddencreatedon = overriddencreatedon;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            Statuscode = statuscode;
            MsdynDescription = msdynDescription;
            MsdynKmfederatedsearchconfigid = msdynKmfederatedsearchconfigid;
            Versionnumber = versionnumber;
            Statecode = statecode;
            this._modifiedbyValue = _modifiedbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            MsdynName = msdynName;
            this._owninguserValue = _owninguserValue;
            Importsequencenumber = importsequencenumber;
            Isdefault = isdefault;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynKmfederatedsearchconfigSyncErrors = msdynKmfederatedsearchconfigSyncErrors;
            MsdynKmfederatedsearchconfigDuplicateMatchingRecord = msdynKmfederatedsearchconfigDuplicateMatchingRecord;
            MsdynKmfederatedsearchconfigDuplicateBaseRecord = msdynKmfederatedsearchconfigDuplicateBaseRecord;
            MsdynKmfederatedsearchconfigAsyncOperations = msdynKmfederatedsearchconfigAsyncOperations;
            MsdynKmfederatedsearchconfigMailboxTrackingFolders = msdynKmfederatedsearchconfigMailboxTrackingFolders;
            MsdynKmfederatedsearchconfigProcessSession = msdynKmfederatedsearchconfigProcessSession;
            MsdynKmfederatedsearchconfigBulkDeleteFailures = msdynKmfederatedsearchconfigBulkDeleteFailures;
            MsdynKmfederatedsearchconfigPrincipalObjectAttributeAccesses = msdynKmfederatedsearchconfigPrincipalObjectAttributeAccesses;
            IKMsdynKmfederatedsearchconfigMsdynFederatedarticleSearchproviderid = iKMsdynKmfederatedsearchconfigMsdynFederatedarticleSearchproviderid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionid")]
        public string Connectionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharepointurl")]
        public string Sharepointurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public string Organization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "searchtype")]
        public int? Searchtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_description")]
        public string MsdynDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfigid")]
        public string MsdynKmfederatedsearchconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynKmfederatedsearchconfigSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynKmfederatedsearchconfigDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynKmfederatedsearchconfigDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynKmfederatedsearchconfigAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynKmfederatedsearchconfigMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynKmfederatedsearchconfigProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynKmfederatedsearchconfigBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynKmfederatedsearchconfigPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid")]
        public IList<MicrosoftDynamicsCRMmsdynFederatedarticle> IKMsdynKmfederatedsearchconfigMsdynFederatedarticleSearchproviderid { get; set; }

    }
}
