//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seccion_Asignatura
    {
        public int idSeccion { get; set; }
        public int codigoSeccion { get; set; }
        public string descripcion { get; set; }
        public int idModalidad { get; set; }
        public int capacidadMax { get; set; }
        public int idAsignatura { get; set; }
        public int idMaestro { get; set; }
        public bool esActivo { get; set; }
    }
}
