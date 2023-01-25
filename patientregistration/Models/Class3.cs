using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace patientregistration.Models
{
    public class Class3
    {[Required(ErrorMessage = "Enter the FullName")]
        public string FullName { set; get; }
        [Required(ErrorMessage = "Enter the VisitDate")]
        public string VisitDate { set; get; }

        [Required(ErrorMessage = "Enter the PurposeofVisit")]
        public string PurposeofVisit { set; get; }

        public string msg { set; get; }
    }
}