using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patientregistration.Models;
namespace patientregistration.Controllers
{
    public class PdeleteController : Controller
    {
        clinicEntities dbobj = new clinicEntities();
        // GET: Pdelete
        public ActionResult delload(Class4 obj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_delete(Session["FullName"].ToString());

                obj.msg = "Successfully deleted";
                ModelState.Clear();
                return View("delload", obj);
            }
            return View("delload", obj);

        }
    }
}