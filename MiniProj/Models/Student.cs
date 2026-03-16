using System.ComponentModel.DataAnnotations;

namespace MiniProj.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]  
        public string Email { get; set; }
        [Required]  
        public string PhoneNumber { get; set; }
        [Required]
        public int YearOfStudy { get; set; }



    }
}
