using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsBaseDatosI
{
    public class CConexion
    {
        private string conn;
        public string strCon(string NombreBaseDatos)
        {
            conn = ConfigurationManager.ConnectionStrings[NombreBaseDatos].ConnectionString;
            return conn;
        }

    }
}
