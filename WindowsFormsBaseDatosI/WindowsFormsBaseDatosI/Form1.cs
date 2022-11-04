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

        private void button1_Click(object sender, EventArgs e)
        {
            CEntidadObreros cEntidadObreros = new CEntidadObreros();
            if (cEntidadObreros.ConnectionOk())
            {
                MessageBox.Show("conectado");
            }
            else
                MessageBox.Show("no conectado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            CEntidadObreros TablaObreros = new CEntidadObreros();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TablaObreros.GetTablaObreros();
        }
    }
}
