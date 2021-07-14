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
    /// Microsoft.Dynamics.CRM.flowsession
    /// </summary>
    public partial class MicrosoftDynamicsCRMflowsession
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMflowsession
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMflowsession()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMflowsession
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMflowsession(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string processversion = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), byte[] additionalcontext = default(byte[]), string _owninguserValue = default(string), string context = default(string), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), string _machinegroupidValue = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string name = default(string), int? statuscode = default(int?), string _machineidValue = default(string), string correlationid = default(string), System.DateTimeOffset? startedon = default(System.DateTimeOffset?), string gateway = default(string), string additionalcontextName = default(string), string _modifiedbyValue = default(string), string errormessage = default(string), int? utcconversiontimezonecode = default(int?), string flowsessionid = default(string), string outputsName = default(string), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string errorcode = default(string), string _createdbyValue = default(string), string _owneridValue = default(string), string versionnumber = default(string), byte[] outputs = default(byte[]), string _owningteamValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), int? statecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> flowsessionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> flowsessionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> flowsessionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> flowsessionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> flowsessionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMfileattachment> flowsessionFileAttachments = default(IList<MicrosoftDynamicsCRMfileattachment>), IList<MicrosoftDynamicsCRMworkflowbinary> flowsessionWorkflowbinaryFlowSessionId = default(IList<MicrosoftDynamicsCRMworkflowbinary>), MicrosoftDynamicsCRMworkflow regardingobjectidProcess = default(MicrosoftDynamicsCRMworkflow), MicrosoftDynamicsCRMflowmachine machineId = default(MicrosoftDynamicsCRMflowmachine), MicrosoftDynamicsCRMflowmachinegroup machineGroupId = default(MicrosoftDynamicsCRMflowmachinegroup))
        {
            Createdon = createdon;
            Processversion = processversion;
            Overriddencreatedon = overriddencreatedon;
            Additionalcontext = additionalcontext;
            this._owninguserValue = _owninguserValue;
            Context = context;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._machinegroupidValue = _machinegroupidValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            Modifiedon = modifiedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Name = name;
            Statuscode = statuscode;
            this._machineidValue = _machineidValue;
            Correlationid = correlationid;
            Startedon = startedon;
            Gateway = gateway;
            AdditionalcontextName = additionalcontextName;
            this._modifiedbyValue = _modifiedbyValue;
            Errormessage = errormessage;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Flowsessionid = flowsessionid;
            OutputsName = outputsName;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Errorcode = errorcode;
            this._createdbyValue = _createdbyValue;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            Outputs = outputs;
            this._owningteamValue = _owningteamValue;
            Completedon = completedon;
            Statecode = statecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            FlowsessionSyncErrors = flowsessionSyncErrors;
            FlowsessionAsyncOperations = flowsessionAsyncOperations;
            FlowsessionMailboxTrackingFolders = flowsessionMailboxTrackingFolders;
            FlowsessionBulkDeleteFailures = flowsessionBulkDeleteFailures;
            FlowsessionPrincipalObjectAttributeAccesses = flowsessionPrincipalObjectAttributeAccesses;
            FlowsessionFileAttachments = flowsessionFileAttachments;
            FlowsessionWorkflowbinaryFlowSessionId = flowsessionWorkflowbinaryFlowSessionId;
            RegardingobjectidProcess = regardingobjectidProcess;
            MachineId = machineId;
            MachineGroupId = machineGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processversion")]
        public string Processversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "additionalcontext")]
        public byte[] Additionalcontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_machinegroupid_value")]
        public string _machinegroupidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_machineid_value")]
        public string _machineidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "correlationid")]
        public string Correlationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startedon")]
        public System.DateTimeOffset? Startedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalcontext_name")]
        public string AdditionalcontextName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errormessage")]
        public string Errormessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowsessionid")]
        public string Flowsessionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outputs_name")]
        public string OutputsName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorcode")]
        public string Errorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "outputs")]
        public byte[] Outputs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

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
        [JsonProperty(PropertyName = "flowsession_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FlowsessionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowsession_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> FlowsessionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowsession_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> FlowsessionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowsession_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> FlowsessionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowsession_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> FlowsessionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowsession_FileAttachments")]
        public IList<MicrosoftDynamicsCRMfileattachment> FlowsessionFileAttachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowsession_workflowbinary_FlowSessionId")]
        public IList<MicrosoftDynamicsCRMworkflowbinary> FlowsessionWorkflowbinaryFlowSessionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_process")]
        public MicrosoftDynamicsCRMworkflow RegardingobjectidProcess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MachineId")]
        public MicrosoftDynamicsCRMflowmachine MachineId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MachineGroupId")]
        public MicrosoftDynamicsCRMflowmachinegroup MachineGroupId { get; set; }

    }
}
