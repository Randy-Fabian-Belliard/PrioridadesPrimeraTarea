using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PrioridadesPrimeraTarea.Models { 
    public class Prioridades{
    
    [Key]

    public int PrioridadId { get; set; }
    [Required(ErrorMessage = "Campo Obligatorio")]
    public string Descripcion { get; set; } = string.Empty;
    [Range(1, 29, ErrorMessage = "Los días de compromiso deben ser mayores que cero y menores que 30.")]
    public int DiasCompromiso{ get; set; }

    }

}
