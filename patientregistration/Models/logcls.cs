using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace patientregistration.Models
{
    public class logcls
    {
        [Required(ErrorMessage =  "enter the FullName")]
        public string FullName { set; get; }

        public string Mobile { set; get; }
        public string msg { set; get; }
    }
}