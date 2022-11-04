﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Security.Policy;

namespace WindowsFormsBaseDatosI
{
    public class CEntidadObreros
    {
        private string connectionString = "Data Source = DESKTOP-OL106RH\\SQLEXPRESS; Initial Catalog = constructora;" +
             "User= berto; Password = francobertoni12";
        public SqlConnection ObtenerConecionSQL()
        {
            SqlConnection connection = new SqlConnection(connectionString);
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
                        Obreros obrero = new Obreros();
                        obrero.CodigoObrero = reader.GetInt32(0);// si lo demajos tipo  reader[0]; obtenemos un objeto
                        obrero.DniObrero = reader.GetInt32(1);
                        obrero.NombreObrero = reader.GetString(2);
                        obreros.Add(obrero);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Error" + ex.Message);
                }
            }
            return obreros;
        }
       
    }

}
