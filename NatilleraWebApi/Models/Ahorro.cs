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
    
    public partial class Ahorro
    {
        public int AhorroId { get; set; }
        public decimal Ahorro1 { get; set; }
        public System.DateTime FechaPago { get; set; }
        public System.DateTime FechaEstimada { get; set; }
        public int UsuarioId { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}