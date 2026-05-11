using System.ComponentModel.DataAnnotations;

namespace TechMove.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailAddress{ get; set; }
        [Required]
        public string? PhoneNumber{ get; set; }
        [Required]
        public string Region { get; set; }

        public int ContractId { get; set; }

    }
}
