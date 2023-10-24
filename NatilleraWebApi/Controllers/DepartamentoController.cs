using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class DepartamentoController : ApiController
    {
        public List<Departamento> Get()
        {
            clsDepartamento _Departamento = new clsDepartamento();
            return _Departamento.ConsultarTodos();
        }
    }
}