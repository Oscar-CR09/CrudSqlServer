using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSqlServer.Clases
{
    internal class Cconexion
    {
        SqlConnection conex = new SqlConnection();
        static string servidor = "localhost";
        static string bd = "colegioDB";
        static string usuario = "root3";
        static string contrasena = "root3";
        static string puerto = "50648";

        string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + contrasena + ";" + "Initial Catalog=" + bd + ";" + "Persist Security info= true";

        public SqlConnection establecerConexion()
        { 
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
               // MessageBox.Show("Se conecto correctamente a la base de Datos ");

            }
            catch (SqlException ex){ 

            MessageBox.Show("no se conecto correctamente a la base de datos: "+ ex.ToString());
        
            }

            return conex;

        }

        public void cerrarConexion()
        {
            conex.Close();

        }

    }
}
