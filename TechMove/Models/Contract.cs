using System.ComponentModel.DataAnnotations;

namespace TechMove.Models
{
    public enum ContractStatus 
    {
        Draft,
        Active,
        Expired
    }
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public ContractStatus Status { get; set; }

        public int ClientId {  get; set; }

        public Client? Client { get; set; }


    }
}
