namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dispositivo")]
    public class Dispositivo
    {
        public int ID { get; set; }

        public int NumeroSerie { get; set; }
        public int FechaRegistro { get; set; }
        public bool Estatus { get; set; }
        public int EmpresaID { get; set; }

        public int? MedidorID { get; set; }

        public virtual Medidor Medidor { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
