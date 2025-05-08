using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_ThieuKhaiNhi.Models
{
     public class Clazz
    {
        public string ClassId { get; set; }
        public List<Student> Students { get; set; }
        public Clazz(string id)
        {
            ClassId = id;
            Students = new List<Student>();
        }
    }
}
