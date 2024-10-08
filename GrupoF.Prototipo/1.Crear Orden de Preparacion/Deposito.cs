using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class Deposito
    {
        public int Id_Cliente { get; set; }
        public int Id_Deposito { get; set; }
        public string Nombre_Deposito { get; set; }
        public string Coordenadas_Deposito { get; set; }
    }
}
