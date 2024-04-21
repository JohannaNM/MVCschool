using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MVCschool.Models.ViewModels
{
    public class StudentsWithTeachers
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<student> Students { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
