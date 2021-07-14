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
    /// Microsoft.Dynamics.CRM.rollupfield
    /// </summary>
    public partial class MicrosoftDynamicsCRMrollupfield
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrollupfield
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMrollupfield()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrollupfield
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMrollupfield(string goalattribute = default(string), string _metricidValue = default(string), string rollupfieldid = default(string), string sourceattribute = default(string), string _createdbyValue = default(string), bool? isstateparententityattribute = default(bool?), int? utcconversiontimezonecode = default(int?), int? sourcestatus = default(int?), string versionnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? sourcestate = default(int?), string dateattribute = default(string), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string sourceentity = default(string), int? timezoneruleversionnumber = default(int?), string entityfordateattribute = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMmetric metricid = default(MicrosoftDynamicsCRMmetric), IList<MicrosoftDynamicsCRMprocesssession> rollupfieldProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMasyncoperation> rollupfieldAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsyncerror> rollupFieldSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Goalattribute = goalattribute;
            this._metricidValue = _metricidValue;
            Rollupfieldid = rollupfieldid;
            Sourceattribute = sourceattribute;
            this._createdbyValue = _createdbyValue;
            Isstateparententityattribute = isstateparententityattribute;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Sourcestatus = sourcestatus;
            Versionnumber = versionnumber;
            Createdon = createdon;
            Sourcestate = sourcestate;
            Dateattribute = dateattribute;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            Sourceentity = sourceentity;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Entityfordateattribute = entityfordateattribute;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Metricid = metricid;
            RollupfieldProcessSessions = rollupfieldProcessSessions;
            RollupfieldAsyncOperations = rollupfieldAsyncOperations;
            RollupFieldSyncErrors = rollupFieldSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalattribute")]
        public string Goalattribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_metricid_value")]
        public string _metricidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupfieldid")]
        public string Rollupfieldid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceattribute")]
        public string Sourceattribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isstateparententityattribute")]
        public bool? Isstateparententityattribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcestatus")]
        public int? Sourcestatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcestate")]
        public int? Sourcestate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateattribute")]
        public string Dateattribute { get; set; }

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
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceentity")]
        public string Sourceentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityfordateattribute")]
        public string Entityfordateattribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

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
        [JsonProperty(PropertyName = "metricid")]
        public MicrosoftDynamicsCRMmetric Metricid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupfield_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> RollupfieldProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rollupfield_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RollupfieldAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RollupField_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RollupFieldSyncErrors { get; set; }

    }
}
