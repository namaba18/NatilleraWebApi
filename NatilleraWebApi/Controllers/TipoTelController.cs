using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class TipoTelController : ApiController
    {
        public List<TipoTel> Get()
        {
            clsTipoTel _TipoTel = new clsTipoTel();
            return _TipoTel.ConsultarTodos();
        }
    }
}