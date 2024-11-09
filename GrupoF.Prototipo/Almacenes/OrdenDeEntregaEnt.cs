using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal class OrdenDeEntregaEnt
    {
        public int ID_OE { get; set; }
        public DateTime FechaEmision_OE { get; set; }
        public List<int> OrdenesPreparacion_OE { get; set; }

    }
}
