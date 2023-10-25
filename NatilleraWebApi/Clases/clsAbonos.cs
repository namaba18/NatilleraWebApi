using NatilleraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsAbonos
    {
        public Abono Abono { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public IQueryable ListarAbonos()
        {
            return from A in dBNatillera.Set<Abono>()
                   join U in dBNatillera.Set<Usuario>()
                   on A.UsuarioId equals U.UsuarioId
                   select new
                   {
                       Id = U.UsuarioId,
                       Nombre = U.Nombre,
                       Apellido = U.Apellido,
                       Monto = A.Monto,
                       Fecha = A.Fecha                       
                   };
        }
        public string Insertar()
        {
            try
            {
                dBNatillera.Abonos.Add(Abono);
                dBNatillera.SaveChanges();
                return "Se ingresó el abono correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Abono Consultar(string id)
        {
            return dBNatillera.Abonos.FirstOrDefault(a => a.AbonoId.ToString() == id);
        }

        public string Actualizar()
        {
            try
            {
                Abono abono = Consultar(Abono.AbonoId.ToString());
                if (abono == null)
                {
                    return "El abono no se encuentra registrado en la base de datos";
                }
                return "El abono se actualizó correctamente";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string Eliminar()
        {
            try
            {
                Abono abono = Consultar(Abono.AbonoId.ToString());
                if (abono == null)
                {
                    return "El abono no se encuentra registrado en la base de datos";
                }
                dBNatillera.Abonos.Remove(abono);
                dBNatillera.SaveChanges();
                return "Se eliminó correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}