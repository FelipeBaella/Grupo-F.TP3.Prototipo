using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal class RemitoEnt
    {
        public int ID_Remito { get; set; }
        public DateTime FechaEmision_Remito { get; set; }
        public List<int> OrdenesPreparacion_Remito { get; set; }

    }
}
