using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assurity_test.Base
{
    public class ApiScenarioContextKeys
    {
        public RestClient _restClient;
        public IRestResponse _restResponse;
        public bool IncludeHeaders { get; set; } = true;

    }
}
