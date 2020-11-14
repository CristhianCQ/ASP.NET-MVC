using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        //public ActionResult Index(string name= "User")
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            //var name = HttpContext.Request.QueryString["name"]; // it isnt generally use
            model.Message = ConfigurationManager.AppSettings["message"];
            model.Name = name ?? "User!";
            
            return View(model);
        }
    }
}