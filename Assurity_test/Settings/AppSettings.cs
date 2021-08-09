using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Assurity_test.Settings
{
    public static class AppSettings 
    {

         public const string host = "https://api.tmsandbox.co.nz";
         public const string apiVersion ="v1";
         public const string GetCategoryDetails = "/{0}/Categories/{1}/Details.json?catalogue={2}";
    }
}
