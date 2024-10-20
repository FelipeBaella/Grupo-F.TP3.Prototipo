using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class CrearOrdnesDePreparacion_model
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>
        {
            new Cliente {Id_Cliente = 0, Dni = 0, NombreApellido = "---"},

            new Cliente {Id_Cliente = 1, Dni = 37119134, NombreApellido = "Felipe Diaz", Cuit = 20371191345, Domicilio = "Casa 1", CondIva = "Si"},

            new Cliente {Id_Cliente = 2, Dni = 31102237, NombreApellido = "Martin Frias", Cuit = 24311022379, Domicilio = "Dpto 2", CondIva = "No"}
        };

        public List<Mercaderia> Mercaderias { get; set; } = new List<Mercaderia>
        {
            new Mercaderia {Id_Mercaderia = 0, Descripcion_Mercaderia = "---"},

            new Mercaderia {Id_Mercaderia = 1, Descripcion_Mercaderia = "Manzanas"},

            new Mercaderia {Id_Mercaderia = 2, Descripcion_Mercaderia = "Peras"}
        };

        public List<Deposito> Depositos { get; set; } = new List<Deposito>
        {
            new Deposito { Id_Deposito = 0, Nombre_Deposito = "---" },

            new Deposito { Id_Deposito = 1, Nombre_Deposito = "GBAS 1" },

            new Deposito { Id_Deposito = 2, Nombre_Deposito = "GBAS 2" }
        };

        public List<Transportista> Transportistas { get; set; } = new List<Transportista>
        {
            new Transportista {Id_Transportista = 1, Id_Ciente = 1, Dni_Transportista = 37119134, NombreApellido_Transportista = "Carlos Lopez"},

            new Transportista {Id_Transportista = 2, Id_Ciente = 2, Dni_Transportista = 31102237, NombreApellido_Transportista = "Matias Tallone"}
        };

        public List<EstadosOP> EstadosOP { get; set; } = new List<EstadosOP>
        {
            new EstadosOP {Id_EstadoOP = 1, Descripcion_EstadoOP = "EMITIDA"},
            new EstadosOP {Id_EstadoOP = 2, Descripcion_EstadoOP = "SELECCIONADA"},
            new EstadosOP {Id_EstadoOP = 3, Descripcion_EstadoOP = "EN PREPARACION"},
            new EstadosOP {Id_EstadoOP = 4, Descripcion_EstadoOP = "PREPARADA"},
            new EstadosOP {Id_EstadoOP = 5, Descripcion_EstadoOP = "EN DESPACHO"},
            new EstadosOP {Id_EstadoOP = 6, Descripcion_EstadoOP = "DESPACHADA "},

        };

        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {
            new DepositoMercaderias { Id_DepositoMercaderias = 0, Id_Cliente = 0, Id_Deposito = 0, Id_Mercaderia = 0, Cantidad_DepositoMercaderias = 0, Coordenadas_DepositoMercaderias = "0-0-0"},
            new DepositoMercaderias { Id_DepositoMercaderias = 1, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 200, Coordenadas_DepositoMercaderias = "12-43-2"},
            new DepositoMercaderias { Id_DepositoMercaderias = 2, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
            new DepositoMercaderias { Id_DepositoMercaderias = 3, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
        };



        public List<OrdenesDePreparacion> OrdenesDePreparacion = new();
        public string CrearOrdenesDePreparacion(OrdenesDePreparacion ordenDePreparacion)
        {
            var Id_EstadoOP = ordenDePreparacion.Id_EstadoOP;
            var Prioridad_OrdenDePreparacion = ordenDePreparacion.Prioridad_OrdenDePreparacion;
            var Id_Cliente = ordenDePreparacion.Id_Cliente;
            var Emision_OrdenDePreparacion = ordenDePreparacion.Emision_OrdenDePreparacion;
            var Id_Deposito = ordenDePreparacion.Id_Deposito;
            var Id_Transportista = ordenDePreparacion.Id_Transportista;

            OrdenesDePreparacion.Add(ordenDePreparacion);

            return null;
        }


        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems = new();
        public string CrearOrdenesDePreparacionItem(OrdenesDePreparacionItems OrdeneDePreparacionItem)
        {
            var Id_OrdenDePreparacionMercaderia = OrdenesDePreparacionItems.Count + 1;
            var Id_OrdenDePreparacion = OrdenesDePreparacion.Last().Id_OrdenDePreparacion;
            var Id_DepositoMercaderias = OrdeneDePreparacionItem.Id_DepositoMercaderias;
            var Cantidad_Mercaderia = OrdeneDePreparacionItem.Cantidad_Mercaderia;

            OrdenesDePreparacionItems.Add(OrdeneDePreparacionItem);

            return null;
        }



    }
}
