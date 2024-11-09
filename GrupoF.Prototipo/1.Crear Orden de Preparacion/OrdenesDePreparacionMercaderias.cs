using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class OrdenesDePreparacionItems
    {
        public int? ID_OPMercaderia { get; set; }
        public int ID_OP { get; set; }
        public int ID_Mercaderia { get; set; }
        public int ID_DepositoMercaderia { get; set; }
        public int Cantidad_Mercaderia { get; set; }
    }
}
