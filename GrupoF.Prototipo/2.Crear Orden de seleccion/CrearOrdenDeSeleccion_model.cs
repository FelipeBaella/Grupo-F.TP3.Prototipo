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
            new OrdenDePreparacion {Id_OrdenDePreparacion = 0},
            new OrdenDePreparacion {Id_OrdenDePreparacion = 1},
        };
    }

 


}
