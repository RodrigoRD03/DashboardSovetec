namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Empresa")]
    public class Empresa
    {
        public int ID { get; set; }

        public int FechaRegistro { get; set; }

        public string RFC { get; set; }

        public string Nombre { get; set; }
        public string PersonaContacto { get; set; }
        public long TelefonoContacto { get; set; }
        public string Correo { get; set; }

        public bool Estatus { get; set; }
        public virtual List<Dispositivo> Dispositivo { get; set; }
    }
}
