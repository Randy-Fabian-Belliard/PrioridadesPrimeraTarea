using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PrioridadesPrimeraTarea.Models { 
    public class Prioridades{
    
    [Key]

    public int PrioridadId { get; set; }
    [Required(ErrorMessage = "Campo Obligatorio")]
    public string Descripcion { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo Obligatorio")]
    public int DiasCompromiso{ get; set; }

    }

}
