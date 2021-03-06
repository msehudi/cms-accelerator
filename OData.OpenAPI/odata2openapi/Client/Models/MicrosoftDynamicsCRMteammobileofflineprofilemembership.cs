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
    /// Microsoft.Dynamics.CRM.teammobileofflineprofilemembership
    /// </summary>
    public partial class MicrosoftDynamicsCRMteammobileofflineprofilemembership
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMteammobileofflineprofilemembership class.
        /// </summary>
        public MicrosoftDynamicsCRMteammobileofflineprofilemembership()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMteammobileofflineprofilemembership class.
        /// </summary>
        public MicrosoftDynamicsCRMteammobileofflineprofilemembership(int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), string name = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string teammobileofflineprofilemembershipid = default(string), string _modifiedonbehalfbyValue = default(string), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), string versionnumber = default(string), int? statuscode = default(int?), string _teamidValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _mobileofflineprofileidValue = default(string), string _organizationidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> teammobileofflineprofilemembershipSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> teammobileofflineprofilemembershipAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> teammobileofflineprofilemembershipMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> teammobileofflineprofilemembershipProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> teammobileofflineprofilemembershipBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> teammobileofflineprofilemembershipPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMmobileofflineprofile mobileOfflineProfileId = default(MicrosoftDynamicsCRMmobileofflineprofile), MicrosoftDynamicsCRMteam teamId = default(MicrosoftDynamicsCRMteam))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            Name = name;
            Createdon = createdon;
            Teammobileofflineprofilemembershipid = teammobileofflineprofilemembershipid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            Statuscode = statuscode;
            this._teamidValue = _teamidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._mobileofflineprofileidValue = _mobileofflineprofileidValue;
            this._organizationidValue = _organizationidValue;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            TeammobileofflineprofilemembershipSyncErrors = teammobileofflineprofilemembershipSyncErrors;
            TeammobileofflineprofilemembershipAsyncOperations = teammobileofflineprofilemembershipAsyncOperations;
            TeammobileofflineprofilemembershipMailboxTrackingFolders = teammobileofflineprofilemembershipMailboxTrackingFolders;
            TeammobileofflineprofilemembershipProcessSession = teammobileofflineprofilemembershipProcessSession;
            TeammobileofflineprofilemembershipBulkDeleteFailures = teammobileofflineprofilemembershipBulkDeleteFailures;
            TeammobileofflineprofilemembershipPrincipalObjectAttributeAccesses = teammobileofflineprofilemembershipPrincipalObjectAttributeAccesses;
            MobileOfflineProfileId = mobileOfflineProfileId;
            TeamId = teamId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teammobileofflineprofilemembershipid")]
        public string Teammobileofflineprofilemembershipid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_teamid_value")]
        public string _teamidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_mobileofflineprofileid_value")]
        public string _mobileofflineprofileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

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
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teammobileofflineprofilemembership_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TeammobileofflineprofilemembershipSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teammobileofflineprofilemembership_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> TeammobileofflineprofilemembershipAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teammobileofflineprofilemembership_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> TeammobileofflineprofilemembershipMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teammobileofflineprofilemembership_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> TeammobileofflineprofilemembershipProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teammobileofflineprofilemembership_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> TeammobileofflineprofilemembershipBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teammobileofflineprofilemembership_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> TeammobileofflineprofilemembershipPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineProfileId")]
        public MicrosoftDynamicsCRMmobileofflineprofile MobileOfflineProfileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TeamId")]
        public MicrosoftDynamicsCRMteam TeamId { get; set; }

    }
}
