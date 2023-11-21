using NatilleraWebApi.Models;
using System;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsActividades
    {
        public Actividade Actividad { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public IQueryable ListarActividades()
        {
            return from A in dBNatillera.Set<Actividade>()
                   join U in dBNatillera.Set<Usuario>()
                   on A.Encargado equals U.UsuarioId
                   join T in dBNatillera.Set<TipoActividad>()
                   on A.TipoActividadId equals T.TipoActividadId
                   select new
                   {
                       Actividad = A.Nombre,
                       TipoActividad = T.TipoActividadId,
                       Encargado = U.Nombre + " " + U.Apellido,
                       Costo = A.Costo,
                       Ganancia = A.Ganancia,
                   };
        }

        public string Insertar()
        {
            try
            {
                dBNatillera.Actividades.Add(Actividad);
                dBNatillera.SaveChanges();
                return "Se ingresó la actividad correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Actividade Consultar(string id)
        {
            return dBNatillera.Actividades.FirstOrDefault(a => a.ActividadId.ToString() == id);
        }

        public string Actualizar()
        {
            try
            {
                Actividade activiadad = Consultar(Actividad.ActividadId.ToString());
                if (activiadad == null)
                {
                    return "La actividad no se encuentra registrada en la base de datos";
                }
                return "La actividad se actualizó correctamente";
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
                Actividade actividad = Consultar(Actividad.ActividadId.ToString());
                if (actividad == null)
                {
                    return "La actividad no se encuentra registrada en la base de datos";
                }
                dBNatillera.Actividades.Remove(actividad);
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