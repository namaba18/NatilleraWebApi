﻿using NatilleraWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsBarrio
    {
        public Barrio Barrio { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public List<Barrio> ConsultarTodos(int ciudad)
        {
            return dBNatillera.Barrios.Where(b => b.CiudadId == ciudad).ToList();
        }
    }
}