using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class OrdenesDePreparacionItems
    {
        public int? Id_OrdenDePreparacionMercaderia { get; set; }
        public int Id_OrdenDePreparacion { get; set; }
        public int Id_DepositoMercaderias { get; set; }
        public int Cantidad_Mercaderia { get; set; }
    }
}
