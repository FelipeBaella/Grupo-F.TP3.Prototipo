using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    internal class DespacharMercaderias_model
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>
        {
            // SET DE DATOS DE 3 CLIENTES:
            new Cliente { ID_Cliente = 0, Dni = 0, NombreApellido = "---"},
            new Cliente { ID_Cliente = 1, Dni = 3456789, NombreApellido = "Juan Pérez", Cuit = 20345678901, Domicilio = "Calle Falsa 123, Ciudad", CondIva = "Si" },
            new Cliente { ID_Cliente = 2, Dni = 45678901, NombreApellido = "María Gómez", Cuit = 27456789012, Domicilio = "Av. Siempre Viva 456, Provincia", CondIva = "No" },
            new Cliente { ID_Cliente = 3, Dni = 5678901, NombreApellido = "Carlos López", Cuit = 20567890123, Domicilio = "Calle del Sol 789, Capital Federal", CondIva = "Si" },
        };

        public List<Mercaderia> Mercaderias { get; set; } = new List<Mercaderia>
        {
            // SET DE DATOS DE 6 TIPOS DE MERCADERÍAS:
            new Mercaderia { ID_Mercaderia = 0, Descripcion_Mercaderia = "---"},
            new Mercaderia { ID_Mercaderia = 1, Descripcion_Mercaderia = "Termos Negros" },
            new Mercaderia { ID_Mercaderia = 2, Descripcion_Mercaderia = "Mates Aluminio" },
            new Mercaderia { ID_Mercaderia = 3, Descripcion_Mercaderia = "Remeras Gris" },
            new Mercaderia { ID_Mercaderia = 4, Descripcion_Mercaderia = "Zapatillas Adidas" },
            new Mercaderia { ID_Mercaderia = 5, Descripcion_Mercaderia = "Buzos Blancos" },
            new Mercaderia { ID_Mercaderia = 6, Descripcion_Mercaderia = "Yerba" },
        };

        public List<Deposito> Depositos { get; set; } = new List<Deposito>
        {
            // SET DE DATOS DE LOS 12 DEPÓSITOS:
            new Deposito { ID_Deposito = 0, Nombre_Deposito = "---" },
            new Deposito { ID_Deposito = 1, Nombre_Deposito = "GBAS 1" },
            new Deposito { ID_Deposito = 2, Nombre_Deposito = "GBAS 2" },
            new Deposito { ID_Deposito = 3, Nombre_Deposito = "GBAN 1" },
            new Deposito { ID_Deposito = 4, Nombre_Deposito = "GBAN 2" },
            new Deposito { ID_Deposito = 5, Nombre_Deposito = "ROS" },
            new Deposito { ID_Deposito = 6, Nombre_Deposito = "CBA" },
            new Deposito { ID_Deposito = 7, Nombre_Deposito = "MDZ" },
            new Deposito { ID_Deposito = 8, Nombre_Deposito = "BHB" },
            new Deposito { ID_Deposito = 9, Nombre_Deposito = "USH" },
            new Deposito { ID_Deposito = 10, Nombre_Deposito = "STA" },
            new Deposito { ID_Deposito = 11, Nombre_Deposito = "NQN" },
            new Deposito { ID_Deposito = 12, Nombre_Deposito = "MSN" }
        };






        public List<Usuarios> Usuarios { get; set; } = new List<Usuarios>
        {
            new Usuarios {ID_Cliente = 0, ID_Usuario = 0, LogIn_usuario = "Admin", Contrasena_usuario = "123"},
            new Usuarios {ID_Cliente = 1, ID_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},
        };


        public List<OrdenesDePreparacion> OrdenesDePreparacion { get; set; } = new List<OrdenesDePreparacion>
        {
            new OrdenesDePreparacion { ID_OP = 1, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = true, ID_Cliente = 1, FechaEmision_OP = DateTime.Now.AddDays(1), ID_Deposito = 2, Dni_transportista = 11111111, ID_OE = 1, ID_OS = 1, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 2, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = false, ID_Cliente = 2, FechaEmision_OP = DateTime.Now.AddDays(2), ID_Deposito = 3, Dni_transportista = 22222222, ID_OE = 2, ID_OS = 2, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 3, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = true, ID_Cliente = 3, FechaEmision_OP = DateTime.Now.AddDays(3), ID_Deposito = 1, Dni_transportista = 11111111, ID_OE = 1, ID_OS = 3, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 4, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = false, ID_Cliente = 1, FechaEmision_OP = DateTime.Now.AddDays(4), ID_Deposito = 2, Dni_transportista = 22222222, ID_OE = 2, ID_OS = 4, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 5, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = true, ID_Cliente = 2, FechaEmision_OP = DateTime.Now.AddDays(5), ID_Deposito = 3, Dni_transportista = 11111111, ID_OE = 1, ID_OS = 1, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 6, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = false, ID_Cliente = 3, FechaEmision_OP = DateTime.Now.AddDays(1), ID_Deposito = 1, Dni_transportista = 22222222, ID_OE = 2, ID_OS = 2, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 7, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = true, ID_Cliente = 1, FechaEmision_OP = DateTime.Now.AddDays(2), ID_Deposito = 2, Dni_transportista = 11111111, ID_OE = 1, ID_OS = 3, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 8, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = false, ID_Cliente = 2, FechaEmision_OP = DateTime.Now.AddDays(3), ID_Deposito = 3, Dni_transportista = 22222222, ID_OE = 2, ID_OS = 4, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 9, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = true, ID_Cliente = 3, FechaEmision_OP = DateTime.Now.AddDays(4), ID_Deposito = 1, Dni_transportista = 11111111, ID_OE = 1, ID_OS = 1, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 10, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = false, ID_Cliente = 1, FechaEmision_OP = DateTime.Now.AddDays(5), ID_Deposito = 2, Dni_transportista = 22222222, ID_OE = 2, ID_OS = 2, ID_Remito = null },
            new OrdenesDePreparacion { ID_OP = 11, Estado_OP = EstadoOPEnum.EN_DESPACHO, Prioridad_OP = true, ID_Cliente = 2, FechaEmision_OP = DateTime.Now.AddDays(1), ID_Deposito = 3, Dni_transportista = 11111111, ID_OE = 1, ID_OS = 3, ID_Remito = null },

        };

        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems { get; set; } = new List<OrdenesDePreparacionItems>
        {
            new OrdenesDePreparacionItems {ID_OPMercaderia = 1, ID_OP = 1, ID_DepositoMercaderias = 1, Cantidad_Mercaderia = 250},
            new OrdenesDePreparacionItems {ID_OPMercaderia = 2, ID_OP = 4, ID_DepositoMercaderias = 2, Cantidad_Mercaderia = 120},
            new OrdenesDePreparacionItems {ID_OPMercaderia = 3, ID_OP = 2, ID_DepositoMercaderias = 3, Cantidad_Mercaderia = 210},
            new OrdenesDePreparacionItems {ID_OPMercaderia = 4, ID_OP = 3, ID_DepositoMercaderias = 2, Cantidad_Mercaderia = 370},
        };

        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {
            new DepositoMercaderias { ID_DepositoMercaderias = 0, ID_Cliente = 0, ID_Deposito = 0, ID_Mercaderia = 0, Cantidad_DepositoMercaderias = 0, Coordenadas_DepositoMercaderias = "0-0-0"},
            new DepositoMercaderias { ID_DepositoMercaderias = 1, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 200, Coordenadas_DepositoMercaderias = "12-43-2"},
            new DepositoMercaderias { ID_DepositoMercaderias = 2, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
            new DepositoMercaderias { ID_DepositoMercaderias = 3, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 300, Coordenadas_DepositoMercaderias = "15-32-7"},
        };



        public List<OrdenesDeSeleccion> OrdenesDeSeleccion { get; set; } = new List<OrdenesDeSeleccion>
        {
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.EMITIDA, ID_OS = 1, Emision_OrdenDeSeleccion = DateTime.Now},
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.EMITIDA, ID_OS = 2, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(1)},
        };


        public List<OrdenesDeEntrega> OrdenesDeEntrega { get; set; } = new List<OrdenesDeEntrega>
        {
            new OrdenesDeEntrega {ID_OE = 1, Emision_OrdenDeEntrega = DateTime.Now, Procesado_OrdenDeEntrega  = false},
            new OrdenesDeEntrega {ID_OE = 2, Emision_OrdenDeEntrega = DateTime.Now.AddMonths(1), Procesado_OrdenDeEntrega = true},
        };



        public string EditarEstadoOP(List<int> ordenesDePreparacion)
        {
            foreach (var item in ordenesDePreparacion)
            {
                var ordenDePreparacion = OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

                ordenDePreparacion.Estado_OP = EstadoOPEnum.DESPACHADA;
                ordenDePreparacion.ID_Remito = 0;

            }

            return null;
        }
    }
}
