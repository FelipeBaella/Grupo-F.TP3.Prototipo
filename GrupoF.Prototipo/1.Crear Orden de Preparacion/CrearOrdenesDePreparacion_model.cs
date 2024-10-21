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

        public List<DepositoMercaderias> DepositoMercaderias { get; set; } = new List<DepositoMercaderias>
        {

            // Acá está bien el último registro? Es exactamente igual al penultimo, sólo cambia "Id_DepositoMercaderías".

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



        public List<OrdenesDePreparacion> OrdenesDePreparacion = new();
        public string CrearOrdenesDePreparacion(OrdenesDePreparacion ordenDePreparacion)
        {
            var Id_EstadoOP = ordenDePreparacion.Id_EstadoOP;
            var Prioridad_OrdenDePreparacion = ordenDePreparacion.Prioridad_OrdenDePreparacion;
            var Id_Cliente = ordenDePreparacion.Id_Cliente;
            var Emision_OrdenDePreparacion = ordenDePreparacion.Emision_OrdenDePreparacion;
            var Id_Deposito = ordenDePreparacion.Id_Deposito;
            var Dni_transportista = ordenDePreparacion.Dni_transportista;

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
