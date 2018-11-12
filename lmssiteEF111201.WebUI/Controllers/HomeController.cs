using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lmssiteEF111201.Model;
using lmssiteEF111201.Bll;

namespace lmssiteEF111201.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            MenuBll service = new MenuBll();
            List<JQ_M_MENU> result = service.Query(k => k.Is_Delete == false);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}