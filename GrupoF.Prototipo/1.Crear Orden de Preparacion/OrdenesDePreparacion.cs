using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class OrdenesDePreparacion
    {
        public int ID_OP { get; set; }
        public EstadoOPEnum Estado_OP { get; set; }
        public bool Prioridad_OP { get; set; }  
        public int ID_Cliente { get; set; }
        public DateTime FechaEmision_OP { get; set; }
        public DateTime FechaEntrega_OP { get; set; }
        public DateTime FechaActualizacionEstado_OP { get; set; }
        public int ID_Deposito { get; set; }
        public int Dni_transportista { get; set; }  
        public int? ID_OS { get; set; }
        public int? ID_OE { get; set; }
        public int? ID_Remito { get; set; }  
        public List<OrdenesDePreparacionItems> Mercaderias_OP { get; set; }
  
    }
}
