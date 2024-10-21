using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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
        public List<Cliente> Clientes { get; set; } = new List<Cliente>
        {
            new Cliente {Id_Cliente = 0, Dni = 0, NombreApellido = "---"},

            new Cliente {Id_Cliente = 1, Dni = 37119134, NombreApellido = "Felipe Diaz", Cuit = 20371191345, Domicilio = "Casa 1", CondIva = "Si"},

            new Cliente {Id_Cliente = 2, Dni = 31102237, NombreApellido = "Martin Frias", Cuit = 24311022379, Domicilio = "Dpto 2", CondIva = "No"}


            // SET DE DATOS DE 3 CLIENTES:
            //    new Cliente { Id_Cliente = 0, Dni = 0, NombreApellido = "---"},
            //    new Cliente { Id_Cliente = 1, Dni = 3456789, NombreApellido = "Juan Pérez", Cuit = 20345678901, Domicilio = "Calle Falsa 123, Ciudad", CondIva = "Si" },
            //    new Cliente { Id_Cliente = 2, Dni = 45678901, NombreApellido = "María Gómez", Cuit = 27456789012, Domicilio = "Av. Siempre Viva 456, Provincia", CondIva = "No" },
            //    new Cliente { Id_Cliente = 3, Dni = 5678901, NombreApellido = "Carlos López", Cuit = 20567890123, Domicilio = "Calle del Sol 789, Capital Federal", CondIva = "Si" },
        };


        public List<Mercaderia> Mercaderias { get; set; } = new List<Mercaderia>
        {
            new Mercaderia {Id_Mercaderia = 0, Descripcion_Mercaderia = "---"},

            new Mercaderia {Id_Mercaderia = 1, Descripcion_Mercaderia = "Manzanas"},

            new Mercaderia {Id_Mercaderia = 2, Descripcion_Mercaderia = "Peras"}


            // SET DE DATOS DE 6 TIPOS DE MERCADERÍAS:
            //    new Mercaderia { Id_Mercaderia = 0, Descripcion_Mercaderia = "---"},
            //    new Mercaderia { Id_Mercaderia = 1, Descripcion_Mercaderia = "Termos Negros" },
            //    new Mercaderia { Id_Mercaderia = 2, Descripcion_Mercaderia = "Mates Aluminio" },
            //    new Mercaderia { Id_Mercaderia = 3, Descripcion_Mercaderia = "Remeras Gris" },
            //    new Mercaderia { Id_Mercaderia = 4, Descripcion_Mercaderia = "Zapatillas Adidas" },
            //    new Mercaderia { Id_Mercaderia = 5, Descripcion_Mercaderia = "Buzos Blancos" },
            //    new Mercaderia { Id_Mercaderia = 6, Descripcion_Mercaderia = "Yerba" },

        };

        public List<Deposito> Depositos { get; set; } = new List<Deposito>
        {
            new Deposito { Id_Deposito = 0, Nombre_Deposito = "---" },

            new Deposito { Id_Deposito = 1, Nombre_Deposito = "GBAS 1" },

            new Deposito { Id_Deposito = 2, Nombre_Deposito = "GBAS 2" }


            // SET DE DATOS DE LOS 12 DEPÓSITOS:
            // new Deposito { Id_Deposito = 0, Nombre_Deposito = "---" },
            // new Deposito { Id_Deposito = 1, Nombre_Deposito = "GBAS 1" },
            // new Deposito { Id_Deposito = 2, Nombre_Deposito = "GBAS 2" }
            // new Deposito { Id_Deposito = 3, Nombre_Deposito = "GBAN 1" }
            // new Deposito { Id_Deposito = 4, Nombre_Deposito = "GBAN 2" }
            // new Deposito { Id_Deposito = 5, Nombre_Deposito = "ROS" }
            // new Deposito { Id_Deposito = 6, Nombre_Deposito = "CBA" }
            // new Deposito { Id_Deposito = 7, Nombre_Deposito = "MDZ" }
            // new Deposito { Id_Deposito = 8, Nombre_Deposito = "BHB" }
            // new Deposito { Id_Deposito = 9, Nombre_Deposito = "USH" }
            // new Deposito { Id_Deposito = 10, Nombre_Deposito = "STA" }
            // new Deposito { Id_Deposito = 11, Nombre_Deposito = "NQN" }
            // new Deposito { Id_Deposito = 12, Nombre_Deposito = "MSN" }
        };



        public List<EstadosOP> EstadosOP { get; set; } = new List<EstadosOP>
        {
            new EstadosOP {Id_EstadoOP = 1, Descripcion_EstadoOP = "EMITIDA"},
            new EstadosOP {Id_EstadoOP = 2, Descripcion_EstadoOP = "SELECCIONADA"},
            new EstadosOP {Id_EstadoOP = 3, Descripcion_EstadoOP = "EN PREPARACION"},
            new EstadosOP {Id_EstadoOP = 4, Descripcion_EstadoOP = "PREPARADA"},
            new EstadosOP {Id_EstadoOP = 5, Descripcion_EstadoOP = "EN DESPACHO"},
            new EstadosOP {Id_EstadoOP = 6, Descripcion_EstadoOP = "DESPACHADA "},

            // ACÁ NO MODIFIQUÉ NADA PORQUE ESTÁ PERFECTO
        };


        public List<Usuarios> Usuarios { get; set; } = new List<Usuarios>
        {
            new Usuarios {Id_Cliente = 0, Id_Usuario = 0, LogIn_usuario = "Admin", Contrasena_usuario = "123"},

            new Usuarios {Id_Cliente = 1, Id_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},


            // CREO QUE ESTA LISTA NO ES NECESARIA ACÁ, PERO TE DEJO LOS USUARIOS QUE USASTE PARA EL LOGGIN PARA DEJARLO HOMOGENEO EN TODO CASO.
            // new Usuarios {Id_Cliente = 0, Id_Usuario = 0, LogIn_usuario = "1", Contrasena_usuario = "1"},
            // new Usuarios {Id_Cliente = 1, Id_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},

        };


        public List<OrdenesDePreparacion> OrdenesDePreparacion { get; set; } = new List<OrdenesDePreparacion>
        {
            new OrdenesDePreparacion {Id_EstadoOP = 1, Id_OrdenDePreparacion = 8, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(2),   Dni_transportista = 1, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = 1},
            new OrdenesDePreparacion {Id_EstadoOP = 1, Id_OrdenDePreparacion = 2, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(7),   Dni_transportista = 1, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = 1},
            new OrdenesDePreparacion {Id_EstadoOP = 2, Id_OrdenDePreparacion = 1, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddMonths(1),  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 2, Id_Remito = null},
            new OrdenesDePreparacion {Id_EstadoOP = 2, Id_OrdenDePreparacion = 3, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now,  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = null},
            new OrdenesDePreparacion {Id_EstadoOP = 2, Id_OrdenDePreparacion = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(13),  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 2, Id_Remito = null},
            new OrdenesDePreparacion {Id_EstadoOP = 4, Id_OrdenDePreparacion = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(13),  Dni_transportista = 2, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 2, Id_Remito = null},


           //   SET DE DATOS DE 20 Ordenes de Preparación asociadas a 3 Clientes:
           //   new OrdenesDePreparacion { Id_EstadoOP = 1, Id_OrdenDePreparacion = 1, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 1234567, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = null, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 2, Id_OrdenDePreparacion = 2, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(2), Dni_transportista = 2345678, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 1, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 3, Id_OrdenDePreparacion = 3, Prioridad_OrdenDePreparacion = true, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 1234567, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 2, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 4, Id_OrdenDePreparacion = 4, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Dni_transportista = 2345678, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 5, Id_OrdenDePreparacion = 5, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(3), Dni_transportista = 3456789, Id_OrdenDeEntrega = 2, Id_OrdenDeSeleccion = 4, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 6, Id_OrdenDePreparacion = 6, Prioridad_OrdenDePreparacion = false, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(4), Dni_transportista = 1234567, Id_OrdenDeEntrega = 4, Id_OrdenDeSeleccion = 5, Id_Remito = 2 },
           //   new OrdenesDePreparacion { Id_EstadoOP = 2, Id_OrdenDePreparacion = 7, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 2345678, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 1, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 3, Id_OrdenDePreparacion = 8, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(5), Dni_transportista = 3456789, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 2, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 4, Id_OrdenDePreparacion = 9, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 1234567, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 5, Id_OrdenDePreparacion = 10, Prioridad_OrdenDePreparacion = false, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(6), Dni_transportista = 2345678, Id_OrdenDeEntrega = 3, Id_OrdenDeSeleccion = 4, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 1, Id_OrdenDePreparacion = 11, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 1234567, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = null, Id_Remito = null }, //
           //   new OrdenesDePreparacion { Id_EstadoOP = 2, Id_OrdenDePreparacion = 12, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(2), Dni_transportista = 2345678, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 1, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 3, Id_OrdenDePreparacion = 13, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 3456789, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 2, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 4, Id_OrdenDePreparacion = 14, Prioridad_OrdenDePreparacion = false, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(3), Dni_transportista = 1234567, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 5, Id_OrdenDePreparacion = 15, Prioridad_OrdenDePreparacion = true, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(4), Dni_transportista = 2345678, Id_OrdenDeEntrega = 2, Id_OrdenDeSeleccion = 5, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 6, Id_OrdenDePreparacion = 16, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(5), Dni_transportista = 3456789, Id_OrdenDeEntrega = 4, Id_OrdenDeSeleccion = 4, Id_Remito = 2 },
           //   new OrdenesDePreparacion { Id_EstadoOP = 1, Id_OrdenDePreparacion = 17, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 1234567, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = null, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 2, Id_OrdenDePreparacion = 18, Prioridad_OrdenDePreparacion = false, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Dni_transportista = 2345678, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 1, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 3, Id_OrdenDePreparacion = 19, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now, Dni_transportista = 3456789, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null },
           //   new OrdenesDePreparacion { Id_EstadoOP = 4, Id_OrdenDePreparacion = 20, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(6), Dni_transportista = 1234567, Id_OrdenDeEntrega = null, Id_OrdenDeSeleccion = 3, Id_Remito = null }
        };

        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems { get; set; } = new List<OrdenesDePreparacionItems>
        {
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 1, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 250},
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 2, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 120},
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 3, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 210},
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 4, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 370},
            new OrdenesDePreparacionItems {Id_OrdenDePreparacionMercaderia = 5, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 170},

            // SET DE DATOS DE 50 ITEMS de OP distrubidos entre 20 OPS.
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 1, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 10 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 2, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 8 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 3, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 12 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 4, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 7 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 5, Id_OrdenDePreparacion = 15, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 6 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 6, Id_OrdenDePreparacion = 18, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 9 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 7, Id_OrdenDePreparacion = 20, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 5 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 8, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 14 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 9, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 11 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 10, Id_OrdenDePreparacion = 12, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 13 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 11, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 8 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 12, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 9 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 13, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 7 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 14, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 14 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 15, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 6 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 16, Id_OrdenDePreparacion = 13, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 15 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 17, Id_OrdenDePreparacion = 14, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 10 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 18, Id_OrdenDePreparacion = 16, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 12 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 19, Id_OrdenDePreparacion = 17, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 5 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 20, Id_OrdenDePreparacion = 19, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 7 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 21, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 11 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 22, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 8 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 23, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 9 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 24, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 6 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 25, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 14 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 26, Id_OrdenDePreparacion = 12, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 15 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 27, Id_OrdenDePreparacion = 14, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 10 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 28, Id_OrdenDePreparacion = 16, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 5 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 29, Id_OrdenDePreparacion = 18, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 13 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 30, Id_OrdenDePreparacion = 20, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 12 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 31, Id_OrdenDePreparacion = 2, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 9 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 32, Id_OrdenDePreparacion = 4, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 7 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 33, Id_OrdenDePreparacion = 6, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 8 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 34, Id_OrdenDePreparacion = 8, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 10 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 35, Id_OrdenDePreparacion = 9, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 11 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 36, Id_OrdenDePreparacion = 11, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 6 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 37, Id_OrdenDePreparacion = 13, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 5 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 38, Id_OrdenDePreparacion = 15, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 14 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 39, Id_OrdenDePreparacion = 17, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 12 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 40, Id_OrdenDePreparacion = 19, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 7 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 41, Id_OrdenDePreparacion = 1, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 13 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 42, Id_OrdenDePreparacion = 3, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 15 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 43, Id_OrdenDePreparacion = 5, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 11 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 44, Id_OrdenDePreparacion = 7, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 9 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 45, Id_OrdenDePreparacion = 10, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 8 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 46, Id_OrdenDePreparacion = 12, Id_DepositoMercaderias = 1, Cantidad_Mercaderia = 5 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 47, Id_OrdenDePreparacion = 14, Id_DepositoMercaderias = 2, Cantidad_Mercaderia = 10 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 48, Id_OrdenDePreparacion = 16, Id_DepositoMercaderias = 3, Cantidad_Mercaderia = 6 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 49, Id_OrdenDePreparacion = 18, Id_DepositoMercaderias = 4, Cantidad_Mercaderia = 7 },
            // new OrdenDePreparacionMercaderia { Id_OrdenDePreparacionMercaderia = 50, Id_OrdenDePreparacion = 20, Id_DepositoMercaderias = 5, Cantidad_Mercaderia = 14 }

        };

        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {
            new DepositoMercaderias { Id_DepositoMercaderias = 0, Id_Cliente = 0, Id_Deposito = 0, Id_Mercaderia = 0, Cantidad_DepositoMercaderias = 0, Coordenadas_DepositoMercaderias = "0-0-0"},
            new DepositoMercaderias { Id_DepositoMercaderias = 1, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 200, Coordenadas_DepositoMercaderias = "12-43-2"},
            new DepositoMercaderias { Id_DepositoMercaderias = 2, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
            new DepositoMercaderias { Id_DepositoMercaderias = 3, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},


            //  SET DE DATOS DE 10 slots de espacios distribuidos en 3 Clientes:
            //  new DepositoMercaderias { Id_DepositoMercaderias = 0, Id_Cliente = 0, Id_Deposito = 0, Id_Mercaderia = 0, Cantidad_DepositoMercaderias = 0, Coordenadas_DepositoMercaderias = "0-0-0"},
            //  new DepositoMercaderias { Id_DepositoMercaderias = 1, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "10-20-5" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 2, Id_Cliente = 1, Id_Deposito = 2, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 450, Coordenadas_DepositoMercaderias = "30-50-6" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 3, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "14-24-3" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 4, Id_Cliente = 1, Id_Deposito = 1, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 750, Coordenadas_DepositoMercaderias = "22-32-6" }
            //  new DepositoMercaderias { Id_DepositoMercaderias = 5, Id_Cliente = 2, Id_Deposito = 1, Id_Mercaderia = 5, Cantidad_DepositoMercaderias = 2000, Coordenadas_DepositoMercaderias = "20-60-9" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 6, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 3, Cantidad_DepositoMercaderias = 1000, Coordenadas_DepositoMercaderias = "15-30-8" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 7, Id_Cliente = 2, Id_Deposito = 2, Id_Mercaderia = 1, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "18-28-7" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 8, Id_Cliente = 3, Id_Deposito = 1, Id_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "25-40-7" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 9, Id_Cliente = 3, Id_Deposito = 2, Id_Mercaderia = 6, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "12-22-4" },
            //  new DepositoMercaderias { Id_DepositoMercaderias = 10, Id_Cliente = 3, Id_Deposito = 1, Id_Mercaderia = 4, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "16-26-8" },

        };


        public List<EstadosOS> EstadosOS { get; set; } = new List<EstadosOS>
        {
            new EstadosOS {Id_EstadoOS = 1, Descripcion_EstadoOS = "EMITIDA"},
            new EstadosOS {Id_EstadoOS = 2, Descripcion_EstadoOS = "CUMPLIDA"},

            // ACÁ NO MODIFIQUÉ NADA PORQUE ESTÁ PERFECTO
        };


        public List<OrdenesDeSeleccion> OrdenesDeSeleccion = new();
        public string CrearOrdenesDePreparacion(OrdenesDeSeleccion ordenesDeSeleccion)
        {
            var Id_OrdenDeSeleccion = OrdenesDeSeleccion.Count + 1;
            var Id_OrdenDePreparacionMercaderia = OrdenesDePreparacionItems.Count + 1;
            var Id_EstadoOP = ordenesDeSeleccion.Id_EstadoOS;
            var Prioridad_OrdenDePreparacion = ordenesDeSeleccion.Emision_OrdenDeSeleccion;
            var AcualizacionEstado_OrdenDeSeleccion = ordenesDeSeleccion.AcualizacionEstado_OrdenDeSeleccion;

            OrdenesDeSeleccion.Add(ordenesDeSeleccion);

            return null;
        }

        public string EditarEstadoOP(List<int> ordenesDePreparacion)
        {
            foreach (var item in ordenesDePreparacion)
            {
                var ordenDePreparacion = OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == item).SingleOrDefault();

                ordenDePreparacion.Id_EstadoOP = 2;
                ordenDePreparacion.Id_OrdenDeSeleccion = OrdenesDeSeleccion.Last().Id_OrdenDeSeleccion;
            }

            return null;
        }



    }

}
