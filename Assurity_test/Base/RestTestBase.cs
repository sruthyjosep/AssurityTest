using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assurity_test.Base
{
    public class RestTestBase
    {
        public ApiScenarioContextKeys _apiScenarioContextKeys;

        public RestTestBase(ApiScenarioContextKeys apiScenarioContextKeys)
        {
            _apiScenarioContextKeys = apiScenarioContextKeys;
        }
    }
}
