//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class LogError
    {
        public int idLogError { get; set; }
        public int idUsuario { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
        public string StackTrace { get; set; }
        public string Origen { get; set; }
        public string Tipo { get; set; }
    }
}