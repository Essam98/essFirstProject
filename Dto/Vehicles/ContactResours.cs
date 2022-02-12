using System.ComponentModel.DataAnnotations;

namespace dotnetWithMosh.Dto.Vehicles
{
    public class ContactResours {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}