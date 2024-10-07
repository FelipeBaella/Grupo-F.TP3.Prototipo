using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class ProcesarOrdenDeSeleccion_model
    {
        public List<OrdenesDeSeleccion> OrdenesDeSeleccion { get; set; } = new List<OrdenesDeSeleccion>
        {
            new OrdenesDeSeleccion {Id_Estado = 1, Id_OrdenDeSeleccion = 1, Id_OrdenDePreparacion = 1, Emision_OrdenDeSeleccion = DateTime.Now},
            new OrdenesDeSeleccion {Id_Estado = 2, Id_OrdenDeSeleccion = 2, Id_OrdenDePreparacion = 2, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(1)},
        };
    }
}
