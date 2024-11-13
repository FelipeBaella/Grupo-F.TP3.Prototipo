
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
        public List<ClienteEnt> ObtenerClientes()
        {
            var lista = ClienteAlmacen.Clientes.ToList();

            return lista;
        }

        public List<OrdenDePreparacionEnt> ObtenerOPs()
        {
            var lista = OrdenDePreparacionAlmacen.OrdenesDePreparacion.ToList();

            return lista;
        }

        public List<MercaderiaEnt> ObtenerMercaderias()
        {
            var lista = MercaderiaAlmacen.Mercaderias.ToList();

            return lista;
        }



        public string CrearOrdenesDeSeleccion(List<int> Ops)
        {
            var ordenesDeSeleccion = new OrdenDeSeleccionEnt();

            ordenesDeSeleccion.Estado_OS = EstadoOSEnum.Emitida;
            var Fecha_EmisionOS = DateTime.Now.Date;
            var FechaActualizacion_EstadoOS = DateTime.Now.Date;

            if (Fecha_EmisionOS < DateTime.Now.Date)
            {
                return "La fecha de emision no puede ser menor al dia de hoy.";
            }

            if (FechaActualizacion_EstadoOS < DateTime.Now.Date)
            {
                return "La fecha de actualizacion de Estado_OP no puede ser menor al dia de hoy.";
            }

            var OS = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion;
            var ID_OS = 1;

            if (OS.Count > 0)
            {
                ID_OS = OS.Last().ID_OS + 1;
            }
            ordenesDeSeleccion.ID_OS = ID_OS;


            foreach (var item in Ops)
            {
                var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.Seleccionada;
            }

            ordenesDeSeleccion.OrdenesPreparacion_OS = Ops;
            ordenesDeSeleccion.Fecha_EmisionOS = Fecha_EmisionOS;
            ordenesDeSeleccion.FechaActualizacion_EstadoOS = FechaActualizacion_EstadoOS;

            OrdenDeSeleccionAlmacen.Nueva(ordenesDeSeleccion);

            Program.Grabar();

            return null;
        }
    }

}
