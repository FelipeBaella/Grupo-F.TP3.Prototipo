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


        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {

            //  SET DE DATOS DE 50 slots de espacios distribuidos en 3 Clientes:
            new DepositoMercaderias { ID_DepositoMercaderias = 1, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 550, Coordenadas_DepositoMercaderias = "12-34-5" },
            new DepositoMercaderias { ID_DepositoMercaderias = 2, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "23-45-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 3, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "34-56-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 4, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "45-67-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 5, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "56-78-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 6, ID_Cliente = 3, ID_Deposito = 1, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "67-89-0" },
            new DepositoMercaderias { ID_DepositoMercaderias = 7, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "78-90-5" },
            new DepositoMercaderias { ID_DepositoMercaderias = 8, ID_Cliente = 2, ID_Deposito = 3, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 9, ID_Cliente = 3, ID_Deposito = 4, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 10, ID_Cliente = 1, ID_Deposito = 5, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 11, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 12, ID_Cliente = 3, ID_Deposito = 2, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 550, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { ID_DepositoMercaderias = 13, ID_Cliente = 1, ID_Deposito = 3, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 14, ID_Cliente = 2, ID_Deposito = 4, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 15, ID_Cliente = 3, ID_Deposito = 5, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 16, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 17, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { ID_DepositoMercaderias = 18, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 19, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 20, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 21, ID_Cliente = 3, ID_Deposito = 1, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 22, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { ID_DepositoMercaderias = 23, ID_Cliente = 2, ID_Deposito = 3, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 24, ID_Cliente = 3, ID_Deposito = 4, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 25, ID_Cliente = 1, ID_Deposito = 5, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 26, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 27, ID_Cliente = 3, ID_Deposito = 2, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { ID_DepositoMercaderias = 28, ID_Cliente = 1, ID_Deposito = 3, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 29, ID_Cliente = 2, ID_Deposito = 4, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 30, ID_Cliente = 3, ID_Deposito = 5, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 31, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 32, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { ID_DepositoMercaderias = 33, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 34, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 35, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 36, ID_Cliente = 3, ID_Deposito = 1, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 37, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { ID_DepositoMercaderias = 38, ID_Cliente = 2, ID_Deposito = 3, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 39, ID_Cliente = 3, ID_Deposito = 4, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 40, ID_Cliente = 1, ID_Deposito = 5, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "01-23-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 41, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "12-34-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 42, ID_Cliente = 3, ID_Deposito = 2, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "23-45-5" },
            new DepositoMercaderias { ID_DepositoMercaderias = 43, ID_Cliente = 1, ID_Deposito = 3, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "34-56-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 44, ID_Cliente = 2, ID_Deposito = 4, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "45-67-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 45, ID_Cliente = 3, ID_Deposito = 5, ID_Mercaderia = 3, Cantidad_DepositoMercaderias = 800, Coordenadas_DepositoMercaderias = "56-78-3" },
            new DepositoMercaderias { ID_DepositoMercaderias = 46, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 4, Cantidad_DepositoMercaderias = 900, Coordenadas_DepositoMercaderias = "67-89-4" },
            new DepositoMercaderias { ID_DepositoMercaderias = 47, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 5, Cantidad_DepositoMercaderias = 500, Coordenadas_DepositoMercaderias = "78-90-0" },
            new DepositoMercaderias { ID_DepositoMercaderias = 48, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 6, Cantidad_DepositoMercaderias = 650, Coordenadas_DepositoMercaderias = "89-01-1" },
            new DepositoMercaderias { ID_DepositoMercaderias = 49, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 1, Cantidad_DepositoMercaderias = 600, Coordenadas_DepositoMercaderias = "90-12-2" },
            new DepositoMercaderias { ID_DepositoMercaderias = 50, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 2, Cantidad_DepositoMercaderias = 700, Coordenadas_DepositoMercaderias = "01-23-3" },

        };



        public List<OrdenesDePreparacion> OrdenesDePreparacion = new();
        public string CrearOrdenesDePreparacion(OrdenesDePreparacion ordenDePreparacion)
        {
            var Estado_OP = ordenDePreparacion.Estado_OP;
            var Prioridad_OP = ordenDePreparacion.Prioridad_OP;
            var ID_Cliente = ordenDePreparacion.ID_Cliente;
            var FechaEmision_OP = ordenDePreparacion.FechaEmision_OP;
            var ID_Deposito = ordenDePreparacion.ID_Deposito;
            var Dni_transportista = ordenDePreparacion.Dni_transportista;

            if (Dni_transportista < 10_000_000 || Dni_transportista > 99_999_999)
            {
                return "El DNI ingresado debe tener 8 dígitos.";
            }

            if (FechaEmision_OP < DateTime.Now.Date)
            {
                return "La fecha de emision no puede ser menor al dia de hoy.";
            }

            OrdenesDePreparacion.Add(ordenDePreparacion);

            return null;
        }


        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems = new();
        public string CrearOrdenesDePreparacionItem(OrdenesDePreparacionItems OrdeneDePreparacionItem)
        {
            var ID_OPMercaderia = OrdenesDePreparacionItems.Count + 1;
            var ID_OP = OrdenesDePreparacion.Last().ID_OP;
            var ID_DepositoMercaderias = OrdeneDePreparacionItem.ID_DepositoMercaderias;
            var Cantidad_Mercaderia = OrdeneDePreparacionItem.Cantidad_Mercaderia;

            OrdenesDePreparacionItems.Add(OrdeneDePreparacionItem);

            return null;
        }



    }
}
