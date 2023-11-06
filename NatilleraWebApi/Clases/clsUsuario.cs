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

        public Usuario Consultar(string documento)
        {
            return dBNatillera.Usuarios.FirstOrDefault(u => u.Documento == documento);
        }

        public string InsertarUsuario()
        {
            try
            {
                dBNatillera.Usuarios.Add(Usuario);
                dBNatillera.SaveChanges();
                return "Se ingresó el socio: " + Usuario.Nombre;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ActualizarUsuario()
        {
            try
            {
                Usuario usuario = dBNatillera.Usuarios.FirstOrDefault(u => u.Documento == Usuario.Documento);
                if (usuario == null)
                {
                    return "el usuario con documento: " + Usuario.Documento + " no se encuentra en la base de datos";
                }

                usuario.Documento = Usuario.Documento;
                usuario.Nombre = Usuario.Nombre;
                usuario.Apellido = Usuario.Apellido;
                usuario.TipoUsuarioId = Usuario.TipoUsuarioId;
                usuario.TipoDocumentoId = Usuario.TipoDocumentoId;
                usuario.Barrio = Usuario.Barrio;
                usuario.Activo = Usuario.Activo;
                dBNatillera.SaveChanges();
                return "Se actualizó el usuario";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarUsuario()
        {
            try
            {
                Usuario usuario = Consultar(Usuario.Documento);
                if (usuario == null)
                {
                    return "el usuario con documento: " + Usuario.Documento + " no se encuentra en la base de datos";
                }
                dBNatillera.Usuarios.Remove(usuario);
                dBNatillera.SaveChanges();
                return "Se eliminó el usuario";
            }
            catch (Exception ex) { return ex.Message; }
        }

    }
}