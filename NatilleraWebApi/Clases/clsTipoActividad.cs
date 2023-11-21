using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsTipoActividad
    {
        public TipoActividad TipoActividad { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<TipoActividad> ConsultarTodos()
        {
            return dBNatillera.TipoActividads.ToList();
        }
    }
}