using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class PromoItemController : Controller
    {
        public ActionResult Index()
        {
            var mvcContext = new MvcContext();
            var model = mvcContext.GetDataSourceItem<PromoItemModel>();

            return View(model);
        }
    }
}