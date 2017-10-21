using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using PDVsoft.Dto;

namespace PDVsoft.Dal
{
    public class Conexion
    {
        public MySqlConnection conexion;

        public bool getConexion()
        {
            bool connection_open;
                        
            try
            {
                conexion = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=pdvsoft; Uid=root; pwd=root;");
                conexion.Open();
                connection_open = true;
            }
            catch (Exception e)
            {
                connection_open = false;
            }
            return connection_open;
        }

        public void cerrarConexion() {
            conexion.Close();
        }

        

        

    }
}
