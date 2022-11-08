using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }
            else
                MessageBox.Show("no conectado");
        }

        private void Form_LoadTablaObreros(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TablaObreros.GetTablaObreros();
        }

        private void ResumenesObras_Click(object sender, EventArgs e)
        {
            string vista = "view_ObrerosPorObras";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TablaObreros.GetVista(vista);
        }

        private void ProcedimientoAlmacenado_Click(object sender, EventArgs e)
        {
            string procedimiento = "P_direccionProvedores";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TablaObreros.GetProcedimiento(procedimiento);
        }

        private void agregarObrero_Click(object sender, EventArgs e)
        {

        }

        private void botonEliminarObrero_Click(object sender, EventArgs e)
        {

        }
    }
}
