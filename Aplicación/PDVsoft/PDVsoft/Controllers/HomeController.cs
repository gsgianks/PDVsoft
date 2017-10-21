using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PDVsoft.Dal;
using PDVsoft.Dto;

namespace PDVsoft.Controllers
{
    public class HomeController : Controller
    {
        private Conexion conexion = new Conexion(); 

        public ActionResult Index()
        {

            return RedirectToAction("Login", "Usuario");

            //conexion.consulta();
            //List<ParametroDto> parametros = new List<ParametroDto>();

            //ParametroDto pm = new ParametroDto
            //{
            //    codParametro = "p_codUsuario",
            //    valParametro = "ags"
            //};
            //parametros.Add(pm);
            //pm = new ParametroDto
            //{
            //    codParametro = "p_nomNombre",
            //    valParametro = "Laexander"
            //};
            //parametros.Add(pm);
            //pm = new ParametroDto
            //{
            //    codParametro = "p_desPrimerApellido",
            //    valParametro = "Gamboa"
            //};
            //parametros.Add(pm);
            //pm = new ParametroDto
            //{
            //    codParametro = "p_desSegundoApellido",
            //    valParametro = "Perez"
            //};
            //parametros.Add(pm);
            //pm = new ParametroDto
            //{
            //    codParametro = "p_codContrasena",
            //    valParametro = "Temporal123"
            //};
            //parametros.Add(pm);
            //pm = new ParametroDto
            //{
            //    codParametro = "p_desCorreo",
            //    valParametro = "aleks@gmail.com"
            //};
            //parametros.Add(pm);
            //pm = new ParametroDto
            //{
            //    codParametro = "p_desURLImagen",
            //    valParametro = "URL"
            //};
            //parametros.Add(pm);



            //conexion.ejecutarProcedimiento(parametros);







            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}