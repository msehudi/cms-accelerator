// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRM.Interface.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.sitemap
    /// </summary>
    public partial class MicrosoftDynamicsCRMsitemap
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsitemap
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsitemap()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsitemap
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsitemap(bool? showpinned = default(bool?), bool? enablecollapsiblegroups = default(bool?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string sitemapxmlmanaged = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string sitemapnameunique = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? componentstate = default(int?), string sitemapxml = default(string), string versionnumber = default(string), bool? ismanaged = default(bool?), string sitemapidunique = default(string), string sitemapid = default(string), string _organizationidValue = default(string), bool? showhome = default(bool?), string solutionid = default(string), bool? isappaware = default(bool?), string sitemapname = default(string), bool? showrecents = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser siteMapModifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser siteMapModifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser siteMapCreatedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser siteMapCreatedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Showpinned = showpinned;
            Enablecollapsiblegroups = enablecollapsiblegroups;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Sitemapxmlmanaged = sitemapxmlmanaged;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Sitemapnameunique = sitemapnameunique;
            Overwritetime = overwritetime;
            Componentstate = componentstate;
            Sitemapxml = sitemapxml;
            Versionnumber = versionnumber;
            Ismanaged = ismanaged;
            Sitemapidunique = sitemapidunique;
            Sitemapid = sitemapid;
            this._organizationidValue = _organizationidValue;
            Showhome = showhome;
            Solutionid = solutionid;
            Isappaware = isappaware;
            Sitemapname = sitemapname;
            Showrecents = showrecents;
            Modifiedon = modifiedon;
            SiteMapModifiedonbehalfby = siteMapModifiedonbehalfby;
            SiteMapModifiedby = siteMapModifiedby;
            SiteMapCreatedonbehalfby = siteMapCreatedonbehalfby;
            Organizationid = organizationid;
            SiteMapCreatedby = siteMapCreatedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "showpinned")]
        public bool? Showpinned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enablecollapsiblegroups")]
        public bool? Enablecollapsiblegroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitemapxmlmanaged")]
        public string Sitemapxmlmanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitemapnameunique")]
        public string Sitemapnameunique { get; set; }

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
        [JsonProperty(PropertyName = "sitemapxml")]
        public string Sitemapxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitemapidunique")]
        public string Sitemapidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitemapid")]
        public string Sitemapid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "showhome")]
        public bool? Showhome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isappaware")]
        public bool? Isappaware { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitemapname")]
        public string Sitemapname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "showrecents")]
        public bool? Showrecents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SiteMap_modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser SiteMapModifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SiteMap_modifiedby")]
        public MicrosoftDynamicsCRMsystemuser SiteMapModifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SiteMap_createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser SiteMapCreatedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SiteMap_createdby")]
        public MicrosoftDynamicsCRMsystemuser SiteMapCreatedby { get; set; }

    }
}
