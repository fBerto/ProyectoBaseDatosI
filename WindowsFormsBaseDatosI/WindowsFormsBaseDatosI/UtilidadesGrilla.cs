using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBaseDatosI
{
    public class UtilidadesGrilla
    {
        public void CargarCamposAcciones(DataGridView grilla)
        {
            int indiceColumnaEliminar = ObtenerIndice(grilla, "Eliminar");

            foreach (DataGridViewRow row in grilla.Rows)
            {
                row.Cells[indiceColumnaEliminar].Value = "Eliminar";
            }
        }

        public int ObtenerIndice(DataGridView grilla, string nombreColumna)
        {
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                if (column.Name == nombreColumna)
                {
                    return column.Index;
                }
            }
            return -1;
        }
    }
}
