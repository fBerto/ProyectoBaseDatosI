﻿using System;
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
    public class UtilidadesObreros : UtilidadesBaseDatos
    {
        public List<Obreros> GetTablaObreros()
        {
            List<Obreros> obreros = new List<Obreros>();
            string query = "select CodigoObrero,DniObrero,NombreObrero from Obrero";
            using (SqlConnection connection = ObtenerConecionSQL())
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int codigo = reader.GetInt32(0);// si lo demajos tipo  reader[0]; obtenemos un objeto
                        int dni = reader.GetInt32(1);
                        string nombre = reader.GetString(2);

                        Obreros obrero = new Obreros(codigo, dni, nombre);

                        obreros.Add(obrero);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error" + ex.Message);
                }
            }
            return obreros;
        }

    }

}
