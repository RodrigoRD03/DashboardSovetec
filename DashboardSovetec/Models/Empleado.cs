namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Empleado")]
    public class Empleado
    {

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Contraseña { get; set; }

        public bool Estatus { get; set; }

        public int TipoEmpleadoID { get; set; }
        public virtual TipoEmpleado TipoEmpleado { get; set; }

        public virtual List<BitacoraEmpleado> BitacoraEmpleado { get; set; }

        public virtual List<EmpleadoMedidor> EmpleadoMedidor { get; set; }
    }
}
