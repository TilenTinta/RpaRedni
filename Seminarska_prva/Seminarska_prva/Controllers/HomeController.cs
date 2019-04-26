using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminarska_prva.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Product()
        {
            string apiUri = Url.HttpRouteUrl("Produkti",
                new { controller = "Product" });
            ViewBag.ApiUri = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();
            return View();
        }
        public ActionResult ProductWebApi()
        {
            string apiUri = Url.HttpRouteUrl("ProductsWebApi",
                new { controller = "ProductsWebApi" });
            ViewBag.ApiUri = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();
            return View();
        }
    }
}