using System.ComponentModel.DataAnnotations;

namespace Voxtus_Tech.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
