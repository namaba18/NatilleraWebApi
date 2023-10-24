using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsAbonos
    {
        public Abono Abono { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public IQueryable ListarAbonos()
        {
            return from A in dBNatillera.Set<Abono>()
                   join U in dBNatillera.Set<Usuario>()
                   on A.UsuarioId equals U.UsuarioId
                   select new
                   {
                       Id = U.UsuarioId,
                       Nombre = U.Nombre,
                       Apellido = U.Apellido,
                       Monto = A.Monto,
                       Fecha = A.Fecha                       
                   };
        }
    }
}