using RestSharp;
using System.Collections.Generic;

namespace Assurity_test.Controller
{
    public class RestContextBuilder : RestHelper
    {
       public new IRestResponse GetRequest(string host, string resource)
        {
            var request = new RestRequest(resource, Method.GET);
            return Execute(ConfigureRestClient(host), request);
        }

       public IRestResponse<T> GetRequest<T>(string host, string resource,IEnumerable<KeyValuePair<string, string>> headers = null) where T : new()
        {
            var request = new RestRequest(resource, Method.GET);
            return Execute<T>(ConfigureRestClient(host), request);
        }
        


    }
}