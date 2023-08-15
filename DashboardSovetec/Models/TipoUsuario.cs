namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        public int ID { get; set; }
        public string Rol { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }
    }
}
