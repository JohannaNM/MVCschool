using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCschool.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required (ErrorMessage = "You have to name the class")]
        [Display(Name = "Class")]
        [StringLength (15)]
        public string ClassName { get; set; }
        //public int StudentCount { get; set; }

        public ICollection<student>? Students { get; set; }

    }
}
