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
            // SET DE DATOS DE 3 CLIENTES:
            new Cliente { Id_Cliente = 0, Dni = 0, NombreApellido = "---"},
            new Cliente { Id_Cliente = 1, Dni = 3456789, NombreApellido = "Juan Pérez", Cuit = 20345678901, Domicilio = "Calle Falsa 123, Ciudad", CondIva = "Si" },
            new Cliente { Id_Cliente = 2, Dni = 45678901, NombreApellido = "María Gómez", Cuit = 27456789012, Domicilio = "Av. Siempre Viva 456, Provincia", CondIva = "No" },
            new Cliente { Id_Cliente = 3, Dni = 5678901, NombreApellido = "Carlos López", Cuit = 20567890123, Domicilio = "Calle del Sol 789, Capital Federal", CondIva = "Si" },
        };

        public List<Mercaderia> Mercaderias { get; set; } = new List<Mercaderia>
        {
            // SET DE DATOS DE 6 TIPOS DE MERCADERÍAS:
            new Mercaderia { Id_Mercaderia = 0, Descripcion_Mercaderia = "---"},
            new Mercaderia { Id_Mercaderia = 1, Descripcion_Mercaderia = "Termos Negros" },
            new Mercaderia { Id_Mercaderia = 2, Descripcion_Mercaderia = "Mates Aluminio" },
            new Mercaderia { Id_Mercaderia = 3, Descripcion_Mercaderia = "Remeras Gris" },
            new Mercaderia { Id_Mercaderia = 4, Descripcion_Mercaderia = "Zapatillas Adidas" },
            new Mercaderia { Id_Mercaderia = 5, Descripcion_Mercaderia = "Buzos Blancos" },
            new Mercaderia { Id_Mercaderia = 6, Descripcion_Mercaderia = "Yerba" },
        };

        public List<Deposito> Depositos { get; set; } = new List<Deposito>
        {
            // SET DE DATOS DE LOS 12 DEPÓSITOS:
            new Deposito { Id_Deposito = 0, Nombre_Deposito = "---" },
            new Deposito { Id_Deposito = 1, Nombre_Deposito = "GBAS 1" },
            new Deposito { Id_Deposito = 2, Nombre_Deposito = "GBAS 2" },
            new Deposito { Id_Deposito = 3, Nombre_Deposito = "GBAN 1" },
            new Deposito { Id_Deposito = 4, Nombre_Deposito = "GBAN 2" },
            new Deposito { Id_Deposito = 5, Nombre_Deposito = "ROS" },
            new Deposito { Id_Deposito = 6, Nombre_Deposito = "CBA" },
            new Deposito { Id_Deposito = 7, Nombre_Deposito = "MDZ" },
            new Deposito { Id_Deposito = 8, Nombre_Deposito = "BHB" },
            new Deposito { Id_Deposito = 9, Nombre_Deposito = "USH" },
            new Deposito { Id_Deposito = 10, Nombre_Deposito = "STA" },
            new Deposito { Id_Deposito = 11, Nombre_Deposito = "NQN" },
            new Deposito { Id_Deposito = 12, Nombre_Deposito = "MSN" }
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
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 1, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Id_Deposito = 2, Dni_transportista = 11111111, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 1, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 2, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(2), Id_Deposito = 3, Dni_transportista = 22222222, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 2, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 3, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = true, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(3), Id_Deposito = 1, Dni_transportista = 11111111, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 4, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(4), Id_Deposito = 2, Dni_transportista = 22222222, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 4, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 5, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(5), Id_Deposito = 3, Dni_transportista = 11111111, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 1, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 6, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Id_Deposito = 1, Dni_transportista = 22222222, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 2, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 7, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(2), Id_Deposito = 2, Dni_transportista = 11111111, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 8, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(3), Id_Deposito = 3, Dni_transportista = 22222222, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 4, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 9, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = true, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(4), Id_Deposito = 1, Dni_transportista = 11111111, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 1, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 10, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(5), Id_Deposito = 2, Dni_transportista = 22222222, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 2, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 11, Id_EstadoOP = 4, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Id_Deposito = 3, Dni_transportista = 11111111, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null },
        };

        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems { get; set; } = new List<OrdenesDePreparacionItems>
        {
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 1, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 2, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 12, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 3, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 18, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 4, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 25, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 5, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 30, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 6, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 7, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 8, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 8, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 15, Cantidad_Mercaderia = 13 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 9, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 22, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 10, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 28, Cantidad_Mercaderia = 20 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 11, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 35, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 12, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 42, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 13, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 14, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 14, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 11, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 15, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 19, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 16, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 27, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 17, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 33, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 18, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 19, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 6, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 20, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 9, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 21, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 31, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 22, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 7, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 23, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 15, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 24, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 25, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 25, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 38, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 26, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 20 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 27, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 29, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 28, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 36, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 29, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 44, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 30, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 31, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 18, Cantidad_Mercaderia = 19 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 32, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 12, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 33, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 40, Cantidad_Mercaderia = 16 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 34, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 35, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 9, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 36, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 22, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 37, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 11, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 38, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 33, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 39, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 14, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 40, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 37, Cantidad_Mercaderia = 20 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 41, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 15, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 42, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 43, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 8, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 44, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 19, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 45, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 26, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 46, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 42, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 47, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 13 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 48, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 7, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 49, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 38, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 50, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 24, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 51, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 36, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 52, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 43, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 53, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 54, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 32, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 55, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 10, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 56, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 28, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 57, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 11, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 58, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 29, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 59, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 30, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 60, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 15, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 61, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 20, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 62, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 7, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 63, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 17, Cantidad_Mercaderia = 19 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 64, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 39, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 65, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 18, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 66, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 22, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 67, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 10, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 68, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 34, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 69, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 28, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 70, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 13 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 71, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 48, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 72, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 50, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 73, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 13, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 74, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 16, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 75, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 24, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 76, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 77, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 40, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 78, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 79, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 39, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 80, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 12, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 81, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 45, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 82, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 6, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 83, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 8, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 84, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 10, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 85, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 21, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 86, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 87, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 33, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 88, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 35, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 89, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 30, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 90, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 15, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 91, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 18, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 92, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 40, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 93, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 42, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 94, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 46, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 95, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 27, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 96, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 32, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 97, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 98, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 14, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 99, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 48, Cantidad_Mercaderia = 16 },
            new OrdenesDePreparacionItems { Id_OrdenDePreparacionMercaderia = 100, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 19 }
        };

        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {
            new DepositoMercaderias { Id_DepositoMercaderias = 1, Id_Cliente = 1, Id_Deposito = 2, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 550, Coordenadas_DepositoMercaderias = "12-34-5" },
            new DepositoMercaderias { Id_DepositoMercaderias = 2, Id_Cliente = 2, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "23-45-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 3, Id_Cliente = 3, Id_Deposito = 3, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "34-56-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 4, Id_Cliente = 1, Id_Deposito = 4, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "45-67-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 5, Id_Cliente = 2, Id_Deposito = 5, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "56-78-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 6, Id_Cliente = 3, Id_Deposito = 1, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "67-89-0" },
            new DepositoMercaderias { Id_DepositoMercaderias = 7, Id_Cliente = 1, Id_Deposito = 2, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "78-90-5" },
            new DepositoMercaderias { Id_DepositoMercaderias = 8, Id_Cliente = 2, Id_Deposito = 3, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 9, Id_Cliente = 3, Id_Deposito = 4, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 10, Id_Cliente = 1, Id_Deposito = 5, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 11, Id_Cliente = 2, Id_Deposito = 1, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 12, Id_Cliente = 3, Id_Deposito = 2, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 550, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { Id_DepositoMercaderias = 13, Id_Cliente = 1, Id_Deposito = 3, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 14, Id_Cliente = 2, Id_Deposito = 4, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 15, Id_Cliente = 3, Id_Deposito = 5, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 16, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 17, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { Id_DepositoMercaderias = 18, Id_Cliente = 3, Id_Deposito = 3, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 19, Id_Cliente = 1, Id_Deposito = 4, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 20, Id_Cliente = 2, Id_Deposito = 5, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 21, Id_Cliente = 3, Id_Deposito = 1, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 22, Id_Cliente = 1, Id_Deposito = 2, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { Id_DepositoMercaderias = 23, Id_Cliente = 2, Id_Deposito = 3, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 24, Id_Cliente = 3, Id_Deposito = 4, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 25, Id_Cliente = 1, Id_Deposito = 5, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 26, Id_Cliente = 2, Id_Deposito = 1, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 27, Id_Cliente = 3, Id_Deposito = 2, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { Id_DepositoMercaderias = 28, Id_Cliente = 1, Id_Deposito = 3, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 29, Id_Cliente = 2, Id_Deposito = 4, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 30, Id_Cliente = 3, Id_Deposito = 5, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 31, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 32, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { Id_DepositoMercaderias = 33, Id_Cliente = 3, Id_Deposito = 3, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 34, Id_Cliente = 1, Id_Deposito = 4, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 35, Id_Cliente = 2, Id_Deposito = 5, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 36, Id_Cliente = 3, Id_Deposito = 1, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 37, Id_Cliente = 1, Id_Deposito = 2, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { Id_DepositoMercaderias = 38, Id_Cliente = 2, Id_Deposito = 3, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 39, Id_Cliente = 3, Id_Deposito = 4, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 40, Id_Cliente = 1, Id_Deposito = 5, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 41, Id_Cliente = 2, Id_Deposito = 1, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 42, Id_Cliente = 3, Id_Deposito = 2, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { Id_DepositoMercaderias = 43, Id_Cliente = 1, Id_Deposito = 3, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 44, Id_Cliente = 2, Id_Deposito = 4, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 45, Id_Cliente = 3, Id_Deposito = 5, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { Id_DepositoMercaderias = 46, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { Id_DepositoMercaderias = 47, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { Id_DepositoMercaderias = 48, Id_Cliente = 3, Id_Deposito = 3, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { Id_DepositoMercaderias = 49, Id_Cliente = 1, Id_Deposito = 4, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { Id_DepositoMercaderias = 50, Id_Cliente = 2, Id_Deposito = 5, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "01-23-3" },
        };


        public List<EstadosOS> EstadosOS { get; set; } = new List<EstadosOS>
        {
            new EstadosOS {Id_EstadoOS = 1, Descripcion_EstadoOS = "EMITIDA"},
            new EstadosOS {Id_EstadoOS = 2, Descripcion_EstadoOS = "CUMPLIDA"},
        };

        public List<OrdenesDeSeleccion> OrdenesDeSeleccion { get; set; } = new List<OrdenesDeSeleccion>
        {
            // Set de Datos de 4 Ordenes de Selección
            new OrdenesDeSeleccion {Id_EstadoOS = 1, Id_OrdenDeSeleccion = 1, Emision_OrdenDeSeleccion = DateTime.Now},
            new OrdenesDeSeleccion {Id_EstadoOS = 1, Id_OrdenDeSeleccion = 2, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(1)},
            new OrdenesDeSeleccion {Id_EstadoOS = 1, Id_OrdenDeSeleccion = 3, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(2)},
            new OrdenesDeSeleccion {Id_EstadoOS = 1, Id_OrdenDeSeleccion = 4, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(3)}
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
