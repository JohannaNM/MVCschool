using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCschool.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Course")]
        public string Title { get; set; }
        
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
