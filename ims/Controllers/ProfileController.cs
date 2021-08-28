using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ims.Models;

namespace ims.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/Index
        public ActionResult Index()
        {
            return View();
        }

        //Profile/Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult ValidateUser(Student model)
        {
            
            if (model.Id==1001 && model.Password=="123")
            {
                TempData["key"] = model.Id;
                return RedirectToAction("Dashboard");
            }

            return View("Index");
        }

	}
}