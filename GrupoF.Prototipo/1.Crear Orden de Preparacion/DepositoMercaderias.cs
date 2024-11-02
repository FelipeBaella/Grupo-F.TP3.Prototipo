using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class DepositoMercaderias
    {
        public int ID_DepositoMercaderias { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Deposito { get; set; }
        public int ID_Mercaderia { get; set; }
        public int Cantidad_DepositoMercaderias { get; set; }
        public string Coordenadas_DepositoMercaderias { get; set; }
    }
}
