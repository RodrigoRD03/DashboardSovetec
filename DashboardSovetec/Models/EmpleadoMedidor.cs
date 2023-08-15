namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EmpleadoMedidor")]
    public class EmpleadoMedidor
    {
        public int ID { get; set; }

        public bool Estatus { get; set; }

        public int UsuarioID { get; set; }

        public int MedidorID { get; set; }

        public virtual Medidor Medidor { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
