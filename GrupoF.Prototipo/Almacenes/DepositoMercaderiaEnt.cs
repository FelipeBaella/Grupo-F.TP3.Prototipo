
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal class DepositoMercaderiaEnt
    {
        public int ID_DepositoMercaderia { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Deposito { get; set; }
        public int ID_Mercaderia { get; set; }
        public int Cantidad_DepositoMercaderia { get; set; }
        public string Coordenadas_DepositoMercaderia { get; set; }
    }
}
