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
    /// Microsoft.Dynamics.CRM.systemform
    /// </summary>
    public partial class MicrosoftDynamicsCRMsystemform
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsystemform
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemform()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsystemform
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemform(int? version = default(int?), string formjson = default(string), int? formactivationstate = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string canbedeleted = default(string), int? componentstate = default(int?), string _organizationidValue = default(string), string solutionid = default(string), string description = default(string), bool? istabletenabled = default(bool?), string uniquename = default(string), string introducedversion = default(string), bool? isdefault = default(bool?), string objecttypecode = default(string), bool? ismanaged = default(bool?), string versionnumber = default(string), string formidunique = default(string), int? formpresentation = default(int?), string formid = default(string), string name = default(string), int? type = default(int?), string formxml = default(string), bool? isdesktopenabled = default(bool?), string iscustomizable = default(string), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), string _ancestorformidValue = default(string), bool? isairmerged = default(bool?), IList<MicrosoftDynamicsCRMasyncoperation> systemFormAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesstrigger> processtriggerSystemform = default(IList<MicrosoftDynamicsCRMprocesstrigger>), IList<MicrosoftDynamicsCRMbulkdeletefailure> systemFormBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemform ancestorformid = default(MicrosoftDynamicsCRMsystemform), IList<MicrosoftDynamicsCRMsystemform> formAncestorForm = default(IList<MicrosoftDynamicsCRMsystemform>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization))
        {
            Version = version;
            Formjson = formjson;
            Formactivationstate = formactivationstate;
            Overwritetime = overwritetime;
            Canbedeleted = canbedeleted;
            Componentstate = componentstate;
            this._organizationidValue = _organizationidValue;
            Solutionid = solutionid;
            Description = description;
            Istabletenabled = istabletenabled;
            Uniquename = uniquename;
            Introducedversion = introducedversion;
            Isdefault = isdefault;
            Objecttypecode = objecttypecode;
            Ismanaged = ismanaged;
            Versionnumber = versionnumber;
            Formidunique = formidunique;
            Formpresentation = formpresentation;
            Formid = formid;
            Name = name;
            Type = type;
            Formxml = formxml;
            Isdesktopenabled = isdesktopenabled;
            Iscustomizable = iscustomizable;
            Publishedon = publishedon;
            this._ancestorformidValue = _ancestorformidValue;
            Isairmerged = isairmerged;
            SystemFormAsyncOperations = systemFormAsyncOperations;
            ProcesstriggerSystemform = processtriggerSystemform;
            SystemFormBulkDeleteFailures = systemFormBulkDeleteFailures;
            Ancestorformid = ancestorformid;
            FormAncestorForm = formAncestorForm;
            Organizationid = organizationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formjson")]
        public string Formjson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formactivationstate")]
        public int? Formactivationstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public string Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "istabletenabled")]
        public bool? Istabletenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formidunique")]
        public string Formidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formpresentation")]
        public int? Formpresentation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formid")]
        public string Formid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formxml")]
        public string Formxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdesktopenabled")]
        public bool? Isdesktopenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ancestorformid_value")]
        public string _ancestorformidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isairmerged")]
        public bool? Isairmerged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SystemForm_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SystemFormAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processtrigger_systemform")]
        public IList<MicrosoftDynamicsCRMprocesstrigger> ProcesstriggerSystemform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SystemForm_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SystemFormBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ancestorformid")]
        public MicrosoftDynamicsCRMsystemform Ancestorformid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "form_ancestor_form")]
        public IList<MicrosoftDynamicsCRMsystemform> FormAncestorForm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

    }
}
