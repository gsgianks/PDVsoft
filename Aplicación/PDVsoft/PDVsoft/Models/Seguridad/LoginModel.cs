using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PDVsoft.Models.Seguridad
{
    public class LoginModel
    {
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El usuario es requerido")]
        public string cocUsuario { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string codContrasena { get; set; }

        public bool indAutenticado { get; set; }
    }
}