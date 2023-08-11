using System.ComponentModel.DataAnnotations;

namespace Voxtus_Tech.Models
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; } = default!;
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
