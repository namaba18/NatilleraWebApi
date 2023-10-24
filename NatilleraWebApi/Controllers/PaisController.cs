using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class PaisController : ApiController
    {
        public List<Pai> Get()
        {
            clsPais _Pais = new clsPais();
            return _Pais.ConsultarTodos();
        }
    }
}