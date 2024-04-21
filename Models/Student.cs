using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCschool.Models
{
    public class student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId {  get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "You have to enter a name")]
        [Display(Name = "First Name")]
        public string SFirstName { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "You have to enter a name")]
        [Display(Name = "Last Name")]
        public string SLastName { get; set; }
        [NotMapped]
        [Display(Name = "Full Name")]
        public string SFullName { get { return SFirstName + " " + SLastName; } }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class? Class { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
        
    }
}
