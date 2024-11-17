

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
        public int ObtenerUsuarioDeposito()
        {
            var usuario = UsuarioAlmacen.UsuarioSeleccionado;

            var usuarioDeposito = UsuarioAlmacen.Usuarios.Where(x => x.ID_Usuario == usuario).FirstOrDefault().ID_Deposito;

            return usuarioDeposito;
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


        // EL NUEVO
        public string CrearOrdenesDeEntrega(List<int> Ordenespreparacion_OE)
        {

            var ordenDeEntrega = new OrdenDeEntregaEnt();

            var FechaEmision_OE = DateTime.Now.Date;

            var OE = OrdenDeEntregaAlmacen.OrdenesDeEntrega;
            var ID_OE = 1;

            if (OE.Count > 0)
            {
                ID_OE = OE.Last().ID_OE + 1;
            }

            foreach (var item in Ordenespreparacion_OE)
            {
                var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.EnDespacho; // Verificar
            }

            ordenDeEntrega.OrdenesPreparacion_OE = Ordenespreparacion_OE;
            ordenDeEntrega.ID_OE = ID_OE;
            ordenDeEntrega.FechaEmision_OE = FechaEmision_OE;

            OrdenDeEntregaAlmacen.Nueva(ordenDeEntrega);

            Program.Grabar();

            return null; //?? Validar si es eso o: return ordenDeEntrega.ID_OE.ToString();

        }
    }
}
