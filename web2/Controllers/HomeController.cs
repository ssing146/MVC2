using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web2.ViewModel;

namespace web2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            TempData["Panni"] = id;
            TempData.Keep("panni");
            return View();
        }
        public ActionResult ThankYou()
        {

            return View();
        }

        public ActionResult Display()
        {
            EmpDeptViewModel obj = new EmpDeptViewModel() {
                EmpId = 100,
                name = "Simran",
                DepartmentId = 12,
                departmentName = "FS"
            };
            return View(obj);
        }

    }
}