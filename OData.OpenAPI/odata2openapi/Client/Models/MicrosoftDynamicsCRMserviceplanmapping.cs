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
    /// Microsoft.Dynamics.CRM.serviceplanmapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMserviceplanmapping
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceplanmapping class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceplanmapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceplanmapping class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceplanmapping(string solutionid = default(string), string _serviceplanValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), int? importsequencenumber = default(int?), string iscustomizable = default(string), string name = default(string), string versionnumber = default(string), string _sdkmessageValue = default(string), bool? ismanaged = default(bool?), int? componentstate = default(int?), int? utcconversiontimezonecode = default(int?), string _entityValue = default(string), string componentidunique = default(string), string _modifiedbyValue = default(string), string featurecontrol = default(string), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string serviceplanmappingid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> serviceplanmappingSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> serviceplanmappingDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> serviceplanmappingDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> serviceplanmappingAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> serviceplanmappingMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> serviceplanmappingProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> serviceplanmappingBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> serviceplanmappingPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMentity entity = default(MicrosoftDynamicsCRMentity), MicrosoftDynamicsCRMsdkmessage sdkMessage = default(MicrosoftDynamicsCRMsdkmessage), MicrosoftDynamicsCRMserviceplan servicePlan = default(MicrosoftDynamicsCRMserviceplan))
        {
            Solutionid = solutionid;
            this._serviceplanValue = _serviceplanValue;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            Modifiedon = modifiedon;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            Iscustomizable = iscustomizable;
            Name = name;
            Versionnumber = versionnumber;
            this._sdkmessageValue = _sdkmessageValue;
            Ismanaged = ismanaged;
            Componentstate = componentstate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._entityValue = _entityValue;
            Componentidunique = componentidunique;
            this._modifiedbyValue = _modifiedbyValue;
            Featurecontrol = featurecontrol;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Serviceplanmappingid = serviceplanmappingid;
            Overwritetime = overwritetime;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            ServiceplanmappingSyncErrors = serviceplanmappingSyncErrors;
            ServiceplanmappingDuplicateMatchingRecord = serviceplanmappingDuplicateMatchingRecord;
            ServiceplanmappingDuplicateBaseRecord = serviceplanmappingDuplicateBaseRecord;
            ServiceplanmappingAsyncOperations = serviceplanmappingAsyncOperations;
            ServiceplanmappingMailboxTrackingFolders = serviceplanmappingMailboxTrackingFolders;
            ServiceplanmappingProcessSession = serviceplanmappingProcessSession;
            ServiceplanmappingBulkDeleteFailures = serviceplanmappingBulkDeleteFailures;
            ServiceplanmappingPrincipalObjectAttributeAccesses = serviceplanmappingPrincipalObjectAttributeAccesses;
            Entity = entity;
            SdkMessage = sdkMessage;
            ServicePlan = servicePlan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_serviceplan_value")]
        public string _serviceplanValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

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
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessage_value")]
        public string _sdkmessageValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_entity_value")]
        public string _entityValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "featurecontrol")]
        public string Featurecontrol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

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
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmappingid")]
        public string Serviceplanmappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

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
        [JsonProperty(PropertyName = "serviceplanmapping_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ServiceplanmappingSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmapping_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ServiceplanmappingDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmapping_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ServiceplanmappingDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmapping_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ServiceplanmappingAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmapping_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ServiceplanmappingMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmapping_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> ServiceplanmappingProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmapping_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ServiceplanmappingBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplanmapping_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ServiceplanmappingPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity")]
        public MicrosoftDynamicsCRMentity Entity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SdkMessage")]
        public MicrosoftDynamicsCRMsdkmessage SdkMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServicePlan")]
        public MicrosoftDynamicsCRMserviceplan ServicePlan { get; set; }

    }
}
