using System.ComponentModel.DataAnnotations;

namespace MiniProj.Models
{
    public class Modules
    {
        [Key]
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public string ModuleCode { get; set; }
        public int Credits { get; set; }
        public int AcademicYear { get; set; }

    }
}
