using NatilleraWebApi.Models;
using System;
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
                   join P in dBNatillera.Set<Prestamo>()
                   on A.PrestamoId equals P.PrestamoId
                   select new
                   {
                       Fecha = A.Fecha,
                       Usuario = U.Nombre + " " + U.Apellido,
                       Abono = A.Monto,
                       Prestamo = P.Fecha + "-" + P.Monto,
                   };
        }
        public IQueryable ListarAbonos(int prestamoId)
        {
            return from A in dBNatillera.Set<Abono>()
                   join U in dBNatillera.Set<Usuario>()
                   on A.UsuarioId equals U.UsuarioId
                   join P in dBNatillera.Set<Prestamo>()
                   on A.PrestamoId equals P.PrestamoId
                   where P.PrestamoId == prestamoId
                   select new
                   {
                       Fecha = A.Fecha,
                       Usuario = U.Nombre + " " + U.Apellido,
                       Abono = A.Monto,
                       Prestamo = P.Fecha + "-" + P.Monto,
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