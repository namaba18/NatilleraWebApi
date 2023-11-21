using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class TipoActividadController : ApiController
    {
        public List<TipoActividad> Get()
        {
            clsTipoActividad _tipoActividad = new clsTipoActividad();
            return _tipoActividad.ConsultarTodos();
        }
    }
}