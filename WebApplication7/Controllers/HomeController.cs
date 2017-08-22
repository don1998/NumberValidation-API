using System.Web.Mvc;
using System.Web;
using WebApplication7.Models;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Net.Http;
using System;
using System.Net.Http.Formatting;

namespace pnVerify.Controllers
{
    [OutputCache(NoStore = true, Duration = 0)]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Title = "Login Page";
            return View();

        }

        public ActionResult Verify(string username, string password)

        {

            ActiveDir v = new ActiveDir();
           
            if (v.ValidateCredentials(username, password) == true)
            {
                ViewBag.Title = "Verification Page";
                ViewBag.Message = username;
                return View("verify");
            }
            else
                ViewBag.Message="Invalid Login";
                return View("Index");
        }

        public ActionResult Logout()
        {
            
            return RedirectToAction("Index", "Home");
            
        }
        
    }
}

