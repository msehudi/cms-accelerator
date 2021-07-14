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
    /// Microsoft.Dynamics.CRM.entity
    /// </summary>
    public partial class MicrosoftDynamicsCRMentity
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMentity class.
        /// </summary>
        public MicrosoftDynamicsCRMentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMentity class.
        /// </summary>
        public MicrosoftDynamicsCRMentity(string logicalcollectionname = default(string), string parentcontrollingattributename = default(string), string versionnumber = default(string), string externalcollectionname = default(string), string originallocalizedname = default(string), string extensiontablename = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string name = default(string), string physicalname = default(string), string entitysetname = default(string), string basetablename = default(string), string originallocalizedcollectionname = default(string), string collectionname = default(string), string logicalname = default(string), string externalname = default(string), string reportviewname = default(string), string addresstablename = default(string), int? componentstate = default(int?), string entityid = default(string), string solutionid = default(string), IList<MicrosoftDynamicsCRMsolutioncomponentconfiguration> entitySolutioncomponentconfiguration = default(IList<MicrosoftDynamicsCRMsolutioncomponentconfiguration>), IList<MicrosoftDynamicsCRMentityanalyticsconfig> entityEntityanalyticsconfig = default(IList<MicrosoftDynamicsCRMentityanalyticsconfig>), IList<MicrosoftDynamicsCRMcatalogassignment> catalogAssignments = default(IList<MicrosoftDynamicsCRMcatalogassignment>), IList<MicrosoftDynamicsCRMvirtualentitymetadata> virtualentitymetadataExtensionofrecordid = default(IList<MicrosoftDynamicsCRMvirtualentitymetadata>), IList<MicrosoftDynamicsCRMsolutioncomponentbatchconfiguration> entitySolutioncomponentbatchconfigurationPrimaryEntity = default(IList<MicrosoftDynamicsCRMsolutioncomponentbatchconfiguration>), IList<MicrosoftDynamicsCRMsolutioncomponentbatchconfiguration> entitySolutioncomponentbatchconfigurationRelatedEntity = default(IList<MicrosoftDynamicsCRMsolutioncomponentbatchconfiguration>), IList<MicrosoftDynamicsCRMserviceplanmapping> entityServiceplanmapping = default(IList<MicrosoftDynamicsCRMserviceplanmapping>), IList<MicrosoftDynamicsCRMappaction> entityAppactionContextEntity = default(IList<MicrosoftDynamicsCRMappaction>))
        {
            Logicalcollectionname = logicalcollectionname;
            Parentcontrollingattributename = parentcontrollingattributename;
            Versionnumber = versionnumber;
            Externalcollectionname = externalcollectionname;
            Originallocalizedname = originallocalizedname;
            Extensiontablename = extensiontablename;
            Overwritetime = overwritetime;
            Name = name;
            Physicalname = physicalname;
            Entitysetname = entitysetname;
            Basetablename = basetablename;
            Originallocalizedcollectionname = originallocalizedcollectionname;
            Collectionname = collectionname;
            Logicalname = logicalname;
            Externalname = externalname;
            Reportviewname = reportviewname;
            Addresstablename = addresstablename;
            Componentstate = componentstate;
            Entityid = entityid;
            Solutionid = solutionid;
            EntitySolutioncomponentconfiguration = entitySolutioncomponentconfiguration;
            EntityEntityanalyticsconfig = entityEntityanalyticsconfig;
            CatalogAssignments = catalogAssignments;
            VirtualentitymetadataExtensionofrecordid = virtualentitymetadataExtensionofrecordid;
            EntitySolutioncomponentbatchconfigurationPrimaryEntity = entitySolutioncomponentbatchconfigurationPrimaryEntity;
            EntitySolutioncomponentbatchconfigurationRelatedEntity = entitySolutioncomponentbatchconfigurationRelatedEntity;
            EntityServiceplanmapping = entityServiceplanmapping;
            EntityAppactionContextEntity = entityAppactionContextEntity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logicalcollectionname")]
        public string Logicalcollectionname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentcontrollingattributename")]
        public string Parentcontrollingattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "externalcollectionname")]
        public string Externalcollectionname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originallocalizedname")]
        public string Originallocalizedname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extensiontablename")]
        public string Extensiontablename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "physicalname")]
        public string Physicalname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitysetname")]
        public string Entitysetname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "basetablename")]
        public string Basetablename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originallocalizedcollectionname")]
        public string Originallocalizedcollectionname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "collectionname")]
        public string Collectionname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logicalname")]
        public string Logicalname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "externalname")]
        public string Externalname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reportviewname")]
        public string Reportviewname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addresstablename")]
        public string Addresstablename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityid")]
        public string Entityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity_solutioncomponentconfiguration")]
        public IList<MicrosoftDynamicsCRMsolutioncomponentconfiguration> EntitySolutioncomponentconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity_entityanalyticsconfig")]
        public IList<MicrosoftDynamicsCRMentityanalyticsconfig> EntityEntityanalyticsconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CatalogAssignments")]
        public IList<MicrosoftDynamicsCRMcatalogassignment> CatalogAssignments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualentitymetadata_extensionofrecordid")]
        public IList<MicrosoftDynamicsCRMvirtualentitymetadata> VirtualentitymetadataExtensionofrecordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity_solutioncomponentbatchconfiguration_PrimaryEntity")]
        public IList<MicrosoftDynamicsCRMsolutioncomponentbatchconfiguration> EntitySolutioncomponentbatchconfigurationPrimaryEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity_solutioncomponentbatchconfiguration_RelatedEntity")]
        public IList<MicrosoftDynamicsCRMsolutioncomponentbatchconfiguration> EntitySolutioncomponentbatchconfigurationRelatedEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity_serviceplanmapping")]
        public IList<MicrosoftDynamicsCRMserviceplanmapping> EntityServiceplanmapping { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity_appaction_ContextEntity")]
        public IList<MicrosoftDynamicsCRMappaction> EntityAppactionContextEntity { get; set; }

    }
}
