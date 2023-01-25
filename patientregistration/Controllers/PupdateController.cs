using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patientregistration.Models;
namespace patientregistration.Controllers
{
    public class PupdateController : Controller
    {
        clinicEntities dbobj = new clinicEntities();
        // GET: Pupdate
        public ActionResult Updateload(Class3 obj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_update(Session["FullName"].ToString(), obj.VisitDate, obj.PurposeofVisit);
                obj.msg = "Updated";
                ModelState.Clear();
                return View("Updateload", obj);
            }
            return View("Updateload", obj);
        }
    }
}