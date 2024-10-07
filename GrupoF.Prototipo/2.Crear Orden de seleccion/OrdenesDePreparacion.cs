using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._2.Crear_Orden_de_seleccion
{
    internal class OrdenDePreparacion
    {
        public int Id_OrdenDePreparacion { get; set; }
        public int Id_Estado { get; set; }
        public bool Prioridad_OrdenDePreparacion { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Emision_OrdenDePreparacion { get; set; }
        public int Id_Mercaderia { get; set; }
        public int Cantidad_OrdenDePreparacion { get; set; }
        public int Id_Deposito { get; set; }
    }
}
