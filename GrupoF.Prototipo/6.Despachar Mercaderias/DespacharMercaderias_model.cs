
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Almacenes;
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

        public List<MercaderiaEnt> Mercaderias { get; set; } = new List<MercaderiaEnt>
        {
            // SET DE DATOS DE 6 TIPOS DE MERCADERÍAS:
            new MercaderiaEnt { ID_Mercaderia = 0, Descripcion_Mercaderia = "---"},
            new MercaderiaEnt { ID_Mercaderia = 1, Descripcion_Mercaderia = "Termos Negros" },
            new MercaderiaEnt { ID_Mercaderia = 2, Descripcion_Mercaderia = "Mates Aluminio" },
            new MercaderiaEnt { ID_Mercaderia = 3, Descripcion_Mercaderia = "Remeras Gris" },
            new MercaderiaEnt { ID_Mercaderia = 4, Descripcion_Mercaderia = "Zapatillas Adidas" },
            new MercaderiaEnt { ID_Mercaderia = 5, Descripcion_Mercaderia = "Buzos Blancos" },
            new MercaderiaEnt { ID_Mercaderia = 6, Descripcion_Mercaderia = "Yerba" },
        };

        public List<DepositoEnt> Depositos { get; set; } = new List<DepositoEnt>
        {
            // SET DE DATOS DE LOS 12 DEPÓSITOS:
            new DepositoEnt { ID_Deposito = 0, Descripcion_Deposito = "---" },
            new DepositoEnt { ID_Deposito = 1, Descripcion_Deposito = "GBAS 1" },
            new DepositoEnt { ID_Deposito = 2, Descripcion_Deposito = "GBAS 2" },
            new DepositoEnt { ID_Deposito = 3, Descripcion_Deposito = "GBAN 1" },
            new DepositoEnt { ID_Deposito = 4, Descripcion_Deposito = "GBAN 2" },
            new DepositoEnt { ID_Deposito = 5, Descripcion_Deposito = "ROS" },
            new DepositoEnt { ID_Deposito = 6, Descripcion_Deposito = "CBA" },
            new DepositoEnt { ID_Deposito = 7, Descripcion_Deposito = "MDZ" },
            new DepositoEnt { ID_Deposito = 8, Descripcion_Deposito = "BHB" },
            new DepositoEnt { ID_Deposito = 9, Descripcion_Deposito = "USH" },
            new DepositoEnt { ID_Deposito = 10, Descripcion_Deposito = "STA" },
            new DepositoEnt { ID_Deposito = 11, Descripcion_Deposito = "NQN" },
            new DepositoEnt { ID_Deposito = 12, Descripcion_Deposito = "MSN" }
        };






        public List<Usuarios> Usuarios { get; set; } = new List<Usuarios>
        {
            new Usuarios {ID_Cliente = 0, ID_Usuario = 0, LogIn_usuario = "Admin", Contrasena_usuario = "123"},
            new Usuarios {ID_Cliente = 1, ID_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},
        };




        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems { get; set; } = new List<OrdenesDePreparacionItems>
        {
            new OrdenesDePreparacionItems {ID_OPMercaderia = 1, ID_OP = 1, ID_DepositoMercaderia = 1, Cantidad_Mercaderia = 250},
            new OrdenesDePreparacionItems {ID_OPMercaderia = 2, ID_OP = 4, ID_DepositoMercaderia = 2, Cantidad_Mercaderia = 120},
            new OrdenesDePreparacionItems {ID_OPMercaderia = 3, ID_OP = 2, ID_DepositoMercaderia = 3, Cantidad_Mercaderia = 210},
            new OrdenesDePreparacionItems {ID_OPMercaderia = 4, ID_OP = 3, ID_DepositoMercaderia = 2, Cantidad_Mercaderia = 370},
        };

        public List<DepositoMercaderiaEnt> DepositoMercaderiaEnt { get; set; } = new List<DepositoMercaderiaEnt>
        {
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 0, ID_Cliente = 0, ID_Deposito = 0, ID_Mercaderia = 0, Cantidad_DepositoMercaderia = 0, Coordenadas_DepositoMercaderia = "0-0-0"},
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 1, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 200, Coordenadas_DepositoMercaderia = "12-43-2"},
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 2, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 300, Coordenadas_DepositoMercaderia = "15-32-7"},
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 3, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 300, Coordenadas_DepositoMercaderia = "15-32-7"},
        };



        public List<OrdenesDeSeleccion> OrdenesDeSeleccion { get; set; } = new List<OrdenesDeSeleccion>
        {
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.Emitida, ID_OS = 1, Emision_OrdenDeSeleccion = DateTime.Now},
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.Emitida, ID_OS = 2, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(1)},
        };


        public List<OrdenesDeEntrega> OrdenesDeEntrega { get; set; } = new List<OrdenesDeEntrega>
        {
            new OrdenesDeEntrega {ID_OE = 1, Emision_OrdenDeEntrega = DateTime.Now, Procesado_OrdenDeEntrega  = false},
            new OrdenesDeEntrega {ID_OE = 2, Emision_OrdenDeEntrega = DateTime.Now.AddMonths(1), Procesado_OrdenDeEntrega = true},
        };



        //public string EditarEstadoOP(List<int> OrdenDePreparacion)
        //{
        //    foreach (var item in OrdenDePreparacion)
        //    {
        //        var ordenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == item).SingleOrDefault();

        //        ordenDePreparacion.Estado_OP = EstadoOPEnum.Despachada;
        //        ordenDePreparacion.ID_Remito = 0;

        //    }

        //    return null;
        //}
    }
}
