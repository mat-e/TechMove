using System.ComponentModel.DataAnnotations;

namespace TechMove.Models
{
    public class ServiceRequest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public Double Cost { get; set; }

        public int ContractId { get; set; }

        public List<Contract>? Contract {  get; set; }



    }
}
