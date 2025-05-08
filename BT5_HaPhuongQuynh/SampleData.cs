using BT5_ThieuKhaiNhi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_ThieuKhaiNhi
{
    public class SampleData
    {
        public List<Department> Departments { get; set; }

        public SampleData()
        {
            // Khởi tạo dữ liệu mẫu
            Departments = new List<Department>();

            // Tạo khoa CNTT Kinh doanh
            Department cntt = new Department("Khoa CNTT Kinh doanh");

            // Tạo các lớp cho khoa CNTT
            Clazz cntt1 = new Clazz("111:22:111");
            Clazz cntt2 = new Clazz("111:22:222");

            // Thêm sinh viên vào lớp CNTT 1
            cntt1.Students.Add(new Student(105, "Full name #5", "email5@ueh.edu.vn"));
            cntt1.Students.Add(new Student(106, "Full name #6", "email6@ueh.edu.vn"));
            cntt1.Students.Add(new Student(107, "Full name #7", "email7@ueh.edu.vn"));
            cntt1.Students.Add(new Student(108, "Full name #8", "email8@ueh.edu.vn"));
            cntt1.Students.Add(new Student(109, "Full name #9", "email9@ueh.edu.vn"));

            // Thêm lớp vào khoa CNTT
            cntt.Classes.Add(cntt1);
            cntt.Classes.Add(cntt2);

            // Tạo khoa Kế toán
            Department ketoan = new Department("Khoa Kế toán");

            // Tạo các lớp cho khoa Kế toán
            Clazz kt1 = new Clazz("222:33:111");
            Clazz kt2 = new Clazz("222:33:222");
            Clazz kt3 = new Clazz("222:33:333");

            // Thêm lớp vào khoa Kế toán
            ketoan.Classes.Add(kt1);
            ketoan.Classes.Add(kt2);
            ketoan.Classes.Add(kt3);

            // Thêm khoa vào danh sách
            Departments.Add(cntt);
            Departments.Add(ketoan);
        }
    }
}
