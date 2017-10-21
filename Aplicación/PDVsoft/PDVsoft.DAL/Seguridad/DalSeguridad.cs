using PDVsoft.Dal.General;
using PDVsoft.Dto;
using System;
using System.Collections.Generic;
using System.Data;

namespace PDVsoft.Dal
{
    public class DalSeguridad : Consultas
    {
        public DataTable Autenticar(string usuario) {

            List<ParametroDto> parametros = new List<ParametroDto>();

            parametros.Add(new ParametroDto { codParametro = "p_codUsuario", valParametro = usuario });

            return Select(parametros, "spsegObtenerUsuario");
        }
    }
}
