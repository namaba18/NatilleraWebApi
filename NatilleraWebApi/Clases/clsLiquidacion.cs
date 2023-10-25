using NatilleraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraWebApi.Clases
{
    public class clsLiquidacion
    {
        public Liquidacion liquidacion { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public Liquidacion ConsultarLiquidacion(string Documento)
        {
            Usuario usuario = dBNatillera.Usuarios.FirstOrDefault(u => u.Documento == Documento);
            decimal ahorros = 0;
            foreach (var ahorro in usuario.Ahorros)
            {
                ahorros += ahorro.Ahorro1;
            }
            decimal deuda = 0;
            foreach (var prestamo in usuario.Prestamos)
            {
                decimal abonos = 0;
                foreach (var abono in prestamo.Abonos)
                {
                    abonos += abono.Monto;
                }
                deuda += prestamo.Monto + prestamo.Monto * prestamo.Interes / 100 - abonos;                
            }
            Liquidacion liquidacion = new Liquidacion();
            liquidacion.Nombre = usuario.Nombre;
            liquidacion.Apellido = usuario.Apellido;
            liquidacion.Monto = ahorros - deuda;
            return liquidacion;
        }

    }
}