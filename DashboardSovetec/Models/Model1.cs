using MVCAdministradorSovetec.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DashboardSovetec.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Modelo")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<BitacoraEmpleado> BitacoraEmpleados { get; set; }
        public virtual DbSet<BitacoraUsuario> BitacoraUsuarios { get; set; }
        public virtual DbSet<Dispositivo> Dispositivos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<EmpleadoMedidor> EmpleadoMedidores { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Medidor> Medidores { get; set; }
        public virtual DbSet<Registros> Registros { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleados { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
