using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsCiudad
    {
        public Ciudad Ciudad { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<Ciudad> ConsultarTodos(int departamento)
        {
            return dBNatillera.Ciudads.Where(c => c.DepartamentoId == departamento).ToList();
        }
    }
}