using MySql.Data.MySqlClient;
using PDVsoft.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PDVsoft.Dal.General
{
    public class Consultas: Conexion
    {
        public bool consulta()
        {
            try
            {
                if (getConexion())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = "spObtenerUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow ro in dt.Rows)
                    {

                        String nombre = ro["nomNombre"].ToString();
                    }
                    return true;
                }

            }
            catch (MySqlException e)
            {
                return false;
            }



            return true;
        }


        public bool ejecutarProcedimiento(List<ParametroDto> parametros)
        {

            getConexion();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "spInsertarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (ParametroDto parametro in parametros)
            {
                cmd.Parameters.AddWithValue(parametro.codParametro, parametro.valParametro);
            }

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public DataTable Select(List<ParametroDto> parametros, string procedimiento) {
            DataTable dt = new DataTable();

            if (getConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = procedimiento;
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                cerrarConexion();
            }

            return dt;
        }
    }
}
