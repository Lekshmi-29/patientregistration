using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace patientregistration.Models
{
    public class edit
    {[Required(ErrorMessage = "Enter the FullName")]
        public string FullName { set; get; }
        [Required(ErrorMessage = "Enter the Address")]
        public string Address { set; get; }
        [Required(ErrorMessage = "Enter the PINCode")]
        public string PINCode { set; get; }

        [Required(ErrorMessage = "Enter the AadharID")]
        public string AadharID { set; get; }


        public string Mobile { set; get; }
        [Required(ErrorMessage = "Enter the BloodGroup")]

        public string BloodGroup { set; get; }

        [Required(ErrorMessage = "Enter the VisitDate")]
        public string VisitDate { set; get; }

        [Required(ErrorMessage = "Enter the Purposeofvisit")]
        public string Purposeofvisit { set; get; }

        public string msg { set; get; }
    }
}