
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class ProcesarOrdenDeSeleccion_model
    {
        public static string EditarEstadoOS(int id)
        {
            var ordenesDeSeleccion = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion.Where(x => x.ID_OS == id).SingleOrDefault();

            ordenesDeSeleccion.Estado_OS = EstadoOSEnum.Cumplida;

            var OrdenesDeSeleccion = ordenesDeSeleccion.OrdenesPreparacion_OS;

            foreach(var orden in OrdenesDeSeleccion)
            {
                var OrdenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == orden).SingleOrDefault();

                OrdenDePreparacion.Estado_OP = EstadoOPEnum.EnPreparacion;
            }

            Program.Grabar();
        
            return null;
        }

    }
}
