using LemonWayBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LemonWayService.Services
{
    /// <summary>
    /// Summary description for XmlToJsonService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class XmlToJsonService : System.Web.Services.WebService
    {
        [WebMethod]
        public string XmlToJson(string xml)
        {
            return Converter.XmlToJson(xml);
        }
    }
}
