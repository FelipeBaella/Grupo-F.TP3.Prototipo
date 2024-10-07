using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    internal class ProcesarOrdenDeEntrega_model
    {
        public List<OrdenesDeEntrega> OrdenesDeEntrega { get; set; } = new List<OrdenesDeEntrega>
        {
            new OrdenesDeEntrega {Id_OrdenDeEntrega = 1, Id_Estado = 1, Id_OrdenDePreparacion = 1,  Emision_OrdenDeEntrega = DateTime.Now},
            new OrdenesDeEntrega {Id_OrdenDeEntrega = 2,Id_Estado = 2, Id_OrdenDePreparacion = 2, Emision_OrdenDeEntrega = DateTime.Now.AddMonths(1)},
        };

    }
}
