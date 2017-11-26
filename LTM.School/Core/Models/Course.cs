using LTM.School.Application.enumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int RealNmae { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public CourseGrade Grade { get; set; }

        public IComparable<Enrollment> Enrollments { get; set; }
    }
}
