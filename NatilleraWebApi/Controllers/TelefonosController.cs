using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class TelefonosController : ApiController
    {
        public IQueryable Get(string Documento)
        {
            clsTelefono Telefono = new clsTelefono();
            return Telefono.ListaTelefonosXCliente(Documento);
        }

        public string Post([FromBody] Telefono telefono)
        {
            clsTelefono Telefono = new clsTelefono();
            Telefono.telefono = telefono;
            return Telefono.Grabar();
        }

        public string Put([FromBody] Telefono telefono)
        {
            clsTelefono Telefono = new clsTelefono();
            Telefono.telefono = telefono;
            return Telefono.Grabar();
        }

        public string Delete([FromBody] Telefono telefono)
        {
            clsTelefono Telefono = new clsTelefono();
            Telefono.telefono = telefono;
            return Telefono.Eliminar();
        }
    }
}