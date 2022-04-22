

using System.ComponentModel.DataAnnotations;

namespace Parcial.Controllers.Data.Entities
{
    public class WasUsed
    {


        public int Id { get; set; }
        [Display(Name = "Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public bool status { get; set; }
    }
}
