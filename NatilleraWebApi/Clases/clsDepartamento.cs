using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsDepartamento
    {
        public Departamento Departamento { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<Departamento> ConsultarTodos()
        {
            return dBNatillera.Departamentoes.ToList();
        }
    }
}