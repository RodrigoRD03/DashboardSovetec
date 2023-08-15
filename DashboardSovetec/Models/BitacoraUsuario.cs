using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace MVCAdministradorSovetec.Models
{
    [TableName("BitacoraUsuario")]
    public class BitacoraUsuario
    {
        public int ID { get; set; }

        public string Observaciones { get; set; }

        public int Fecha { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}