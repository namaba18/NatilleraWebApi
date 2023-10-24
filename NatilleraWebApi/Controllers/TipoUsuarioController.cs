using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class TipoUsuarioController : ApiController
    {
        public List<TipoUsuario> Get()
        {
            clsTipoUsuario _TipoUsuario = new clsTipoUsuario();
            return _TipoUsuario.ConsultarTodos();
        }
    }
}