using System.ComponentModel.DataAnnotations;

namespace Parcial.Controllers.Data.Entities
{
    public class Document
    {

        public int Id { get; set; }
        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document_tikect { get; set; }
    }
}
