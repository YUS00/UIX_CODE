//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace G7_Orders
{
    using System;
    using System.Collections.Generic;
    
    public partial class Planets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Planets()
        {
            this.OrdersDetail = new HashSet<OrdersDetail>();
        }
    
        public int idPlanet { get; set; }
        public string CodePlanet { get; set; }
        public string DescPlanet { get; set; }
        public Nullable<int> idSector { get; set; }
        public string @long { get; set; }
        public string lat { get; set; }
        public string parsecs { get; set; }
        public Nullable<int> idNatives { get; set; }
        public Nullable<int> idFiliation { get; set; }
        public string PlanetPicture { get; set; }
        public string IPPlanet { get; set; }
        public string PortPlanet { get; set; }
        public string PortPlanet1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
