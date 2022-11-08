using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Security.Policy;
using System.Collections;

namespace WindowsFormsBaseDatosI
{
    public class UtilidadesBaseDatos
    {

        private string pathConneccion = "Data Source = DESKTOP-OL106RH\\SQLEXPRESS; Initial Catalog = constructora;" +
             "User= berto; Password = francobertoni12";

        public SqlConnection ObtenerConecionSQL()
        {
            SqlConnection connection = new SqlConnection(pathConneccion);
            return connection;
        }

        public bool ConnectionOk()
        {
            try
            {
                SqlConnection connection = ObtenerConecionSQL();
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable GetVista(string vista )
        {
            DataTable TablaGenerada = new DataTable();

            string query = "select * from " + vista;

            using (SqlConnection connection = ObtenerConecionSQL())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    TablaGenerada.Load(command.ExecuteReader());
                }
                connection.Close();
            }
            return TablaGenerada;
        }

        public DataTable GetProcedimiento(string procedimiento )
        {
            DataTable TablaGenerada = new DataTable();

            string query = "EXEC "+ procedimiento;

            using (SqlConnection connection = ObtenerConecionSQL())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    TablaGenerada.Load(command.ExecuteReader());
                }
                connection.Close();
            }
            return TablaGenerada;
        }
    }
}
