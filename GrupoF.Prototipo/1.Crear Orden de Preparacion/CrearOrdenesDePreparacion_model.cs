
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoF.Prototipo.Almacenes;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class CrearOrdnesDePreparacion_model
    {
        public List<ClienteEnt> Clientes { get; set; } = new List<ClienteEnt>
        {


            // SET DE DATOS DE 3 CLIENTES:
            new ClienteEnt { ID_Cliente = 0, DNI_Cliente = 0, NombreApellido_Cliente = "---"},
            new ClienteEnt { ID_Cliente = 1, DNI_Cliente = 3456789, NombreApellido_Cliente = "Juan Pérez", CUIT_Cliente = 20345678901, Domicilio_Cliente = "Calle Falsa 123, Ciudad", CondIVA_Cliente = "Si" },
            new ClienteEnt { ID_Cliente = 2, DNI_Cliente = 45678901, NombreApellido_Cliente = "María Gómez", CUIT_Cliente = 27456789012, Domicilio_Cliente = "Av. Siempre Viva 456, Provincia", CondIVA_Cliente = "No" },
            new ClienteEnt { ID_Cliente = 3, DNI_Cliente = 5678901, NombreApellido_Cliente = "Carlos López", CUIT_Cliente = 20567890123, Domicilio_Cliente = "Calle del Sol 789, Capital Federal", CondIVA_Cliente = "Si" },

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


        public List<DepositoMercaderiaEnt> DepositoMercaderia { get; set; } = new List<DepositoMercaderiaEnt>
        {

            //  SET DE DATOS DE 50 slots de espacios distribuidos en 3 Clientes:
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 1, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 550, Coordenadas_DepositoMercaderia = "12-34-5" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 2, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "23-45-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 3, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "34-56-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 4, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "45-67-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 5, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "56-78-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 6, ID_Cliente = 3, ID_Deposito = 1, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 500, Coordenadas_DepositoMercaderia = "67-89-0" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 7, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 650, Coordenadas_DepositoMercaderia = "78-90-5" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 8, ID_Cliente = 2, ID_Deposito = 3, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "89-01-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 9, ID_Cliente = 3, ID_Deposito = 4, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "90-12-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 10, ID_Cliente = 1, ID_Deposito = 5, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "01-23-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 11, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "12-34-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 12, ID_Cliente = 3, ID_Deposito = 2, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 550, Coordenadas_DepositoMercaderia = "23-45-5" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 13, ID_Cliente = 1, ID_Deposito = 3, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "34-56-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 14, ID_Cliente = 2, ID_Deposito = 4, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "45-67-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 15, ID_Cliente = 3, ID_Deposito = 5, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "56-78-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 16, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "67-89-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 17, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 500, Coordenadas_DepositoMercaderia = "78-90-0" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 18, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 650, Coordenadas_DepositoMercaderia = "89-01-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 19, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "90-12-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 20, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "01-23-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 21, ID_Cliente = 3, ID_Deposito = 1, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "12-34-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 22, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "23-45-5" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 23, ID_Cliente = 2, ID_Deposito = 3, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 500, Coordenadas_DepositoMercaderia = "34-56-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 24, ID_Cliente = 3, ID_Deposito = 4, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 650, Coordenadas_DepositoMercaderia = "45-67-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 25, ID_Cliente = 1, ID_Deposito = 5, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "56-78-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 26, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "67-89-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 27, ID_Cliente = 3, ID_Deposito = 2, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "78-90-0" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 28, ID_Cliente = 1, ID_Deposito = 3, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "89-01-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 29, ID_Cliente = 2, ID_Deposito = 4, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 500, Coordenadas_DepositoMercaderia = "90-12-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 30, ID_Cliente = 3, ID_Deposito = 5, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 650, Coordenadas_DepositoMercaderia = "01-23-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 31, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "12-34-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 32, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "23-45-5" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 33, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "34-56-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 34, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "45-67-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 35, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 500, Coordenadas_DepositoMercaderia = "56-78-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 36, ID_Cliente = 3, ID_Deposito = 1, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 650, Coordenadas_DepositoMercaderia = "67-89-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 37, ID_Cliente = 1, ID_Deposito = 2, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "78-90-0" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 38, ID_Cliente = 2, ID_Deposito = 3, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "89-01-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 39, ID_Cliente = 3, ID_Deposito = 4, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "90-12-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 40, ID_Cliente = 1, ID_Deposito = 5, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "01-23-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 41, ID_Cliente = 2, ID_Deposito = 1, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 500, Coordenadas_DepositoMercaderia = "12-34-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 42, ID_Cliente = 3, ID_Deposito = 2, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 650, Coordenadas_DepositoMercaderia = "23-45-5" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 43, ID_Cliente = 1, ID_Deposito = 3, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "34-56-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 44, ID_Cliente = 2, ID_Deposito = 4, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "45-67-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 45, ID_Cliente = 3, ID_Deposito = 5, ID_Mercaderia = 3, Cantidad_DepositoMercaderia = 800, Coordenadas_DepositoMercaderia = "56-78-3" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 46, ID_Cliente = 1, ID_Deposito = 1, ID_Mercaderia = 4, Cantidad_DepositoMercaderia = 900, Coordenadas_DepositoMercaderia = "67-89-4" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 47, ID_Cliente = 2, ID_Deposito = 2, ID_Mercaderia = 5, Cantidad_DepositoMercaderia = 500, Coordenadas_DepositoMercaderia = "78-90-0" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 48, ID_Cliente = 3, ID_Deposito = 3, ID_Mercaderia = 6, Cantidad_DepositoMercaderia = 650, Coordenadas_DepositoMercaderia = "89-01-1" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 49, ID_Cliente = 1, ID_Deposito = 4, ID_Mercaderia = 1, Cantidad_DepositoMercaderia = 600, Coordenadas_DepositoMercaderia = "90-12-2" },
            new DepositoMercaderiaEnt { ID_DepositoMercaderia = 50, ID_Cliente = 2, ID_Deposito = 5, ID_Mercaderia = 2, Cantidad_DepositoMercaderia = 700, Coordenadas_DepositoMercaderia = "01-23-3" },

        };



        public List<OrdenDePreparacionEnt> OrdenDePreparacionEnt = new();
        public string CrearOrdenesDePreparacion(OrdenDePreparacionEnt ordenDePreparacion)
        {
            var Estado_OP = ordenDePreparacion.Estado_OP;
            var Prioridad_OP = ordenDePreparacion.Prioridad_OP;
            var ID_Cliente = ordenDePreparacion.ID_Cliente;
            var FechaEmision_OP = ordenDePreparacion.FechaEmision_OP;
            var FechaEntrega_OP = ordenDePreparacion.FechaEntrega_OP;
            //var FechaEnFechaActualizacionEstado_OPtrega_OP = ordenDePreparacion.FechaActualizacionEstado_OP;
            var ID_Deposito = ordenDePreparacion.ID_Deposito;
            var DNI_Transportista = ordenDePreparacion.DNI_Transportista;
            var Mercaderias_OP = ordenDePreparacion.Mercaderias_OP;

            if (DNI_Transportista < 10_000_000 || DNI_Transportista > 99_999_999)
            {
                return "El DNI_Cliente ingresado debe tener 8 dígitos.";
            }

            if (FechaEmision_OP < DateTime.Now.Date)
            {
                return "La fecha de emision no puede ser menor al dia de hoy.";
            }


            var OP = GrupoF.Prototipo.Almacenes.OrdenDePreparacionAlmacen.OrdenesDePreparacion;

            if (OP.Count > 0)
            {
                ordenDePreparacion.ID_OP = OP.Last().ID_OP + 1;
            }
            else
            {
                ordenDePreparacion.ID_OP = 1;
            }

            OrdenDePreparacionAlmacen.Grabar(ordenDePreparacion);

            return ordenDePreparacion.ID_OP.ToString();
        }


        //public string CrearOrdenesDePreparacionItem(Mercaderia_OP OrdeneDePreparacionItem)
        //{
        //    var ID_DepositoMercaderia = OrdeneDePreparacionItem.ID_Mercaderia;
        //    var Cantidad_Mercaderia = OrdeneDePreparacionItem.Cantidad_Mercaderia;

        //    OrdenesDePreparacionItems.(OrdeneDePreparacionItem);

        //    OrdenDePreparacionAlmacen.Grabar(OrdeneDePreparacionItem);

        //    return null;
        //}



    }
}
