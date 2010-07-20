// ReSharper disable Asp.NotResolved
using System.Web.Mvc;

namespace n2CMS_Spark_Template.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}
// ReSharper restore Asp.NotResolved