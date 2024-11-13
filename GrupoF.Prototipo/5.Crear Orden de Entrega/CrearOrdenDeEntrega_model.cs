

using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._5.Crear_Orden_deEntrega
{
    internal class CrearOrdenDeEntrega_model
    {
        // EL NUEVO
        public static string CrearOrdenesDeEntrega2(List<int> Ordenespreparacion_OE)
        {

            var ordenDeEntrega = new OrdenDeEntregaEnt();

            var FechaEmision_OE = DateTime.Now.Date;

            var OE = OrdenDeEntregaAlmacen.OrdenesDeEntrega;
            var ID_OE = 1;

            if (OE.Count > 0)
            {
                ID_OE = OE.Last().ID_OE + 1;
            }

            var OrdenesDePreparacion = ordenDeEntrega.OrdenesPreparacion_OE;

            foreach (var item in OrdenesDePreparacion)
            {
                var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.EnDespacho; // Verificar
            }

            ordenDeEntrega.OrdenesPreparacion_OE = OrdenesDePreparacion;
            ordenDeEntrega.ID_OE = ID_OE;
            ordenDeEntrega.FechaEmision_OE = FechaEmision_OE;

            OrdenDeEntregaAlmacen.Nueva(ordenDeEntrega);

            Program.Grabar();

            return null; //?? Validar si es eso o: return ordenDeEntrega.ID_OE.ToString();

        }

        // EL ORIGINAL
        public static string CrearOrdenesDeEntrega(OrdenDeEntregaEnt ordenesDeEntrega)
        {
            var OE = OrdenDeEntregaAlmacen.OrdenesDeEntrega.ToList();

            var ID_OE = 1;

            if (OE.Count > 0) 
            {
                ID_OE = OE.Last().ID_OE + 1;
            }

            ordenesDeEntrega.ID_OE = ID_OE;

            var FechaEmision_OE = ordenesDeEntrega.FechaEmision_OE;

            OrdenDeEntregaAlmacen.Nueva(ordenesDeEntrega);

            var OPs = ordenesDeEntrega.OrdenesPreparacion_OE;


            foreach(var op in OPs)
            {
                var OP = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == op).SingleOrDefault();

                OP.Estado_OP = EstadoOPEnum.EnDespacho;
            }

            Program.Grabar();

            return null;
        }
    }
}
