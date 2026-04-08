using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}