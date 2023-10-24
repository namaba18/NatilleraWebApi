using NatilleraWebApi.Clases;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class CreditosController : ApiController
    {
        public IQueryable Get()
        {
            clsCreditos _Creditos = new clsCreditos();
            return _Creditos.ListarCreditos();
        }
    }
}