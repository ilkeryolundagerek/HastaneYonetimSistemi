using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimSistemi.Models
{

    public class NewPatientModel : BaseModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public long NationalId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodType { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
