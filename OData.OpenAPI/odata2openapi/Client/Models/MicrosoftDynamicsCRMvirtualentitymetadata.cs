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
    /// Microsoft.Dynamics.CRM.virtualentitymetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMvirtualentitymetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMvirtualentitymetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMvirtualentitymetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMvirtualentitymetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMvirtualentitymetadata(string versionnumber = default(string), bool? isonexternalupdatedenabled = default(bool?), int? importsequencenumber = default(int?), string name = default(string), bool? ismanaged = default(bool?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statecode = default(int?), string componentidunique = default(string), int? componentstate = default(int?), string solutionid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), int? utcconversiontimezonecode = default(int?), string _extensionofrecordidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string _createdonbehalfbyValue = default(string), bool? isonexternalcreatedenabled = default(bool?), bool? isonexternaldeletedenabled = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string virtualentitymetadataid = default(string), string iscustomizable = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> virtualentitymetadataSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> virtualentitymetadataAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> virtualentitymetadataMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> virtualentitymetadataProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> virtualentitymetadataBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> virtualentitymetadataPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMentity extensionofrecordid = default(MicrosoftDynamicsCRMentity))
        {
            Versionnumber = versionnumber;
            Isonexternalupdatedenabled = isonexternalupdatedenabled;
            Importsequencenumber = importsequencenumber;
            Name = name;
            Ismanaged = ismanaged;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Statecode = statecode;
            Componentidunique = componentidunique;
            Componentstate = componentstate;
            Solutionid = solutionid;
            Overwritetime = overwritetime;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._extensionofrecordidValue = _extensionofrecordidValue;
            Overriddencreatedon = overriddencreatedon;
            this._organizationidValue = _organizationidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Isonexternalcreatedenabled = isonexternalcreatedenabled;
            Isonexternaldeletedenabled = isonexternaldeletedenabled;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Virtualentitymetadataid = virtualentitymetadataid;
            Iscustomizable = iscustomizable;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            VirtualentitymetadataSyncErrors = virtualentitymetadataSyncErrors;
            VirtualentitymetadataAsyncOperations = virtualentitymetadataAsyncOperations;
            VirtualentitymetadataMailboxTrackingFolders = virtualentitymetadataMailboxTrackingFolders;
            VirtualentitymetadataProcessSession = virtualentitymetadataProcessSession;
            VirtualentitymetadataBulkDeleteFailures = virtualentitymetadataBulkDeleteFailures;
            VirtualentitymetadataPrincipalObjectAttributeAccesses = virtualentitymetadataPrincipalObjectAttributeAccesses;
            Extensionofrecordid = extensionofrecordid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isonexternalupdatedenabled")]
        public bool? Isonexternalupdatedenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

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
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_extensionofrecordid_value")]
        public string _extensionofrecordidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isonexternalcreatedenabled")]
        public bool? Isonexternalcreatedenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isonexternaldeletedenabled")]
        public bool? Isonexternaldeletedenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadataid")]
        public string Virtualentitymetadataid { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadata_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> VirtualentitymetadataSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadata_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> VirtualentitymetadataAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadata_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> VirtualentitymetadataMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadata_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> VirtualentitymetadataProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadata_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> VirtualentitymetadataBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadata_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> VirtualentitymetadataPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extensionofrecordid")]
        public MicrosoftDynamicsCRMentity Extensionofrecordid { get; set; }

    }
}
