using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsPais
    {
        public Pai Pais { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<Pai> ConsultarTodos()
        {
            return dBNatillera.Pais.ToList();
        }
    }
}