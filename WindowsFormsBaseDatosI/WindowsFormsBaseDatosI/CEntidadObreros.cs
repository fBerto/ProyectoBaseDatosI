using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace WindowsFormsBaseDatosI
{
    public class CEntidadObreros
    {
        private string connectionString = "Data Source = DESKTOP-OL106RH\\SQLEXPRESS; Initial Catalog = constructora;" +
             "User= berto; Password = francobertoni12";

        public bool ConnectionOk()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }

}
