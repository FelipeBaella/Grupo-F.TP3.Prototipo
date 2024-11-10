
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoF.Prototipo.Almacenes;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class CrearOrdnesDePreparacion_model
    {    
        public string CrearOrdenesDePreparacion(OrdenDePreparacionEnt ordenDePreparacion)
        {
            var Estado_OP = ordenDePreparacion.Estado_OP;
            var Prioridad_OP = ordenDePreparacion.Prioridad_OP;
            var ID_Cliente = ordenDePreparacion.ID_Cliente;
            var FechaEmision_OP = ordenDePreparacion.FechaEmision_OP;
            var FechaEntrega_OP = ordenDePreparacion.FechaEntrega_OP;
            //var FechaEnFechaActualizacionEstado_OPtrega_OP = ordenDePreparacion.FechaActualizacionEstado_OP;
            var ID_Deposito = ordenDePreparacion.ID_Deposito;
            var DNI_Transportista = ordenDePreparacion.DNI_Transportista;
            var Mercaderias_OP = ordenDePreparacion.Mercaderias_OP;

            if (DNI_Transportista < 10_000_000 || DNI_Transportista > 99_999_999)
            {
                return "El DNI_Cliente ingresado debe tener 8 dígitos.";
            }

            if (FechaEmision_OP < DateTime.Now.Date)
            {
                return "La fecha de emision no puede ser menor al dia de hoy.";
            }


            var OP = GrupoF.Prototipo.Almacenes.OrdenDePreparacionAlmacen.OrdenesDePreparacion;

            if (OP.Count > 0)
            {
                ordenDePreparacion.ID_OP = OP.Last().ID_OP + 1;
            }
            else
            {
                ordenDePreparacion.ID_OP = 1;
            }

            OrdenDePreparacionAlmacen.Grabar(ordenDePreparacion);

            return ordenDePreparacion.ID_OP.ToString();
        }


        //public string CrearOrdenesDePreparacionItem(Mercaderia_OP OrdeneDePreparacionItem)
        //{
        //    var ID_DepositoMercaderia = OrdeneDePreparacionItem.ID_Mercaderia;
        //    var Cantidad_Mercaderia = OrdeneDePreparacionItem.Cantidad_Mercaderia;

        //    OrdenesDePreparacionItems.(OrdeneDePreparacionItem);

        //    OrdenDePreparacionAlmacen.Grabar(OrdeneDePreparacionItem);

        //    return null;
        //}



    }
}
