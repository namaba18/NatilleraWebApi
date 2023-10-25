using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class AhorrosController : ApiController
    {
        public IQueryable Get()
        {
            clsAhorros _ahorros = new clsAhorros();
            return _ahorros.ListarAhorros();
        }
        public Ahorro Get(string Id)
        {
            clsAhorros _ahorros = new clsAhorros();
            return _ahorros.Consultar(Id);
        }
        public string Post([FromBody] Ahorro ahorro)
        {
            clsAhorros _ahorros = new clsAhorros();
            _ahorros.Ahorro = ahorro;
            return _ahorros.Insertar();
        }

        public string Put([FromBody] Ahorro ahorro)
        {
            clsAhorros _ahorro = new clsAhorros();
            _ahorro.Ahorro = ahorro;
            return _ahorro.Actualizar();
        }

        public string Delete([FromBody] Ahorro ahorro)
        {
            clsAhorros _ahorro = new clsAhorros();
            _ahorro.Ahorro = ahorro;
            return _ahorro.Eliminar();
        }
    }
}