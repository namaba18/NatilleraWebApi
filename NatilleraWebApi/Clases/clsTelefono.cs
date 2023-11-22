using NatilleraWebApi.Models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace NatilleraWebApi.Clases
{
    public class clsTelefono
    {
        private DBNatilleraEntities dBNatillera = new DBNatilleraEntities();
        public Telefono telefono { get; set; }
        public IQueryable ListaTelefonosXCliente(string Documento)
        {
            return from U in dBNatillera.Set<Usuario>()
                   join TE in dBNatillera.Set<Telefono>()
                   on U.UsuarioId equals TE.UsuarioId
                   join TT in dBNatillera.Set<TipoTel>()
                   on TE.TipoTelId equals TT.TipoTelId
                   where U.Documento == Documento
                   select new
                   {
                       Id = TE.TelefonoId,
                       TipoTel = TT.Decripcion,
                       Numero = TE.Numero,
                   };
        }
        public string Grabar()
        {
            try
            {
                dBNatillera.Telefonoes.AddOrUpdate(telefono);
                dBNatillera.SaveChanges();
                return "Se grabó el teléfono: " + telefono.Numero;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                Telefono _Telefono = dBNatillera.Telefonoes.FirstOrDefault(t => t.TelefonoId == telefono.TelefonoId);
                dBNatillera.Telefonoes.Remove(_Telefono);
                dBNatillera.SaveChanges();
                return "Se eliminó el teléfono: " + telefono.Numero;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}