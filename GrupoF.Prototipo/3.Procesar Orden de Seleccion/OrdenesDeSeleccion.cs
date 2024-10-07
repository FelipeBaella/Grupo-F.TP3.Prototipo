using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class OrdenesDeSeleccion
    {
        public int Id_OrdenDeSeleccion { get; set; }
        public int Id_Estado{ get; set; }
        public int Id_OrdenPreparacion { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Emision_OrdenDeSeleccion { get; set; }
        public int Id_Mercaderia { get; set; }
        public int Id_Deposito { get; set; }
    }
}
