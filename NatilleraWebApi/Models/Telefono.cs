//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NatilleraWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefono
    {
        public int TelefonoId { get; set; }
        public string Numero { get; set; }
        public int TipoTelId { get; set; }
        public int UsuarioId { get; set; }
    
        public virtual TipoTel TipoTel { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
