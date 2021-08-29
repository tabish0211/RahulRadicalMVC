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
            var result = TempData["key"] as Student;
            Student resultModel = new Student();
            resultModel.Id = result.Id;
            resultModel.Name = result.Name;
            return View(resultModel);
        }

        public ActionResult ValidateUser(Student model)
        {
            ImsCntxt contxt = new ImsCntxt();
            Student result=contxt.students.Where(s=>s.Id==model.Id).FirstOrDefault();
            contxt.Dispose();
            if (result!=null)
            {               
                TempData["key"] = result;
                return RedirectToAction("Dashboard");
            }
     

            return View("Index");
        }

        // Profile/SaveStudent
        public ActionResult SaveStudent()
        {
            Student obj = new Student();
            obj.Id = 1001;//1
            obj.Name = "Rakesh";
            obj.Password = "123";

            ImsCntxt contxt = new ImsCntxt();
            contxt.students.Add(obj);
            contxt.SaveChanges();
            contxt.Dispose();

            return Content("Record added successfully");
        }


        public ActionResult Edit(int id)
        {
            ImsCntxt contxt = new ImsCntxt();
            Student result = contxt.students.Where(s => s.Id == id).FirstOrDefault();
            contxt.Dispose();
            return View(result);
        }

        public ActionResult Update(Student obj)
        {
            ImsCntxt contxt = new ImsCntxt();
            Student result = contxt.students.Where(s => s.Id == obj.Id).FirstOrDefault();

            result.Name = obj.Name;
            contxt.SaveChanges();
            contxt.Dispose();
            return View();
        }
	}
}