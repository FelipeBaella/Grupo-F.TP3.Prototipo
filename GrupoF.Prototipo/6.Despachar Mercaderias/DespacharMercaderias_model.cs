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
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 1, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Id_Deposito = 2, Dni_transportista = 11111111, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 2, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(2), Id_Deposito = 3, Dni_transportista = 22222222, Id_OrdenDeEntrega = 2, Id_OrdenDeSeleccion = 2, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 3, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = true, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(3), Id_Deposito = 1, Dni_transportista = 11111111, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 3, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 4, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(4), Id_Deposito = 2, Dni_transportista = 22222222, Id_OrdenDeEntrega = 2, Id_OrdenDeSeleccion = 4, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 5, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(5), Id_Deposito = 3, Dni_transportista = 11111111, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 6, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = false, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Id_Deposito = 1, Dni_transportista = 22222222, Id_OrdenDeEntrega = 2, Id_OrdenDeSeleccion = 2, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 7, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = true, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(2), Id_Deposito = 2, Dni_transportista = 11111111, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 3, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 8, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = false, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(3), Id_Deposito = 3, Dni_transportista = 22222222, Id_OrdenDeEntrega = 2, Id_OrdenDeSeleccion = 4, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 9, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = true, Id_Cliente = 3, Emision_OrdenDePreparacion = DateTime.Now.AddDays(4), Id_Deposito = 1, Dni_transportista = 11111111, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 1, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 10, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = false, Id_Cliente = 1, Emision_OrdenDePreparacion = DateTime.Now.AddDays(5), Id_Deposito = 2, Dni_transportista = 22222222, Id_OrdenDeEntrega = 2, Id_OrdenDeSeleccion = 2, Id_Remito = null },
            new OrdenesDePreparacion { Id_OrdenDePreparacion = 11, Id_EstadoOP = 5, Prioridad_OrdenDePreparacion = true, Id_Cliente = 2, Emision_OrdenDePreparacion = DateTime.Now.AddDays(1), Id_Deposito = 3, Dni_transportista = 11111111, Id_OrdenDeEntrega = 1, Id_OrdenDeSeleccion = 3, Id_Remito = null },

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


        public List<OrdenesDeEntrega> OrdenesDeEntrega { get; set; } = new List<OrdenesDeEntrega>
        {
            new OrdenesDeEntrega {Id_OrdenDeEntrega = 1, Emision_OrdenDeEntrega = DateTime.Now, Procesado_OrdenDeEntrega  = false},
            new OrdenesDeEntrega {Id_OrdenDeEntrega = 2, Emision_OrdenDeEntrega = DateTime.Now.AddMonths(1), Procesado_OrdenDeEntrega = true},
        };



        public string EditarEstadoOP(List<int> ordenesDePreparacion)
        {
            foreach (var item in ordenesDePreparacion)
            {
                var ordenDePreparacion = OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == item).SingleOrDefault();

                ordenDePreparacion.Id_EstadoOP = 6;
                ordenDePreparacion.Id_Remito = 0;

            }

            return null;
        }
    }
}
