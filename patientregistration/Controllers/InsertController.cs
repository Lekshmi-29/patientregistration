using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patientregistration.Models;
namespace patientregistration.Controllers
{
    public class InsertController : Controller
    {
        clinicEntities dbobj = new clinicEntities();
        // GET: Insert
        public ActionResult Insert_pageload()
        {
            return View();
        }
        public ActionResult Insert_Click(class1 obj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_insert(obj.FullName, obj.Address, obj.PINCode, obj.AadharID, obj.Mobile, obj.BloodGroup, obj.VisitDate, obj.Purposeofvisit);
                obj.msg = "Successfully inserted";
                ModelState.Clear();
                return View("Insert_pageload", obj);
            }
            return View("Insert_pageload", obj);
        }
    }
}