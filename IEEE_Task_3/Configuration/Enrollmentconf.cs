using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task_3.Configuration
{
    internal class Enrollmentconf: IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(x => x.EnrollmentId);
            builder.HasOne(x => x.course).WithMany(x => x.enrollments).HasForeignKey(x => x.CourseId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.student).WithMany(x => x.enrollments).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
