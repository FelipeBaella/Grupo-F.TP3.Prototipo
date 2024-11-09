using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal class OrdenDeSeleccionEnt
    {
        public int ID_OS { get; set; }
        public EstadoOSEnum Estado_OS { get; set; }
        public DateTime Fecha_EmisionOS { get; set; }
        public DateTime FechaActualizacion_EstadoOS { get; set; }
        public List<int> OrdenesPreparacion_OS { get; set; }

    }
}
