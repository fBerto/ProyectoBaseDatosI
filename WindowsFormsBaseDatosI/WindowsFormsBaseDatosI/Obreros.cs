using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBaseDatosI
{
    public class Obreros
    {
        public int CodigoObrero { get; set; }
        public int DniObrero { get; set; }
        public string NombreObrero { get; set; }
        public Obreros(int codigoObrero, int dniObrero, string nombreObrero)
        {
            CodigoObrero = codigoObrero;
            DniObrero = dniObrero;
            NombreObrero = nombreObrero;
        }
    }
}
