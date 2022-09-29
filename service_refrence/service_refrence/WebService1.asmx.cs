using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace service_refrence
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Method of running web service")]
        public string show()
        {
            return "Method from second web service";
        }
        [WebMethod(Description = "Method of called web service")]
        public int display()
        { 
            localhost.WebService1 myMathService = new localhost.WebService1();
            return myMathService.Add(2, 4);

        }
    }
}

