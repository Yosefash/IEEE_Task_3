using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task_3
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId  { get; set; }
        public int CourseId  { get; set; }
        public int GradeId { get; set; }
        public Grade grade { get; set; }= new Grade();

        public Student student  { get; set; }
        public Course course { get; set; }

    }
}
