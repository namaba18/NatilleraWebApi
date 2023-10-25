using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Xml.Linq;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class UsuarioController : ApiController
    {
        public IQueryable Get()
        {
            clsUsuario _Usuario = new clsUsuario();
            return _Usuario.ListarUsuarios();
        }

        public Usuario Get(string Documento)
        {
            clsUsuario _Usuario = new clsUsuario();
            return _Usuario.Consultar(Documento);
        }

        public string Post([FromBody] Usuario usuario)
        {
            clsUsuario _usuario = new clsUsuario();
            _usuario.Usuario = usuario;
            return _usuario.InsertarUsuario();
        }

        public string Put([FromBody] Usuario usuario)
        {
            clsUsuario _usuario = new clsUsuario();
            _usuario.Usuario = usuario;
            return _usuario.ActualizarUsuario();
        }

        public string Delete([FromBody] Usuario usuario)
        {
            clsUsuario _usuario = new clsUsuario();
            _usuario.Usuario = usuario;
            return _usuario.EliminarUsuario();
        }
    }
}