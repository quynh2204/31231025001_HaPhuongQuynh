﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_ThieuKhaiNhi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(int id, string name, string email )
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
