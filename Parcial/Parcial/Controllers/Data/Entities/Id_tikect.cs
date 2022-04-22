using System.ComponentModel.DataAnnotations;

namespace Parcial.Controllers.Data.Entities
{
    public class Id_tikect
    {
        public int Id { get; set; }
        [Display(Name = "ID")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        
        public int Tikect_number { get; set; }   


    }
}
