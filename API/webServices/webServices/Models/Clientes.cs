//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal LimiteCredito { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int Categoria { get; set; }
        public string CorreoContacto { get; set; }
    }
}
