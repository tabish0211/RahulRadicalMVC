using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ims.Models;

namespace ims.Controllers
{
    public class MiscController : Controller
    {
        //
        // GET: /Misc/
        public ActionResult Index()
        {
            ViewData["key"] = "View data is used for passing data from action to UI";
            return View();
        }

        public ActionResult ViewBagDemo()
        {
            ViewBag.Description = @"View Bag is just a syntactical sugar of view data and 
                                    is also used for passing data from action to UI";
            return View();
           
        }

        public ActionResult SessionDemo()
        {
            Session["key"] = "I will exist untill you close the browser or do logout or your server down";
            return View();
        }

        //Misc/RetrunString
        public ActionResult RetrunString()
        {
            return Content("Hello World");
        }


        //Misc/RetrunJson
        public ActionResult RetrunJson()
        {
            Student obj = new Student();
            obj.Id = 1001;
            obj.Password = "123";

            return Json(obj, JsonRequestBehavior.AllowGet);

            //{ 
            //    "Id":1001,
            //    "Password":"123"
            
            //}
        }

        public ActionResult NoReturn()
        {
            return new EmptyResult();
        }

        //Misc/HttpNotFoundDemo
        //Misc/http
        //[ActionName("http")]
        [NonAction]
        public ActionResult HttpNotFoundDemo()
        {
            return new HttpNotFoundResult();
        }

        // Misc/Contact
        public ActionResult Contact()
        {
            string msg = null;
             // this will throw an exception

            return Content(msg.Length.ToString());
        }

	}
}