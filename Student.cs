using System.ComponentModel.DataAnnotations;

namespace StudentCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        [Required, StringLength(100)]
        public string Course { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
