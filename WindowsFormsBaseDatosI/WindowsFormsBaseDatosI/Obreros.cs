using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBaseDatosI
{
    public class Obreros
    {
        public int Codigo { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public Obreros(int codigoObrero, int dniObrero, string nombreObrero)
        {
            Codigo = codigoObrero;
            Dni = dniObrero;
            Nombre = nombreObrero;
        }
    }
}
