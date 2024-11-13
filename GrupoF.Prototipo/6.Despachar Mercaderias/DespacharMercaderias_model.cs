
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


        // Nuevo
        public string CrearRemito(List<int> Ordenespreparacion_Remito)
        {
            var Remito = new RemitoEnt();

            var FechaEmision_Remito = DateTime.Now.Date;
            Remito.FechaEmision_Remito = FechaEmision_Remito;


            var remitos = RemitoAlmacen.Remitos;
            var ID_Remito = 1;

            if (remitos.Count > 0)
            {
                ID_Remito = remitos.Last().ID_Remito + 1;
            }

            Remito.ID_Remito = ID_Remito;

            foreach (var item in Ordenespreparacion_Remito)
            {
                var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.Despachada;
            }

            Remito.OrdenesPreparacion_Remito = Ordenespreparacion_Remito;

            RemitoAlmacen.Nueva(Remito);

            Program.Grabar();

            return null; 

        }
    }
}
