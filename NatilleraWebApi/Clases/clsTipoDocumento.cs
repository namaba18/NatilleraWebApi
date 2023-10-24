using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsTipoDocumento
    {
        public TipoDocumento TipoDocumento { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<TipoDocumento> ConsultarTodos()
        {
            return dBNatillera.TipoDocumentoes.ToList();
        }
    }
}