using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System;
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
            clsCreditos _prestamo = new clsCreditos();
            return _prestamo.ListarCreditos();
        }
        public IQueryable Get(string usuarioId)
        {
            clsCreditos _prestamo = new clsCreditos();
            return _prestamo.ListarCreditos(Convert.ToInt32(usuarioId));
        }

        public string Post([FromBody] Prestamo prestamo)
        {
            clsCreditos _prestamo = new clsCreditos();
            _prestamo.Prestamo = prestamo;
            return _prestamo.InsertarPrestamo();
        }

        public string Put([FromBody] Prestamo prestamo)
        {
            clsCreditos _prestamo = new clsCreditos();
            _prestamo.Prestamo = prestamo;
            return _prestamo.ActualizarPrestamo();
        }

        public string Delete([FromBody] Prestamo prestamo)
        {
            clsCreditos _prestamo = new clsCreditos();
            _prestamo.Prestamo = prestamo;
            return _prestamo.EliminarPrestamo();
        }
    }
}