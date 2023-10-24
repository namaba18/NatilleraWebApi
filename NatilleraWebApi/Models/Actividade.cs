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
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Actividade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividade()
        {
            this.Usuarios = new HashSet<Usuario>();
        }
    
        public int ActividadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; set; }
        public int Encargado { get; set; }
        public int TipoActividadId { get; set; }
    
        public virtual TipoActividad TipoActividad { get; set; }
        public virtual Usuario Usuario { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}