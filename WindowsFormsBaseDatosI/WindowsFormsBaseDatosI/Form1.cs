using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsBaseDatosI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BaseConectada_Click(object sender, EventArgs e)
        {
            UtilidadesObreros cEntidadObreros = new UtilidadesObreros();
            if (cEntidadObreros.ConnectionOk())
            {
                MessageBox.Show("conectado");
            } else
            {
                MessageBox.Show("no conectado");
            }
        }

        private void Form_LoadTablaObreros(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvObreros.AutoGenerateColumns = true;
            labelNombreTabla.Text = "Tabla de Obreros";

            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetTablaObreros();
        }

        private void ResumenesObras_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;
            labelNombreTabla.Text = "Resumen de Obras";

            string vista = "view_ObrerosPorObras";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetVista(vista);
        }

        private void ProcedimientoAlmacenado_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;
            labelNombreTabla.Text = "Proveedores con materiales registrados";

            string procedimiento = "P_direccionProvedores";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetProcedimiento(procedimiento);
        }

        private void obrerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void resumenesObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;

            string vista = "view_ObrerosPorObras";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetVista(vista);
        }

        private void resumenProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;

            string procedimiento = "P_direccionProvedores";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetProcedimiento(procedimiento);
        }

        private void buttonCargarObrero_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            int dni = int.Parse(textBoxDNI.Text);

            Obreros nuevoObrero = new Obreros(0, dni, nombre);
            
            UtilidadesObreros utilidad = new UtilidadesObreros();
            utilidad.CargarObrero(nuevoObrero);

            ActualizarGrilla();
        }
    }
}
