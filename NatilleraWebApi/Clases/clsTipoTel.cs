using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsTipoTel
    {
        public TipoTel TipoTel { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<TipoTel> ConsultarTodos()
        {
            return dBNatillera.TipoTels.ToList();
        }
    }
}