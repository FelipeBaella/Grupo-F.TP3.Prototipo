
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    internal class DespacharMercaderias_model
    {
        // Nuevo
        public static string CrearRemito2(List<int> Ordenespreparacion_Remito)
        {

            var Remito = new RemitoEnt();

            var FechaEmision_Remito = DateTime.Now.Date;
            
            var remito = RemitoAlmacen.Remitos;
            var ID_Remito = 1;

            if (remito.Count > 0)
            {
                ID_Remito= remito.Last().ID_Remito + 1;
            }

            var Remitos;

            var OrdenesDePreparacion = ordenDeEntrega.OrdenesPreparacion_OE;

            foreach (var item in OrdenesDePreparacion)
            {
                var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.EnDespacho; // Verificar
            }


            //remito.id_remito = id_remito;
            //var fechaemision_remito = datetime.now.date;
            //remito.fechaemision_remito = fechaemision_remito;

            // TODO FALTA ITERAR PARA OBTENER LOS ID DE LAS OP ASOCIADAS A LOS REMITOS

            //var ordenespreparacion_oe = new List<OrdenesPreparacion_OE>();

            //foreach (var opId in Ordenespreparacion_OE){}


            var remito = RemitoAlmacen.Remitos.ToList();

            if (remito.Count > 0)
            {
                Remito.ID_Remito = remito.Last().ID_Remito + 1;
            }
            else
            {
                Remito.ID_Remito = 1;
            }

            RemitoAlmacen.Nueva(Remito);

            Program.Grabar();

            return null; //?? Validar si es eso o: return Remito.ID_Remito.ToString();

        }

        // Original
        public static string CrearRemito(RemitoEnt remito)
        {
            var remitos = RemitoAlmacen.Remitos;

            var id_remito = 1;
            
            if (remitos.Count > 0) 
            {
                id_remito = remitos.Last().ID_Remito + 1;
            }

            remito.ID_Remito = id_remito;
            var OrdenDePreparacion = remito.OrdenesPreparacion_Remito;

            RemitoAlmacen.Nueva(remito);

            foreach (var item in OrdenDePreparacion)
            {
                var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.Despachada;

            }

            Program.Grabar();

            return null;
        }
    }
}
