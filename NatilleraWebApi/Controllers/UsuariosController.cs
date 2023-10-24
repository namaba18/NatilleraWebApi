using NatilleraWebApi.Clases;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

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
    }
}