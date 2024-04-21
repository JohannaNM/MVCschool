using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCschool.Models
{
    //public enum Grade
    //{
    //    A, B, C, D, E, F
    //}
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int EnrollmentId { get; set; }
        //public Grade? Grade { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public Course? Course { get; set; }
        public student? Student { get; set; }
    }
}
