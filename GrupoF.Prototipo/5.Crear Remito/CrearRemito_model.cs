using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._5.Crear_Remito
{
    internal class CrearRemito_model
    {
        public List<OrdenesDePreparacion> OrdenesDePreparacion { get; set; } = new List<OrdenesDePreparacion>
        {
            new OrdenesDePreparacion {Id_OrdenDePreparacion = 1, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_OrdenDePreparacion = 10, Dni_Transportista = 42119134, NombreApellido_Transportista = "Diego Carlos"},
            new OrdenesDePreparacion {Id_OrdenDePreparacion = 2, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_OrdenDePreparacion = 20, Dni_Transportista = 42102237, NombreApellido_Transportista = "Felipe Baella"},
        };

    }
}
