namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Medidor")]
    public class Medidor
    {

        public int ID { get; set; }

        public string NumeroSerie { get; set; }

        public int FechaResgistro { get; set; }

        public bool Estatus { get; set; }

        public double Longitud { get; set; }

        public double Latitud { get; set; }
        public virtual List<Dispositivo> Dispositivos { get; set; }
        public virtual List<Registros> Registros { get; set; }
        public virtual List<EmpleadoMedidor> EmpleadoMedidores { get; set; }
    }
}
