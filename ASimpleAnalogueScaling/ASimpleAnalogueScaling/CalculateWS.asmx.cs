using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ScalingApp
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://scalingapp.gear.host")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CalculateWS : System.Web.Services.WebService
    {

        [WebMethod]
        public double? CalculateService(InputQuery inputFromService)
        {
            

            
            return (inputFromService.RawResult()!=null? inputFromService.RawResult():inputFromService.ScaledResult());
        }
    }
}
