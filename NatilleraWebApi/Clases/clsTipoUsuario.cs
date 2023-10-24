using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsTipoUsuario
    {
        public TipoUsuario TipoUsuario { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<TipoUsuario> ConsultarTodos()
        {
            return dBNatillera.TipoUsuarios.OrderBy(t => t.Descripcion).ToList();
        }
    }
}