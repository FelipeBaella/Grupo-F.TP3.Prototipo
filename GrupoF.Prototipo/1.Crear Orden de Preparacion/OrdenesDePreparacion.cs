using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class OrdenesDePreparacion
    {
        public int Id_OrdenDePreparacion { get; set; }
        public int Id_Estado { get; set; }
        public bool Prioridad_OrdenDePreparacion { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Emision_OrdenDePreparacion { get; set; }
        public int Id_Mercaderia { get; set; }
        public int Cantidad_OrdenDePreparacion { get; set; }
        public int Id_Deposito { get; set; }
        public int Id_Transportista { get; set; }
        public int? Id_Remito { get; set; }
    }
}
