using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patientregistration.Models;
namespace patientregistration.Controllers
{
    public class PsearchController : Controller

    {
        clinicEntities dbobj = new clinicEntities();
        // GET: Psearch
        public ActionResult searchload()
        {
            var getdata = dbobj.sp_search(Session["FullName"].ToString()).FirstOrDefault();
            return View(new Class2 { FullName = getdata.FullName, Address = getdata.Address, PINCode = getdata.PIN_Code, AadharID = getdata.Aadhar_ID_Number, Mobile = getdata.Mobile });


        }
    }
}