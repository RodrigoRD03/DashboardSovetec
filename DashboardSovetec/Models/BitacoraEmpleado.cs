namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BitacoraEmpleado")]
    public partial class BitacoraEmpleado
    {
        public int ID { get; set; }

        public string Observaciones { get; set; }

        public int Fecha { get; set; }

        public int EmpleadoID { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
