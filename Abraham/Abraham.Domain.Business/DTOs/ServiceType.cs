using System.ComponentModel.DataAnnotations;

namespace Abraham.Domain.Business.DTOs
{
    public class ServiceType
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Coucou ça marche pas !")]
        public string Description { get; set; }
    }
}