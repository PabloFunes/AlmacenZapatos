//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlmacenZapatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Nullable<System.DateTime> Fecha_Entrada { get; set; }
        public string Lote { get; set; }
        public string Modelo { get; set; }
        public int Stock { get; set; }
        public string Merma { get; set; }
        public string Proveedor { get; set; }
        public int Inventario_Real { get; set; }
    }
}