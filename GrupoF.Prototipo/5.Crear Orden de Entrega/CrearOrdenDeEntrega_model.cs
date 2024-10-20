using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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



        public List<EstadosOP> EstadosOP { get; set; } = new List<EstadosOP>
        {
            new EstadosOP {Id_EstadoOP = 1, Descripcion_EstadoOP = "EMITIDA"},
            new EstadosOP {Id_EstadoOP = 2, Descripcion_EstadoOP = "SELECCIONADA"},
            new EstadosOP {Id_EstadoOP = 3, Descripcion_EstadoOP = "EN PREPARACION"},
            new EstadosOP {Id_EstadoOP = 4, Descripcion_EstadoOP = "PREPARADA"},
            new EstadosOP {Id_EstadoOP = 5, Descripcion_EstadoOP = "EN DESPACHO"},
            new EstadosOP {Id_EstadoOP = 6, Descripcion_EstadoOP = "DESPACHADA "},

        };


        public List<Usuarios> Usuarios { get; set; } = new List<Usuarios>
        {
            new Usuarios {Id_Cliente = 0, Id_Usuario = 0, LogIn_usuario = "Admin", Contrasena_usuario = "123"},

            new Usuarios {Id_Cliente = 1, Id_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},

        };


        public List<OrdenesDePreparacion> OrdenesDePreparacion { get; set; } = new List<OrdenesDePreparacion>
        {
            new OrdenesDePreparacion {Id_EstadoOP = 1, Id_OrdenDePreparacion = 2, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(2),   Dni_transportista = 1, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = 1},
            new OrdenesDePreparacion {Id_EstadoOP = 2, Id_OrdenDePreparacion = 1, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(1),  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 2, Id_Remito = null},
            new OrdenesDePreparacion {Id_EstadoOP = 2, Id_OrdenDePreparacion = 3, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now,  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = null},
            new OrdenesDePreparacion {Id_EstadoOP = 2, Id_OrdenDePreparacion = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(13),  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 2, Id_Remito = null},
            new OrdenesDePreparacion {Id_EstadoOP = 4, Id_OrdenDePreparacion = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(13),  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 2, Id_Remito = null},
        };

        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems { get; set; } = new List<OrdenesDePreparacionItems>
        {
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 1, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 250},
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 2, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 120},
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 3, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 210},
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 4, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 370},
        };

        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {
            new DepositoMercaderias { Id_DepositoMercaderias = 0, Id_Cliente = 0, Id_Deposito = 0, Id_Mercaderia = 0, Cantidad_DepositoMercaderias = 0, Coordenadas_DepositoMercaderias = "0-0-0"},
            new DepositoMercaderias { Id_DepositoMercaderias = 1, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 200, Coordenadas_DepositoMercaderias = "12-43-2"},
            new DepositoMercaderias { Id_DepositoMercaderias = 2, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
            new DepositoMercaderias { Id_DepositoMercaderias = 3, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
        };


        public List<EstadosOS> EstadosOS { get; set; } = new List<EstadosOS>
        {
            new EstadosOS {Id_EstadoOS = 1, Descripcion_EstadoOS = "EMITIDA"},
            new EstadosOS {Id_EstadoOS = 2, Descripcion_EstadoOS = "CUMPLIDA"},
        };

        public List<OrdenesDeSeleccion> OrdenesDeSeleccion { get; set; } = new List<OrdenesDeSeleccion>
        {
            new OrdenesDeSeleccion {Id_EstadoOS = 1, Id_OrdenDeSeleccion = 1, Emision_OrdenDeSeleccion = DateTime.Now},
            new OrdenesDeSeleccion {Id_EstadoOS = 1, Id_OrdenDeSeleccion = 2, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(1)},
        };


        public List<OrdenesDeEntrega> OrdenesDeEntrega = new();
        public string CrearOrdenesDeEntrega(OrdenesDeEntrega ordenesDeEntrega)
        {
            var Id_OrdenDeEntrega = ordenesDeEntrega.Id_OrdenDeEntrega;
            var Id_OrdenDePreparacionMercaderia = ordenesDeEntrega.Emision_OrdenDeEntrega;
            var Id_EstadoOP = ordenesDeEntrega.Procesado_OrdenDeEntrega;

            OrdenesDeEntrega.Add(ordenesDeEntrega);

            return null;
        }


        public string EditarEstadoOP(int id)
        {
            var ordenesDePreparacion = OrdenesDePreparacion.Where(x => x.Id_OrdenDeSeleccion == id && x.Id_EstadoOP == 4).ToList();

            foreach (var item in ordenesDePreparacion)
            {
                item.Id_EstadoOP = 5;
                item.Id_OrdenDeEntrega = OrdenesDeEntrega.Last().Id_OrdenDeEntrega;
            }

            return null;
        }


    }
}
