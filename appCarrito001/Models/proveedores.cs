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
    
    public partial class proveedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proveedores()
        {
            this.productos = new HashSet<productos>();
        }
    
        public int IdProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string DirProveedor { get; set; }
        public string NomContacto { get; set; }
        public string CargoContacto { get; set; }
        public string idpais { get; set; }
        public string fonoProveedor { get; set; }
        public string FaxProveedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productos> productos { get; set; }
        public virtual paises paises { get; set; }
    }
}
