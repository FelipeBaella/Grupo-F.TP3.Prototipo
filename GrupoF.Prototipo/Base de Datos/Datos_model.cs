using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Base_de_Datos
{
    internal class Datos_model
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>
        {
            new Cliente {Id_Cliente = 0, Dni = 0, NombreApellido = "---"},

            new Cliente {Id_Cliente = 1, Dni = 42119134, NombreApellido = "Felipe Diaz", Cuit = 242119134, Domicilio = "Casa 1", CondIva = "Si"},

            new Cliente {Id_Cliente = 2, Dni = 42102237, NombreApellido = "Martin Frias", Cuit = 242102237, Domicilio = "Dpto 2", CondIva = "No"}
        };

        public List<Transportista> Transportistas { get; set; } = new List<Transportista>
        {
            new Transportista {Id_Transportista = 1, Id_Ciente = 1, Dni_Transportista = 42119134, NombreApellido_Transportista = "Carlos Lopez"},

            new Transportista {Id_Transportista = 2, Id_Ciente = 2, Dni_Transportista = 42102237, NombreApellido_Transportista = "Matias Tallone"}
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

        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {
            new DepositoMercaderias { Id_DepositoMercaderias = 0, Id_Cliente = 0, Id_Deposito = 0, Id_Mercaderia = 0, Cantidad_DepositoMercaderias = 0, Coordenadas_DepositoMercaderias = "0-0-0"},
            new DepositoMercaderias { Id_DepositoMercaderias = 2, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 200, Coordenadas_DepositoMercaderias = "12-43-2"},
            new DepositoMercaderias { Id_DepositoMercaderias = 1, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
        };


        public List<EstadosOS> EstadosOs { get; set; } = new List<EstadosOS>
        {
            new EstadosOS {Id_EstadoOS = 1, Descripcion_EstadoOS = "EMITIDA"},
            new EstadosOS {Id_EstadoOS = 2, Descripcion_EstadoOS = "CUMPLIDA"},
            
        };

        public List<EstadosOS> EstadosOS { get; set; } = new List<EstadosOS>
        {
            new EstadosOS {Id_EstadoOS = 1, Descripcion_EstadoOS = "PENDIENTE"},
            new EstadosOS {Id_EstadoOS = 2, Descripcion_EstadoOS = "EMITIDA"},
            new EstadosOS {Id_EstadoOS = 3, Descripcion_EstadoOS = "TERMINADO"},
        };


        public List<Usuarios> Usuarios { get; set; } = new List<Usuarios>
        {
            new Usuarios {Id_Cliente = 0, Id_Usuario = 0, LogIn_usuario = "Admin", Contrasena_usuario = "123"},

            new Usuarios {Id_Cliente = 1, Id_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},

        };


        public List<OrdenesDePreparacion> OrdenesDePreparacion { get; set; } = new List<OrdenesDePreparacion>
        {
            new OrdenesDePreparacion {Id_Estado = 1, Id_OrdenDePreparacion = 2, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(2),  Id_Mercaderia = 1, Cantidad_OrdenDePreparacion = 10, Id_Deposito = 1, Id_Transportista = 1, Id_Remito = 1},
            new OrdenesDePreparacion {Id_Estado = 2, Id_OrdenDePreparacion = 1, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(1),  Id_Mercaderia = 2, Cantidad_OrdenDePreparacion = 20, Id_Deposito = 2, Id_Transportista = 2, Id_Remito = null},
            new OrdenesDePreparacion {Id_Estado = 2, Id_OrdenDePreparacion = 3, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now, Id_Mercaderia = 2, Cantidad_OrdenDePreparacion = 20, Id_Deposito = 2, Id_Transportista = 2, Id_Remito = null},
            new OrdenesDePreparacion {Id_Estado = 2, Id_OrdenDePreparacion = 3, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(13), Id_Mercaderia = 2, Cantidad_OrdenDePreparacion = 20, Id_Deposito = 2, Id_Transportista = 2, Id_Remito = null},
        };

        public List<OrdenesDeSeleccion> OrdenesDeSeleccion { get; set; } = new List<OrdenesDeSeleccion>
        {
            new OrdenesDeSeleccion {Id_Estado = 1, Id_OrdenDeSeleccion = 1, Id_OrdenDePreparacion = 1, Emision_OrdenDeSeleccion = DateTime.Now},
            new OrdenesDeSeleccion {Id_Estado = 2, Id_OrdenDeSeleccion = 2, Id_OrdenDePreparacion = 2, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(1)},
        };


        public List<OrdenesDeEntrega> OrdenesDeEntrega { get; set; } = new List<OrdenesDeEntrega>
        {
            new OrdenesDeEntrega {Id_OrdenDeEntrega = 1, Id_OrdenDePreparacion = 1, Emision_OrdenDeEntrega = DateTime.Now},
            new OrdenesDeEntrega {Id_OrdenDeEntrega = 2, Id_OrdenDePreparacion = 2, Emision_OrdenDeEntrega = DateTime.Now.AddMonths(1)},
        };






    }
}
