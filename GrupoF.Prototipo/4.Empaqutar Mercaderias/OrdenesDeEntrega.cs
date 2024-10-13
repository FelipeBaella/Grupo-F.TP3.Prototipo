using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class OrdenesDeEntrega
    {
        public int Id_OrdenDeEntrega { get; set; }
        public int Id_Estado{ get; set; }
        public int Id_OrdenDePreparacion { get; set; }
        public DateTime Emision_OrdenDeEntrega { get; set; }
    }
}
