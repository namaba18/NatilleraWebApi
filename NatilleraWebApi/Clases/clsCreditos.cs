using NatilleraWebApi.Models;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsCreditos
    {
        public Prestamo Prestamo { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public IQueryable ListarCreditos()
        {
            return from C in dBNatillera.Set<Prestamo>()
                   join U in dBNatillera.Set<Usuario>()
                   on C.UsuarioId equals U.UsuarioId
                   select new
                   {
                       Id = U.UsuarioId,
                       Nombre = U.Nombre,
                       Apellido = U.Apellido,
                       Monto = C.Monto,
                       Fecha = C.Fecha,
                       Cuotas = C.Cuotas,
                       Interes = C.Interes                       
                   };
        }
    }
}