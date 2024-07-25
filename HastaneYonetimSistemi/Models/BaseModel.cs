using System;

namespace HastaneYonetimSistemi.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
        public bool Deleted { get; set; } = false;
    }
}
