﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AcadmixEntities : DbContext
    {
        public AcadmixEntities()
            : base("name=AcadmixEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<PerfilesVistas> PerfilesVistas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vistas> Vistas { get; set; }
        public virtual DbSet<EstadosUsuarios> EstadosUsuarios { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Asignatura> Asignatura { get; set; }
        public virtual DbSet<Asignatura_Pensum> Asignatura_Pensum { get; set; }
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Calificacion> Calificacion { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Dependencia> Dependencia { get; set; }
        public virtual DbSet<Dia_Semana> Dia_Semana { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Listado_Estudiantes> Listado_Estudiantes { get; set; }
        public virtual DbSet<Maestro> Maestro { get; set; }
        public virtual DbSet<Modalidad> Modalidad { get; set; }
        public virtual DbSet<Pensum> Pensum { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<Publicacion> Publicacion { get; set; }
        public virtual DbSet<Seccion_Asignatura> Seccion_Asignatura { get; set; }
        public virtual DbSet<SeccionHorarioDetalle> SeccionHorarioDetalle { get; set; }
        public virtual DbSet<Tipo_Aula> Tipo_Aula { get; set; }
        public virtual DbSet<Trimestre> Trimestre { get; set; }
    }
}
