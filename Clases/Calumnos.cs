
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CrudSqlServer.Clases
{
    internal class Calumnos
    {
        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {

            Cconexion objetoConexion = new Cconexion();

            try
            {
                tablaAlumnos.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter("select * from alumnos",
                                                            objetoConexion.establecerConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaAlumnos.DataSource = dt;

                objetoConexion.cerrarConexion();



              
            }catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar la conexion, error: " + ex.ToString());
            }
        }

        public void guardarAlumnos(TextBox paramDNI,TextBox paramNombre,TextBox paramApellidos, TextBox paramEdad)
        {

            Cconexion objetoConexion = new Cconexion();

            try
            {
                String Query = "insert into alumnos (dni,nombre,apellidos,edad)" +
                    "values('" + paramDNI.Text + "','" + paramNombre.Text + "','" + paramApellidos.Text + "','" + paramEdad.Text + "');";
                
                SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                SqlDataReader myReady;
                myReady = myComando.ExecuteReader();

                while (myReady.Read())
                {

                }

                MessageBox.Show("Se guardo correctamente ");
                objetoConexion.cerrarConexion();




            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar la conexion, error: " + ex.ToString());
            }
        }
        public void seleccionarAlumnos(DataGridView tablaAlumnos,TextBox paramCodigo,TextBox paramDNI, TextBox paramNombre, TextBox paramApellidos, TextBox paramEdad)
        {

            try
            {
                paramCodigo.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                paramDNI.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                paramNombre.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
                paramApellidos.Text = tablaAlumnos.CurrentRow.Cells[3].Value.ToString();
                paramEdad.Text = tablaAlumnos.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar la conexion, error: " + ex.ToString());
            }
        }


        public void modificarAlumnos(TextBox paramID,TextBox paramDNI, TextBox paramNombre, TextBox paramApellidos, TextBox paramEdad)
        {

            Cconexion objetoConexion = new Cconexion();

            try
            {
                String Query = "update alumnos set alumnos.dni='" +
                    paramDNI.Text + "',alumnos.nombre='" + paramNombre.Text + "',alumnos.apellidos='"+ paramApellidos.Text + "',alumnos.edad='"+paramEdad.Text + "'where alumnos.codigo='" + paramID.Text+"';";
               
                SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                SqlDataReader myReady;
                myReady = myComando.ExecuteReader();

                while (myReady.Read())
                {

                }

                MessageBox.Show("Se modifico correctamente ");
                objetoConexion.cerrarConexion();




            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar la conexion, error: " + ex.ToString());
            }
        }

        public void eliminarAlumnos(TextBox paramID)
        {

            Cconexion objetoConexion = new Cconexion();

            try
            {
                String Query = "delete from alumnos where alumnos.codigo= '"+paramID.Text+"';";


                SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                SqlDataReader myReady;
                myReady = myComando.ExecuteReader();

                while (myReady.Read())
                {

                }

                MessageBox.Show("Se elimino correctamente ");
                objetoConexion.cerrarConexion();




            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro eliminar la conexion, error: " + ex.ToString());
            }
        }

    }
}
