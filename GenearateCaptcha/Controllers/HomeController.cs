using CaptchaMvc.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenearateCaptcha.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string empty)
        {
            if (this.IsCaptchaValid("captch is not valid"))
            {
                return RedirectToAction("ThankyouPage");
            }
            ViewBag.ErrMessage = "Error:Captch is not valid.";
            return View();
        }
        public ActionResult ThankyouPage()
        {
            return View();
        }
    }
}