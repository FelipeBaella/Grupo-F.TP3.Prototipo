using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
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
        public List<OrdenDePreparacion> OrdenesDePreparacion { get; set; } = new List<OrdenDePreparacion>
        {
            new OrdenDePreparacion {Id_Estado = 1, Id_OrdenDePreparacion = 1, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now,  Id_Mercaderia = 1, Cantidad_OrdenDePreparacion = 10, Id_Deposito = 1},
            new OrdenDePreparacion {Id_Estado = 2, Id_OrdenDePreparacion = 2, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(1),  Id_Mercaderia = 2, Cantidad_OrdenDePreparacion = 20, Id_Deposito = 2},
        };
    }

}
