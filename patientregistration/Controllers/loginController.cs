using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patientregistration.Models;
namespace patientregistration.Controllers
{
    public class loginController : Controller
    {
        clinicEntities dbobj = new clinicEntities();
        // GET: login
        public ActionResult logpageLoad()
        {
            return View();
        }
        public ActionResult log_click(logcls objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objcls.FullName, objcls.Mobile, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    Session["FullName"] = objcls.FullName;
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "Invalid login";
                    return View("logpageLoad", objcls);

                }

            }
            return View("logpageLoad", objcls);
        }


        public ActionResult Home()
        {
            return View();
        }
    }
}