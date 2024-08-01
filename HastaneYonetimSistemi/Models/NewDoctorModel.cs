using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimSistemi.Models
{
    public class NewDoctorModel : PersonBaseModel
    {
        public string Department { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }

    }
}
