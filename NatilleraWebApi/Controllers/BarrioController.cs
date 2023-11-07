using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class BarrioController : ApiController
    {
        public List<Barrio> Get(int ciudad)
        {
            clsBarrio _Barrio = new clsBarrio();
            return _Barrio.ConsultarTodos(ciudad);
        }
    }
}