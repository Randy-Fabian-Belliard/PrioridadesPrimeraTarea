using PrioridadesPrimeraTarea.DAL;
using Microsoft.EntityFrameworkCore;
using PrioridadesPrimeraTarea.Models;
using System.Linq.Expressions;

namespace PrioridadesPrimeraTarea.BLL
{
    public class PrioridadesBLL
    {
        private readonly Contexto _contexto;
        public PrioridadesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int PrioridadId)
        {
            return _contexto.Prioridades.Any(p => p.PrioridadId == PrioridadId);
        }
        public bool Insertar(Prioridades prioridades)
        {
            _contexto.Prioridades.Add(prioridades);
            return _contexto.SaveChanges() > 0;
        }
        public bool Modificar(Prioridades prioridades)
        {
            var entry = _contexto.Entry(prioridades);

            if (entry.State == EntityState.Detached)
            {
                _contexto.Update(prioridades);
            }
            else
            {
                entry.State = EntityState.Detached;
                _contexto.Attach(prioridades);
                _contexto.Entry(prioridades).State = EntityState.Modified;
            }

            int modificado = _contexto.SaveChanges();
            return modificado > 0;
        }

        public bool Guardar(Prioridades prioridades)
        {
            if (!Existe(prioridades.PrioridadId))
                return this.Insertar(prioridades);
            else
                return this.Modificar(prioridades);
        }
      /*  public bool Eliminar(Prioridades prioridades)
        {
            _contexto.Entry(prioridades).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }*/

        public bool Eliminar(Prioridades prioridades){
            bool changes = false;
            try{
                _contexto.Entry(prioridades).State = EntityState.Deleted;
                changes = _contexto.SaveChanges() > 0;
                _contexto.Prioridades.Entry(prioridades).State = EntityState.Detached;
                return changes;
            }
            catch(Exception){
                return false;
        }
    }
         


        public Prioridades? BuscarPorDescripcion(string? descripcion)
        {
            return _contexto.Prioridades.SingleOrDefault(p => p.Descripcion == descripcion);
        }
        public Prioridades? Buscar(int PrioridadId)
        {
            return _contexto.Prioridades
                    .AsNoTracking()
                    .SingleOrDefault(p => p.PrioridadId == PrioridadId);
        }
        public List<Prioridades> Listar(Expression<Func<Prioridades, bool>> Criterio)
        {
            return _contexto.Prioridades
                    .Where(Criterio)
                    .AsNoTracking()
                    .ToList();
        }
    }
}
