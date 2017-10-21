using PDVsoft.Dal;
using PDVsoft.Dto.General;
using System;
using System.Data;

namespace PDVsoft.Bll
{
    public class BllSeguridad
    {

        DalSeguridad dalSeguridad;

        public BllSeguridad() {
            dalSeguridad = new DalSeguridad();
        }

        public DatosRespuestaDto Autenticar(string usuario) {
            DatosRespuestaDto datos = new DatosRespuestaDto();

            try
            {
                DataTable dt = dalSeguridad.Autenticar(usuario);
                foreach (DataRow ro in dt.Rows)
                {

                    String nombre = ro["nomNombre"].ToString();
                }

            }
            catch (Exception e)
            {
                datos.Estado = false;
                datos.Codigo = "99";
                datos.Descripcion = "Error no controlado. Detalle: " + e.Message;
            }

            return datos;
        }
    }
}
