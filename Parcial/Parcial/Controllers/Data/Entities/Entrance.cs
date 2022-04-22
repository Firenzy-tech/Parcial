using System.ComponentModel.DataAnnotations;

namespace Parcial.Controllers.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }
        [Display(Name = "Entrada")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string entrance { get; set; }




    }
}
