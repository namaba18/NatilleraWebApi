using NatilleraWebApi.Models;
using System;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsAhorros
    {
        public Ahorro Ahorro { get; set; }
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public IQueryable ListarAhorros()
        {
            return from A in dBNatillera.Set<Ahorro>()
                   join U in dBNatillera.Set<Usuario>()
                   on A.UsuarioId equals U.UsuarioId
                   select new
                   {
                       Id = A.AhorroId,
                       Nombre = U.Nombre,
                       Apellido = U.Apellido,
                       Ahorro = A.Ahorro1,
                       FechaPago = A.FechaPago,
                       FechaLimite = A.FechaEstimada
                   };
        }
        public string Insertar()
        {
            try
            {
                dBNatillera.Ahorros.Add(Ahorro);
                dBNatillera.SaveChanges();
                return "Se ingresó el Ahorro correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Ahorro Consultar(string id)
        {
            return dBNatillera.Ahorros.FirstOrDefault(a => a.AhorroId.ToString() == id);
        }

        public string Actualizar()
        {
            try
            {
                Ahorro _ahorro = Consultar(Ahorro.AhorroId.ToString());
                if (_ahorro == null)
                {
                    return "El Ahorro no se encuentra registrado en la base de datos";
                }
                _ahorro.Ahorro1 = Ahorro.Ahorro1;
                _ahorro.FechaPago = Ahorro.FechaPago;
                _ahorro.FechaEstimada = Ahorro.FechaEstimada;
                _ahorro.UsuarioId = Ahorro.UsuarioId;
                dBNatillera.SaveChanges();
                return "El Ahorro se actualizó correctamente";
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
                Ahorro _ahorro = Consultar(Ahorro.AhorroId.ToString());
                if (_ahorro == null)
                {
                    return "El Ahorro no se encuentra registrado en la base de datos";
                }
                dBNatillera.Ahorros.Remove(_ahorro);
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