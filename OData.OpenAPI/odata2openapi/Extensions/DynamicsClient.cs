namespace CRM.Interface
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using Microsoft.Extensions.DependencyInjection;

    public partial class DynamicsClient : ServiceClient<DynamicsClient>, IDynamicsClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>    
        public Uri NativeBaseUri { get; set; }

        private readonly HttpClient httpClient;
        private readonly IConfiguration _configuration;

        [ActivatorUtilitiesConstructor] 
        public DynamicsClient(HttpClient httpClient, IConfiguration configuration)
        {
            Initialize();

            this.httpClient = httpClient;

            this._configuration = configuration;

            string baseUri = _configuration["DYNAMICS_ODATA_URI"]; // Dynamics ODATA endpoint

            if (string.IsNullOrEmpty(baseUri))
            {
                throw new Exception("Configuration setting DYNAMICS_ODATA_URI is blank.");
            }

            ServiceClientCredentials credentials = GetServiceClientCredentials();
            BaseUri = new Uri(baseUri);
            Credentials = credentials;

            // set the native client URI.  This is required if you have a reverse proxy or IFD in place and the native URI is different from your access URI.
            if (string.IsNullOrEmpty(_configuration["DYNAMICS_NATIVE_ODATA_URI"]))
            {
                NativeBaseUri = new Uri(_configuration["DYNAMICS_ODATA_URI"]);
            }
            else
            {
                NativeBaseUri = new Uri(_configuration["DYNAMICS_NATIVE_ODATA_URI"]);
            }

            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        public ServiceClientCredentials GetServiceClientCredentials()
        {
            // Cloud - x.dynamics.com
            string aadTenantId = _configuration["DYNAMICS_AAD_TENANT_ID"]; // Cloud AAD Tenant ID
            string serverAppIdUri = _configuration["DYNAMICS_SERVER_APP_ID_URI"]; // Cloud Server App ID URI
            string appRegistrationClientKey = _configuration["DYNAMICS_APP_REG_CLIENT_KEY"]; // Cloud App Registration Client Key
            string appRegistrationClientId = _configuration["DYNAMICS_APP_REG_CLIENT_ID"]; // Cloud App Registration Client Id

            // One Premise ADFS (2016)
            string adfsOauth2Uri = _configuration["ADFS_OAUTH2_URI"]; // ADFS OAUTH2 URI - usually /adfs/oauth2/token on STS
            string applicationGroupResource = _configuration["DYNAMICS_APP_GROUP_RESOURCE"]; // ADFS 2016 Application Group resource (URI)
            string applicationGroupClientId = _configuration["DYNAMICS_APP_GROUP_CLIENT_ID"]; // ADFS 2016 Application Group Client ID
            string applicationGroupSecret = _configuration["DYNAMICS_APP_GROUP_SECRET"]; // ADFS 2016 Application Group Secret
            string serviceAccountUsername = _configuration["DYNAMICS_USERNAME"]; // Service account username
            string serviceAccountPassword = _configuration["DYNAMICS_PASSWORD"]; // Service account password

            // API Gateway to NTLM user.  This is used in v8 environments.  Note that the SSG Username and password are not the same as the NTLM user.
            string ssgUsername = _configuration["SSG_USERNAME"];  // BASIC authentication username
            string ssgPassword = _configuration["SSG_PASSWORD"];  // BASIC authentication password



            ServiceClientCredentials serviceClientCredentials = null;
            if (!string.IsNullOrEmpty(appRegistrationClientId) && !string.IsNullOrEmpty(appRegistrationClientKey) && !string.IsNullOrEmpty(serverAppIdUri) && !string.IsNullOrEmpty(aadTenantId))
            // Cloud authentication - using an App Registration's client ID, client key.  Add the App Registration to Dynamics as an Application User.
            {
                var authenticationContext = new AuthenticationContext(
                "https://login.windows.net/" + aadTenantId);
                ClientCredential clientCredential = new ClientCredential(appRegistrationClientId, appRegistrationClientKey);
                var task = authenticationContext.AcquireTokenAsync(serverAppIdUri, clientCredential);
                task.Wait();
                var authenticationResult = task.Result;
                string token = authenticationResult.CreateAuthorizationHeader().Substring("Bearer ".Length);
                serviceClientCredentials = new TokenCredentials(token);
            } else if (!string.IsNullOrEmpty(adfsOauth2Uri) &&
                !string.IsNullOrEmpty(applicationGroupResource) &&
                !string.IsNullOrEmpty(applicationGroupClientId) &&
                !string.IsNullOrEmpty(applicationGroupSecret) &&
                !string.IsNullOrEmpty(serviceAccountUsername) &&
                !string.IsNullOrEmpty(serviceAccountPassword))
            // ADFS 2016 authentication - using an Application Group Client ID and Secret, plus service account credentials.
            {
                // create a new HTTP client that is just used to get a token.
                var stsClient = new HttpClient();

                //stsClient.DefaultRequestHeaders.Add("x-client-SKU", "PCL.CoreCLR");
                //stsClient.DefaultRequestHeaders.Add("x-client-Ver", "5.1.0.0");
                //stsClient.DefaultRequestHeaders.Add("x-ms-PKeyAuth", "1.0");

                stsClient.DefaultRequestHeaders.Add("client-request-id", Guid.NewGuid().ToString());
                stsClient.DefaultRequestHeaders.Add("return-client-request-id", "true");
                stsClient.DefaultRequestHeaders.Add("Accept", "application/json");

                // Construct the body of the request
                var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("resource", applicationGroupResource),
                    new KeyValuePair<string, string>("client_id", applicationGroupClientId),
                    new KeyValuePair<string, string>("client_secret", applicationGroupSecret),
                    new KeyValuePair<string, string>("username", serviceAccountUsername),
                    new KeyValuePair<string, string>("password", serviceAccountPassword),
                    new KeyValuePair<string, string>("scope", "openid"),
                    new KeyValuePair<string, string>("response_mode", "form_post"),
                    new KeyValuePair<string, string>("grant_type", "password")
                 };

                // This will also set the content type of the request
                var content = new FormUrlEncodedContent(pairs);
                // send the request to the ADFS server
                var _httpResponse = stsClient.PostAsync(adfsOauth2Uri, content).GetAwaiter().GetResult();
                var _responseContent = _httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                // response should be in JSON format.
                try
                {
                    Dictionary<string, string> result = JsonConvert.DeserializeObject<Dictionary<string, string>>(_responseContent);
                    string token = result["access_token"];
                    // set the bearer token.
                    serviceClientCredentials = new TokenCredentials(token);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message + " " + _responseContent);
                }

            }
            else if (!string.IsNullOrEmpty(ssgUsername) && !string.IsNullOrEmpty(ssgPassword))
            // Authenticate using BASIC authentication - used for API Gateways with BASIC authentication.  Add the NTLM user associated with the API gateway entry to Dynamics as a user.            
            {
                serviceClientCredentials = new BasicAuthenticationCredentials
                {
                    UserName = ssgUsername,
                    Password = ssgPassword
                };
            }
            else
            {
                throw new Exception("No configured connection to Dynamics.");
            }

            return serviceClientCredentials;
        }

        /// <summary>
        /// Setup a Dynamics client.
        /// </summary>
        /// <returns></returns>
        public IDynamicsClient SetupDynamics()
        {
            string dynamicsOdataUri = _configuration["DYNAMICS_ODATA_URI"]; // Dynamics ODATA endpoint

            if (string.IsNullOrEmpty(dynamicsOdataUri))
            {
                throw new Exception("configuration setting DYNAMICS_ODATA_URI is blank.");
            }

            ServiceClientCredentials serviceClientCredentials = GetServiceClientCredentials();

            var client = new DynamicsClient(new Uri(dynamicsOdataUri), serviceClientCredentials);

            // set the native client URI.  This is required if you have a reverse proxy or IFD in place and the native URI is different from your access URI.
            if (string.IsNullOrEmpty(_configuration["DYNAMICS_NATIVE_ODATA_URI"]))
            {
                client.NativeBaseUri = new Uri(_configuration["DYNAMICS_ODATA_URI"]);
            }
            else
            {
                client.NativeBaseUri = new Uri(_configuration["DYNAMICS_NATIVE_ODATA_URI"]);
            }

            return client;
        }
    }
}