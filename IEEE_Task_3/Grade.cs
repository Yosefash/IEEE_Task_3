using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task_3
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public Enrollment enrollment { get; set; } = new Enrollment();

    }
}
