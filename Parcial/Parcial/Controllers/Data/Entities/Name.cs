using System.ComponentModel.DataAnnotations;

namespace Parcial.Controllers.Data.Entities
{
    public class Name
    {

        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name_tikect { get; set; }

    }
}
