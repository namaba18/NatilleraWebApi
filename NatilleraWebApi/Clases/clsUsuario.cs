using NatilleraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace NatilleraWebApi.Clases
{
    public class clsUsuario
    {
        public Usuario Usuario { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public IQueryable ListarUsuarios()
        {
            return from U in dBNatillera.Set<Usuario>()
                   join TU in dBNatillera.Set<TipoUsuario>()
                   on U.TipoUsuarioId equals TU.TipoUsuarioId
                   join TD in dBNatillera.Set<TipoDocumento>()
                   on U.TipoDocumentoId equals TD.TipoDocumentoId
                   orderby (U.Apellido)
                   select new { 
                        Id = U.UsuarioId,
                        Nombre = U.Nombre,
                        Apellido = U.Apellido,
                        TipoDocumento = TD.Descripcion,
                        Documento = U.Documento,
                        TipoUsuario = TU.Descripcion,
                        Activo = U.Activo
                   };
        }

    }
}