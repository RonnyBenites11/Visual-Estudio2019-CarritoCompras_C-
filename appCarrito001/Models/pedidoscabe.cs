//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appCarrito001.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedidoscabe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedidoscabe()
        {
            this.pedidosdeta = new HashSet<pedidosdeta>();
            this.pedidosdeta1 = new HashSet<pedidosdeta>();
        }
    
        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public System.DateTime FechaPedido { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public string EnvioPedido { get; set; }
        public Nullable<int> CantidaPedido { get; set; }
        public string Destinatario { get; set; }
        public string DirDestinatario { get; set; }
        public string CiuDestinatario { get; set; }
        public string RefDestnatario { get; set; }
        public string DepDestinatario { get; set; }
        public string PaiDestinatario { get; set; }
    
        public virtual empleados empleados { get; set; }
        public virtual empleados empleados1 { get; set; }
        public virtual clientes clientes { get; set; }
        public virtual clientes clientes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedidosdeta> pedidosdeta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedidosdeta> pedidosdeta1 { get; set; }
    }
}
