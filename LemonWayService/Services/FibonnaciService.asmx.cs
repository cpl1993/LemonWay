using LemonWayBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

namespace LemonWayService.Services
{
    /// <summary>
    /// Summary description for FibonnaciService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FibonnaciService : System.Web.Services.WebService
    {
        /// <summary>
        /// Get fibonnaci number regarding the parameter sent
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [WebMethod]
        public int Fibonacci(int n)
        {
            return Mathematic.Fibonnaci(n);
        }
    }
}
