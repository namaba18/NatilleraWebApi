using NatilleraWebApi.Clases;
using NatilleraWebApi.Models;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraWebApi.Controllers
{
    [EnableCors(origins: "https://localhost:44315", headers: "*", methods: "*")]
    public class ActividadesController : ApiController
    {
        public IQueryable Get()
        {
            clsActividades _actividades = new clsActividades();
            return _actividades.ListarActividades();
        }
        
        public string Post([FromBody] Actividade actividad)
        {
            clsActividades _actividades = new clsActividades();
            _actividades.Actividad = actividad;
            return _actividades.Insertar();
        }

        public string Put([FromBody] Actividade actividad)
        {
            clsActividades _actividades = new clsActividades();
            _actividades.Actividad = actividad;
            return _actividades.Actualizar();
        }

        public string Delete([FromBody] Actividade actividad)
        {
            clsActividades _actividades = new clsActividades();
            _actividades.Actividad = actividad;
            return _actividades.Eliminar();
        }
    }
}