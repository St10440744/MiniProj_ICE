using System.ComponentModel.DataAnnotations;

namespace MiniProj.Models
{
    public class ModuleAssigment
    {
        [Key]
        public int AssignmentID { get; set; }
        [Required]
        public Modules ModuleID { get; set; }
        [Required]
        public Lecturer LecturerID { get; set; }
    }
}
