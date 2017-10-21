using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDVsoft.Models.Seguridad
{
    public class UsuarioModel
    {
        #region Variables
        public string codUsuario { get; set; }
        public string nomNombre { get; set; }
        public string desPrimerApellido { get; set; }
        public string desSergundoApellido { get; set; }
        public string codContrasena { get; set; }
        public string desCorreo { get; set; }
        public string desURLImagen { get; set; }
        #endregion
    }
}