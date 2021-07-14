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
    /// Microsoft.Dynamics.CRM.emailserverprofile
    /// </summary>
    public partial class MicrosoftDynamicsCRMemailserverprofile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMemailserverprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMemailserverprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMemailserverprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMemailserverprofile(string _keyvaultreferenceidValue = default(string), string oauthclientsecret = default(string), int? statuscode = default(int?), string _incomingpartnerapplicationValue = default(string), int? incomingauthenticationprotocol = default(int?), string name = default(string), bool? isoauthclientsecretset = default(bool?), string _createdonbehalfbyValue = default(string), bool? usedefaulttenantid = default(bool?), bool? isincomingpasswordset = default(bool?), string incomingpassword = default(string), string lasttestresponse = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string outgoingserverlocation = default(string), bool? moveundeliveredemails = default(bool?), string outgoingpassword = default(string), int? incomingcredentialretrieval = default(int?), int? incomingportnumber = default(int?), string encodingcodepage = default(string), bool? sendemailalert = default(bool?), System.DateTimeOffset? lastteststarttime = default(System.DateTimeOffset?), string entityimageUrl = default(string), byte[] entityimage = default(byte[]), string _owneridValue = default(string), long? lasttesttotalexecutiontime = default(long?), System.DateTimeOffset? processemailsreceivedafter = default(System.DateTimeOffset?), int? outgoingauthenticationprotocol = default(int?), bool? usesamesettingsforoutgoingconnections = default(bool?), string _owningbusinessunitValue = default(string), int? utcconversiontimezonecode = default(int?), string oauthclientid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string aadresourceid = default(string), bool? outgoingautograntdelegateaccess = default(bool?), string _managedidentityidValue = default(string), int? maxconcurrentconnections = default(int?), string owneremailaddress = default(string), int? outgoingportnumber = default(int?), bool? outgoingusessl = default(bool?), bool? incomingusessl = default(bool?), int? outgoingcredentialretrieval = default(int?), string _owningteamValue = default(string), string lasttestrequest = default(string), string versionnumber = default(string), long? entityimageTimestamp = default(long?), bool? useautodiscover = default(bool?), int? timezoneruleversionnumber = default(int?), int? exchangeversion = default(int?), string emailserverprofileid = default(string), string _organizationidValue = default(string), int? timeoutmailboxconnectionafteramount = default(int?), int? minpollingintervalinminutes = default(int?), string _modifiedonbehalfbyValue = default(string), string _outgoingpartnerapplicationValue = default(string), bool? incominguseimpersonation = default(bool?), string description = default(string), string lastcrmmessage = default(string), bool? isoutgoingpasswordset = default(bool?), string incomingserverlocation = default(string), int? lasttestvalidationstatus = default(int?), int? lasttestexecutionstatus = default(int?), string exchangeonlinetenantid = default(string), string entityimageid = default(string), int? lastauthorizationstatus = default(int?), string defaultserverlocation = default(string), string emailservertypename = default(string), string incomingusername = default(string), bool? outgoinguseimpersonation = default(bool?), bool? timeoutmailboxconnection = default(bool?), int? statecode = default(int?), string outgoingusername = default(string), string _owninguserValue = default(string), string _createdbyValue = default(string), int? servertype = default(int?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMmailbox> emailserverprofileMailbox = default(IList<MicrosoftDynamicsCRMmailbox>), IList<MicrosoftDynamicsCRMasyncoperation> emailserverprofileAsyncoperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMbulkdeletefailure> emailserverprofileBulkdeletefailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMorganization> emailServerProfileOrganization = default(IList<MicrosoftDynamicsCRMorganization>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMtracelog> tracelogEmailServerProfile = default(IList<MicrosoftDynamicsCRMtracelog>), IList<MicrosoftDynamicsCRMannotation> emailServerProfileAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMduplicaterecord> emailserverprofileDuplicatematchingrecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> emailServerProfileSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> emailserverprofileDuplicatebaserecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMkeyvaultreference keyvaultreferenceid = default(MicrosoftDynamicsCRMkeyvaultreference), MicrosoftDynamicsCRMmanagedidentity managedidentityid = default(MicrosoftDynamicsCRMmanagedidentity))
        {
            this._keyvaultreferenceidValue = _keyvaultreferenceidValue;
            Oauthclientsecret = oauthclientsecret;
            Statuscode = statuscode;
            this._incomingpartnerapplicationValue = _incomingpartnerapplicationValue;
            Incomingauthenticationprotocol = incomingauthenticationprotocol;
            Name = name;
            Isoauthclientsecretset = isoauthclientsecretset;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Usedefaulttenantid = usedefaulttenantid;
            Isincomingpasswordset = isincomingpasswordset;
            Incomingpassword = incomingpassword;
            Lasttestresponse = lasttestresponse;
            Modifiedon = modifiedon;
            Outgoingserverlocation = outgoingserverlocation;
            Moveundeliveredemails = moveundeliveredemails;
            Outgoingpassword = outgoingpassword;
            Incomingcredentialretrieval = incomingcredentialretrieval;
            Incomingportnumber = incomingportnumber;
            Encodingcodepage = encodingcodepage;
            Sendemailalert = sendemailalert;
            Lastteststarttime = lastteststarttime;
            EntityimageUrl = entityimageUrl;
            Entityimage = entityimage;
            this._owneridValue = _owneridValue;
            Lasttesttotalexecutiontime = lasttesttotalexecutiontime;
            Processemailsreceivedafter = processemailsreceivedafter;
            Outgoingauthenticationprotocol = outgoingauthenticationprotocol;
            Usesamesettingsforoutgoingconnections = usesamesettingsforoutgoingconnections;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Oauthclientid = oauthclientid;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            Aadresourceid = aadresourceid;
            Outgoingautograntdelegateaccess = outgoingautograntdelegateaccess;
            this._managedidentityidValue = _managedidentityidValue;
            Maxconcurrentconnections = maxconcurrentconnections;
            Owneremailaddress = owneremailaddress;
            Outgoingportnumber = outgoingportnumber;
            Outgoingusessl = outgoingusessl;
            Incomingusessl = incomingusessl;
            Outgoingcredentialretrieval = outgoingcredentialretrieval;
            this._owningteamValue = _owningteamValue;
            Lasttestrequest = lasttestrequest;
            Versionnumber = versionnumber;
            EntityimageTimestamp = entityimageTimestamp;
            Useautodiscover = useautodiscover;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Exchangeversion = exchangeversion;
            Emailserverprofileid = emailserverprofileid;
            this._organizationidValue = _organizationidValue;
            Timeoutmailboxconnectionafteramount = timeoutmailboxconnectionafteramount;
            Minpollingintervalinminutes = minpollingintervalinminutes;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._outgoingpartnerapplicationValue = _outgoingpartnerapplicationValue;
            Incominguseimpersonation = incominguseimpersonation;
            Description = description;
            Lastcrmmessage = lastcrmmessage;
            Isoutgoingpasswordset = isoutgoingpasswordset;
            Incomingserverlocation = incomingserverlocation;
            Lasttestvalidationstatus = lasttestvalidationstatus;
            Lasttestexecutionstatus = lasttestexecutionstatus;
            Exchangeonlinetenantid = exchangeonlinetenantid;
            Entityimageid = entityimageid;
            Lastauthorizationstatus = lastauthorizationstatus;
            Defaultserverlocation = defaultserverlocation;
            Emailservertypename = emailservertypename;
            Incomingusername = incomingusername;
            Outgoinguseimpersonation = outgoinguseimpersonation;
            Timeoutmailboxconnection = timeoutmailboxconnection;
            Statecode = statecode;
            Outgoingusername = outgoingusername;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            Servertype = servertype;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            EmailserverprofileMailbox = emailserverprofileMailbox;
            EmailserverprofileAsyncoperations = emailserverprofileAsyncoperations;
            Createdby = createdby;
            Organizationid = organizationid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Ownerid = ownerid;
            EmailserverprofileBulkdeletefailures = emailserverprofileBulkdeletefailures;
            EmailServerProfileOrganization = emailServerProfileOrganization;
            Modifiedby = modifiedby;
            TracelogEmailServerProfile = tracelogEmailServerProfile;
            EmailServerProfileAnnotation = emailServerProfileAnnotation;
            EmailserverprofileDuplicatematchingrecord = emailserverprofileDuplicatematchingrecord;
            EmailServerProfileSyncErrors = emailServerProfileSyncErrors;
            EmailserverprofileDuplicatebaserecord = emailserverprofileDuplicatebaserecord;
            Keyvaultreferenceid = keyvaultreferenceid;
            Managedidentityid = managedidentityid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_keyvaultreferenceid_value")]
        public string _keyvaultreferenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauthclientsecret")]
        public string Oauthclientsecret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_incomingpartnerapplication_value")]
        public string _incomingpartnerapplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingauthenticationprotocol")]
        public int? Incomingauthenticationprotocol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isoauthclientsecretset")]
        public bool? Isoauthclientsecretset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usedefaulttenantid")]
        public bool? Usedefaulttenantid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isincomingpasswordset")]
        public bool? Isincomingpasswordset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingpassword")]
        public string Incomingpassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lasttestresponse")]
        public string Lasttestresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingserverlocation")]
        public string Outgoingserverlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "moveundeliveredemails")]
        public bool? Moveundeliveredemails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingpassword")]
        public string Outgoingpassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingcredentialretrieval")]
        public int? Incomingcredentialretrieval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingportnumber")]
        public int? Incomingportnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "encodingcodepage")]
        public string Encodingcodepage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendemailalert")]
        public bool? Sendemailalert { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastteststarttime")]
        public System.DateTimeOffset? Lastteststarttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lasttesttotalexecutiontime")]
        public long? Lasttesttotalexecutiontime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processemailsreceivedafter")]
        public System.DateTimeOffset? Processemailsreceivedafter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingauthenticationprotocol")]
        public int? Outgoingauthenticationprotocol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usesamesettingsforoutgoingconnections")]
        public bool? Usesamesettingsforoutgoingconnections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauthclientid")]
        public string Oauthclientid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aadresourceid")]
        public string Aadresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingautograntdelegateaccess")]
        public bool? Outgoingautograntdelegateaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_managedidentityid_value")]
        public string _managedidentityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxconcurrentconnections")]
        public int? Maxconcurrentconnections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owneremailaddress")]
        public string Owneremailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingportnumber")]
        public int? Outgoingportnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingusessl")]
        public bool? Outgoingusessl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingusessl")]
        public bool? Incomingusessl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingcredentialretrieval")]
        public int? Outgoingcredentialretrieval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lasttestrequest")]
        public string Lasttestrequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "useautodiscover")]
        public bool? Useautodiscover { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeversion")]
        public int? Exchangeversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailserverprofileid")]
        public string Emailserverprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeoutmailboxconnectionafteramount")]
        public int? Timeoutmailboxconnectionafteramount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minpollingintervalinminutes")]
        public int? Minpollingintervalinminutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_outgoingpartnerapplication_value")]
        public string _outgoingpartnerapplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incominguseimpersonation")]
        public bool? Incominguseimpersonation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastcrmmessage")]
        public string Lastcrmmessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isoutgoingpasswordset")]
        public bool? Isoutgoingpasswordset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingserverlocation")]
        public string Incomingserverlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lasttestvalidationstatus")]
        public int? Lasttestvalidationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lasttestexecutionstatus")]
        public int? Lasttestexecutionstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeonlinetenantid")]
        public string Exchangeonlinetenantid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastauthorizationstatus")]
        public int? Lastauthorizationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultserverlocation")]
        public string Defaultserverlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailservertypename")]
        public string Emailservertypename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingusername")]
        public string Incomingusername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoinguseimpersonation")]
        public bool? Outgoinguseimpersonation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeoutmailboxconnection")]
        public bool? Timeoutmailboxconnection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingusername")]
        public string Outgoingusername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servertype")]
        public int? Servertype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailserverprofile_mailbox")]
        public IList<MicrosoftDynamicsCRMmailbox> EmailserverprofileMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailserverprofile_asyncoperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EmailserverprofileAsyncoperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

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
        [JsonProperty(PropertyName = "emailserverprofile_bulkdeletefailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EmailserverprofileBulkdeletefailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EmailServerProfile_Organization")]
        public IList<MicrosoftDynamicsCRMorganization> EmailServerProfileOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracelog_EmailServerProfile")]
        public IList<MicrosoftDynamicsCRMtracelog> TracelogEmailServerProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EmailServerProfile_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> EmailServerProfileAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailserverprofile_duplicatematchingrecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EmailserverprofileDuplicatematchingrecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EmailServerProfile_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EmailServerProfileSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailserverprofile_duplicatebaserecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EmailserverprofileDuplicatebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyvaultreferenceid")]
        public MicrosoftDynamicsCRMkeyvaultreference Keyvaultreferenceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managedidentityid")]
        public MicrosoftDynamicsCRMmanagedidentity Managedidentityid { get; set; }

    }
}
