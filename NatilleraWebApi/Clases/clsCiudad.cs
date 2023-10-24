using NatilleraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraWebApi.Clases
{
    public class clsCiudad
    {
        public Ciudad Ciudad { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<Ciudad> ConsultarTodos()
        {
            return dBNatillera.Ciudads.ToList();
        }
    }
}