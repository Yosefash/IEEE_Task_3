using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task_3
{
    public class Teacher
    {
        public int TeacherId {  get; set; }
        public string TeacherName { get; set; }
        public string DepartmentId { get; set; }

        public Department department { get; set; }=new Department();

        public List<Course> courses { get; set; }=new List<Course>();


    }
}
