using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patientregistration.Models;
namespace patientregistration.Controllers
{
    public class PeditController : Controller
    {
        clinicEntities dbobj = new clinicEntities();
        // GET: Pedit
        public ActionResult editload(edit obj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_Editing(obj.FullName, obj.Address, obj.PINCode, obj.AadharID, obj.Mobile, obj.BloodGroup, obj.VisitDate, obj.Purposeofvisit);


                obj.msg = "Successfully edited";
                ModelState.Clear();
                return View("editload", obj);
            }
            return View("editload", obj);


        }
    }
}