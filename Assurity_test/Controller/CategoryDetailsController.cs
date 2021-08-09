using Assurity_test.Settings;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assurity_test.Controller
{
    public class CategoryDetailsController : ControllerBase
    {
        public CategoryDetailsController(RestContextBuilder restContextBuilder) :  base(restContextBuilder)
        {

        }

        public IRestResponse GetCategoryDetails(string categoryId, string isCatalogueNeeded)
        {
            return _restContextBuilder.GetRequest(AppSettings.host,
                string.Format(AppSettings.GetCategoryDetails, AppSettings.apiVersion, categoryId, isCatalogueNeeded));
        }

    }
}
