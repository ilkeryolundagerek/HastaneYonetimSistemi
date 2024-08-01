using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimSistemi.Models
{

    public class NewPatientModel : PersonBaseModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
