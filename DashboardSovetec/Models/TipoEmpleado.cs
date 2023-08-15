namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoEmpleado")]
    public class TipoEmpleado
    {
        public int ID { get; set; }

        public string Rol { get; set; }

        public virtual List<Empleado> Empleados { get; set; }
    }
}
