using Microsoft.EntityFrameworkCore;
using PrioridadesPrimeraTarea.Models;

namespace PrioridadesPrimeraTarea.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options) { }
        public DbSet<Prioridades> Prioridades { get; set; }
        public DbSet<Clientes> clientes { get; set; }
    }
}
