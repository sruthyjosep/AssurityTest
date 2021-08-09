using Assurity_test.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assurity_test.Controller
{
  public class ControllerBase
        {
            protected RestContextBuilder _restContextBuilder;

        public ControllerBase(RestContextBuilder restContextBuilder)
        {
            _restContextBuilder = restContextBuilder;
        }

            
        }
    }


