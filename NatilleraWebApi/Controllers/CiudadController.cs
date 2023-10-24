using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class CiudadController : ApiController
    {
        public List<Ciudad> Get()
        {
            clsCiudad _Ciudad = new clsCiudad();
            return _Ciudad.ConsultarTodos();
        }
    }
}