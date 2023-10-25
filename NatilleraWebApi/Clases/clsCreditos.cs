using NatilleraWebApi.Models;
using System;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsCreditos
    {
        public Prestamo Prestamo { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public IQueryable ListarCreditos()
        {
            return from C in dBNatillera.Set<Prestamo>()
                   join U in dBNatillera.Set<Usuario>()
                   on C.UsuarioId equals U.UsuarioId
                   select new
                   {
                       Id = U.UsuarioId,
                       Nombre = U.Nombre,
                       Apellido = U.Apellido,
                       Monto = C.Monto,
                       Fecha = C.Fecha,
                       Cuotas = C.Cuotas,
                       Interes = C.Interes                       
                   };
        }
        public Prestamo ConsultarPrestamo(int id)
        {
            return dBNatillera.Prestamos.FirstOrDefault(p => p.PrestamoId == id);
        }

        public string InsertarPrestamo()
        {
            try
            {
                dBNatillera.Prestamos.Add(Prestamo);
                dBNatillera.SaveChanges();
                return "Se ingresó el prestamo con id:" + Prestamo.PrestamoId;
            }catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ActualizarPrestamo()
        {
            try
            {
                Prestamo prestamo = ConsultarPrestamo(Prestamo.PrestamoId);
                if (prestamo == null)
                {
                    return "El prestamo con id" + Prestamo.PrestamoId + "no existe en la base de datos";
                }
                prestamo.Cuotas = Prestamo.Cuotas;
                prestamo.Fecha = Prestamo.Fecha;
                prestamo.Interes = Prestamo.Interes;
                prestamo.Usuario = Prestamo.Usuario;
                dBNatillera.SaveChanges();
                return "Se actualizó el prestamo con id: " + Prestamo.PrestamoId;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarPrestamo()
        {
            try
            {
                Prestamo prestamo = ConsultarPrestamo(Prestamo.PrestamoId);
                if (prestamo == null)
                {
                    return "El prestamo con id" + Prestamo.PrestamoId + "no existe en la base de datos";
                }
                dBNatillera.Prestamos.Remove(prestamo);
                dBNatillera.SaveChanges();
                return "Se eliminó el prestamo con id: " + Prestamo.PrestamoId;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}