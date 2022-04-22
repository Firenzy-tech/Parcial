using Microsoft.OData.Edm;
using System.ComponentModel.DataAnnotations;

namespace Parcial.Controllers.Data.Entities
{
    public class Date_
    {
        public int Id { get; set; }
        [Display(Name = "Fecha")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe tener máximo {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]


        public DateTime Date { get; set; }


    }
}
