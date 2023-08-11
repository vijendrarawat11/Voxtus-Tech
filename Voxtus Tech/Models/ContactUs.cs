using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
#nullable disable
namespace Voxtus_Tech.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,NotNull]
        [DisplayName("Phone No.")]
        public string PhoneNo { get; set; } 
        [Required]
        public string Email { get; set; }


        public string Message { get; set; } 

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
