using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_ThieuKhaiNhi.Models
{
      public class Department
    {
        public string Name { get; set; }
        public List<Clazz> Classes { get; set; }

        public Department(string name)
        {
            Name = name;
            Classes = new List<Clazz>();
        }

        //public void AddClass(Clazz clazz)
        //{
        //    Classes.Add(clazz);
        //}

        //public void RemoveClass(Clazz clazz)
        //{
        //    Classes.Remove(clazz);
        //}
    }
}
