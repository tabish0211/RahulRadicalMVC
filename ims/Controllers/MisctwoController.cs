using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ims.Models;

namespace ims.Controllers
{
    public class MisctwoController : Controller
    {
        //
        // GET: /Misctwo/ViewModelDemo
        public ActionResult ViewModelDemo()
        {  
            //when you need more than one model in ui you need ViewModel
            Student obj = new Student();
            obj.Id = 1001;
            obj.Name = "Aakash";

            Address objAddr = new Address();
            objAddr.City = "Pune";
            objAddr.State = "MH";

            VMStuAdd vm = new VMStuAdd();
            vm.student = obj;
            vm.address = objAddr;


            return View(vm);
        }
	}
}