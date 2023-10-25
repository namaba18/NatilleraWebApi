using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class AbonosController : ApiController
    {
        public IQueryable Get()
        {
            clsAbonos _abonos = new clsAbonos();
            return _abonos.ListarAbonos();
        }
        public Abono Get(string Id)
        {
            clsAbonos _abonos = new clsAbonos();
            return _abonos.Consultar(Id);
        }
        public string Post([FromBody] Abono abono)
        {
            clsAbonos _abonos = new clsAbonos();
            _abonos.Abono = abono;
            return _abonos.Insertar();
        }

        public string Put([FromBody] Abono abono)
        {
            clsAbonos _abono = new clsAbonos();
            _abono.Abono = abono;
            return _abono.Actualizar();
        }

        public string Delete([FromBody] Abono abono)
        {
            clsAbonos _abonos = new clsAbonos();
            _abonos.Abono = abono;
            return _abonos.Eliminar();
        }
    }
}