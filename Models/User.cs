using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int Age { get; set; }
    }
}
