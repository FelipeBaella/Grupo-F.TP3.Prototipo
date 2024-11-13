
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class EmpaquetarMercaderias_model
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


        public string EditarEstadoOP(int id)
        {
            var OrdenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == id).SingleOrDefault();

            OrdenDePreparacion.Estado_OP = EstadoOPEnum.Preparada;

            var OrdenDePreparacionE = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == id).SingleOrDefault().Estado_OP;

            Program.Grabar();

            return null;
        }
    }
}
