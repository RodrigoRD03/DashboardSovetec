namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Registros")]

    public class Registros
    {
        public int ID { get; set; }

        public int Fecha { get; set; }

        public string Contenido { get; set; }

        public int MedidorID { get; set; }

        public virtual Medidor Medidor { get; set; }
    }
}
