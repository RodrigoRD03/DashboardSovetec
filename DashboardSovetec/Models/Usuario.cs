namespace MVCAdministradorSovetec.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Usuario")]
    public class Usuario
    {
        public int ID { get; set; }
        public String Nombre { get; set; }

        public string Correo { get; set; }

        public string Contraseña { get; set; }
        public int TipoUsuarioID { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual List<BitacoraUsuario> BitacorasUsuario { get; set; }
    }
}
