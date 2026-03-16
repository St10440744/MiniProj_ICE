using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProj.Models
{
    public class Registration 
    {
        [Key]
        public int RegistrationID { get; set; }
        [Required]
        [ForeignKey("StudentID")]
        public Student StudentID { get; set; }
        [Required]
        [ForeignKey("ModuleID")]
        public int ModuleID { get; set; }
    }
}
