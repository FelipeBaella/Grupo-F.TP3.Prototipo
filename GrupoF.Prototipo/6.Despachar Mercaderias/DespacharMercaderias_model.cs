
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
