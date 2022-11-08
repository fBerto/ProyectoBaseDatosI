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
        private string pathConneccion = "Data Source = THINKPAD_FEDE; Initial Catalog = constructora;" +
             "User= sa; Password = wnwCWPF3nJDHff";

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

        public void deleteRow(string table, string columnName, string IDNumber)
        {
            try
            {
                using (SqlConnection con = ObtenerConecionSQL())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + columnName + " = '" + IDNumber + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
