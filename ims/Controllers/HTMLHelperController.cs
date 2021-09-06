using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ims.Models;

namespace ims.Controllers
{
    public class HTMLHelperController : Controller
    {
        //
        // GET: /HTMLHelper/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveStudent(Student obj)
        {
            if (ModelState.IsValid)
            {
                //Go ahead
            }

            return View("Index");
        }
	}
}