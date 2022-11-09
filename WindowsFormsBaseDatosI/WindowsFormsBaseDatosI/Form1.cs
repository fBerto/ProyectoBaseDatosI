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
            dgvObreros.AutoGenerateColumns = true;

            HacerVisibleColumnaEliminar(true);

            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetTablaObreros();
        }

        private void HacerVisibleColumnaEliminar(bool esVisible)
        {
            UtilidadesGrilla utilidad = new UtilidadesGrilla();
            int indiceEliminar = utilidad.ObtenerIndice(dgvObreros, "Eliminar");

            dgvObreros.Columns[indiceEliminar].Visible = esVisible;
        }

        private void ResumenesObras_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;

            HacerVisibleColumnaEliminar(false);

            string vista = "view_ObrerosPorObras";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetVista(vista);
        }

        private void ProcedimientoAlmacenado_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;

            HacerVisibleColumnaEliminar(false);

            string procedimiento = "P_direccionProvedores";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetProcedimiento(procedimiento);
        }

        private void dgvObreros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UtilidadesGrilla utilidad = new UtilidadesGrilla();

            int indiceEliminar = utilidad.ObtenerIndice(dgvObreros, "Eliminar");

            if (e.RowIndex >= 0)
            {
                Obreros obreroSeleccionado = dgvObreros.Rows[e.RowIndex].DataBoundItem as Obreros;
                int codigoObrero = obreroSeleccionado.Codigo;

                if (indiceEliminar == e.ColumnIndex)
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el obrero?", "Eliminar obrero", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        UtilidadesObreros utilidadesObreros = new UtilidadesObreros();
                        utilidadesObreros.EliminarObrero(codigoObrero);

                        ActualizarGrilla();
                    }
                }
            }
        }

        private void obrerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void resumenesObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;

            HacerVisibleColumnaEliminar(false);

            string vista = "view_ObrerosPorObras";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetVista(vista);
        }

        private void resumenProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvObreros.AutoGenerateColumns = true;

            HacerVisibleColumnaEliminar(false);

            string procedimiento = "P_direccionProvedores";
            UtilidadesObreros TablaObreros = new UtilidadesObreros();
            dgvObreros.DataSource = null;
            dgvObreros.DataSource = TablaObreros.GetProcedimiento(procedimiento);
        }
    }
}
