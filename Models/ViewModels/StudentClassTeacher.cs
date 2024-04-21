namespace MVCschool.Models.ViewModels
{
    public class StudentClassTeacher
    {
       public virtual IEnumerable<Teacher> Teachers { get; set; }
       public virtual IEnumerable<Course> Courses { get; set; }
       public virtual IEnumerable<Enrollment> Enrollments { get; set; }

    }
}
