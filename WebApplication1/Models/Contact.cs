using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria")]
        public string Address { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
