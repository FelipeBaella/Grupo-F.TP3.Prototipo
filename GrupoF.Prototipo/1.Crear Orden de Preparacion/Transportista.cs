using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class Transportista
    {
        public int Id_Transportista { get; set; }
        public int Id_Ciente { get; set; }
        public int Dni_Transportista { get; set; }
        public string NombreApellido_Transportista { get; set; }
    }
}
