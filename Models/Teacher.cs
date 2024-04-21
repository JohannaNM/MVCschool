using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCschool.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        
        [StringLength(40)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You have to enter a name")]
        public string TFirstName { get; set; }
        
        [StringLength(40)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You have to enter a name")]
        public string TLastName { get; set; }
        
        [NotMapped]
        [Display(Name = "Teacher")]
        public string TFullName
        {
            get { return TFirstName + " " + TLastName; }
        }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
