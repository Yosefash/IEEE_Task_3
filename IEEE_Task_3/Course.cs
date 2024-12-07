using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task_3
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CorurseName { get; set; }
        public int Credits { get; set; }
        public int TeacherId { get; set; }
        public Teacher teacher { get; set; } = new Teacher();
        public List<Enrollment> enrollments { get; set; } = new List<Enrollment>();



    }
}
