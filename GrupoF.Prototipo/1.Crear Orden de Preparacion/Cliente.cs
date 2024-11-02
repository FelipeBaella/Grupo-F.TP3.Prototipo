using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class Cliente
    {
        public int ID_Cliente { get; set; }
        public int Dni { get; set; }
        public string NombreApellido { get; set; }
        public long Cuit { get; set; }
        public string Domicilio { get; set; }
        public string CondIva { get; set; }
    }
}
