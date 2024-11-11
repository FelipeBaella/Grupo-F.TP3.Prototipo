
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    internal class CrearOrdenDeSeleccion_model
    {

        public string CrearOrdenesDeSeleccion(OrdenDeSeleccionEnt ordenesDeSeleccion)
        {
            var Estado_OP = ordenesDeSeleccion.Estado_OS;
            var Emision_OrdenDeSeleccion = ordenesDeSeleccion.Fecha_EmisionOS;
            var AcualizacionEstado_OrdenDeSeleccion = ordenesDeSeleccion.FechaActualizacion_EstadoOS;

            ordenesDeSeleccion.Estado_OS = EstadoOSEnum.Emitida;

            if (Emision_OrdenDeSeleccion < DateTime.Now.Date)
            {
                return "La fecha de emision no puede ser menor al dia de hoy.";
            }

            if (AcualizacionEstado_OrdenDeSeleccion < DateTime.Now.Date)
            {
                return "La fecha de actualizacion de Estado_OP no puede ser menor al dia de hoy.";
            }

            var OS = GrupoF.Prototipo.Almacenes.OrdenDeSeleccionAlmacen.OrdenesDeSeleccion;

            if (OS.Count > 0)
            {
                ordenesDeSeleccion.ID_OS = OS.Last().ID_OS + 1;
            }
            else
            {
                ordenesDeSeleccion.ID_OS = 1;
            }

            var OrdenDePreparacion = ordenesDeSeleccion.OrdenesPreparacion_OS;

            foreach (var item in OrdenDePreparacion)
            {
                var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.Seleccionada;
            }


            OrdenDeSeleccionAlmacen.Nueva(ordenesDeSeleccion);

            Program.Grabar();

            return null;
        }
    }

}
