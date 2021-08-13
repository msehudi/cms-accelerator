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
    /// Microsoft.Dynamics.CRM.catalogassignment
    /// </summary>
    public partial class MicrosoftDynamicsCRMcatalogassignment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcatalogassignment class.
        /// </summary>
        public MicrosoftDynamicsCRMcatalogassignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcatalogassignment class.
        /// </summary>
        public MicrosoftDynamicsCRMcatalogassignment(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string componentidunique = default(string), string _createdbyValue = default(string), string _objectValue = default(string), bool? ismanaged = default(bool?), int? statecode = default(int?), string _organizationidValue = default(string), string _modifiedonbehalfbyValue = default(string), int? statuscode = default(int?), string solutionid = default(string), string _createdonbehalfbyValue = default(string), string name = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string iscustomizable = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _catalogidValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? componentstate = default(int?), string catalogassignmentid = default(string), string versionnumber = default(string), int? utcconversiontimezonecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> catalogassignmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> catalogassignmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> catalogassignmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> catalogassignmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> catalogassignmentMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> catalogassignmentProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> catalogassignmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> catalogassignmentPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMworkflow workflowId = default(MicrosoftDynamicsCRMworkflow), MicrosoftDynamicsCRMcatalog catalogId = default(MicrosoftDynamicsCRMcatalog), MicrosoftDynamicsCRMentity entityId = default(MicrosoftDynamicsCRMentity), MicrosoftDynamicsCRMcustomapi customAPIId = default(MicrosoftDynamicsCRMcustomapi))
        {
            Overriddencreatedon = overriddencreatedon;
            Componentidunique = componentidunique;
            this._createdbyValue = _createdbyValue;
            this._objectValue = _objectValue;
            Ismanaged = ismanaged;
            Statecode = statecode;
            this._organizationidValue = _organizationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statuscode = statuscode;
            Solutionid = solutionid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Name = name;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Iscustomizable = iscustomizable;
            Importsequencenumber = importsequencenumber;
            Createdon = createdon;
            this._catalogidValue = _catalogidValue;
            Overwritetime = overwritetime;
            Componentstate = componentstate;
            Catalogassignmentid = catalogassignmentid;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            CatalogassignmentSyncErrors = catalogassignmentSyncErrors;
            CatalogassignmentDuplicateMatchingRecord = catalogassignmentDuplicateMatchingRecord;
            CatalogassignmentDuplicateBaseRecord = catalogassignmentDuplicateBaseRecord;
            CatalogassignmentAsyncOperations = catalogassignmentAsyncOperations;
            CatalogassignmentMailboxTrackingFolders = catalogassignmentMailboxTrackingFolders;
            CatalogassignmentProcessSession = catalogassignmentProcessSession;
            CatalogassignmentBulkDeleteFailures = catalogassignmentBulkDeleteFailures;
            CatalogassignmentPrincipalObjectAttributeAccesses = catalogassignmentPrincipalObjectAttributeAccesses;
            WorkflowId = workflowId;
            CatalogId = catalogId;
            EntityId = entityId;
            CustomAPIId = customAPIId;
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
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_object_value")]
        public string _objectValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

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
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_catalogid_value")]
        public string _catalogidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignmentid")]
        public string Catalogassignmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "catalogassignment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CatalogassignmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CatalogassignmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CatalogassignmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CatalogassignmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignment_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CatalogassignmentMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignment_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CatalogassignmentProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CatalogassignmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogassignment_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CatalogassignmentPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WorkflowId")]
        public MicrosoftDynamicsCRMworkflow WorkflowId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CatalogId")]
        public MicrosoftDynamicsCRMcatalog CatalogId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityId")]
        public MicrosoftDynamicsCRMentity EntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomAPIId")]
        public MicrosoftDynamicsCRMcustomapi CustomAPIId { get; set; }

    }
}