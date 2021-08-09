using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using NUnit.Framework;
namespace Assurity_test.Controller
{
    public class RestHelper
    {

        public RestClient ConfigureRestClient(string host, string username = null, string password = null)
        {
            RestClient restClient = new RestClient(host);
            if (username != null && password != null)
            { restClient.Authenticator = new HttpBasicAuthenticator(username, password); }
            restClient.CookieContainer = new CookieContainer();

            return restClient;
        }

         public IRestResponse GetRequest(string host, string resource)
        {
            var request = new RestRequest(resource, Method.GET);
            return Execute(ConfigureRestClient(host), request);
        }

        public IRestResponse Execute(RestClient restClient, RestRequest request)
        {
            //This Line Caters For SSL Certificate Errors
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            return restClient.Execute(request);
        }

        public IRestResponse<T> Execute<T>(RestClient restClient, RestRequest request) where T : new()
        {
            //This Line Caters For SSL Certificate Errors
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            return restClient.Execute<T>(request);
        }
    }
}