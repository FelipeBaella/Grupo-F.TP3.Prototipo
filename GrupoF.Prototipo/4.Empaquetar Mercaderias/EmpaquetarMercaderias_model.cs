
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class EmpaquetarMercaderias_model
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

            // CREO QUE ESTA LISTA NO ES NECESARIA ACÁ, PERO TE DEJO LOS USUARIOS QUE USASTE PARA EL LOGGIN PARA DEJARLO HOMOGENEO EN TODO CASO.
            // new Usuarios {ID_Cliente = 0, ID_Usuario = 0, LogIn_usuario = "1", Contrasena_usuario = "1"},
            // new Usuarios {ID_Cliente = 1, ID_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},
        };




        public List<OrdenesDePreparacionItems> OrdenesDePreparacionItems { get; set; } = new List<OrdenesDePreparacionItems>
        {
            // Set de datos de 100 Items de OP asociados a 11 Ordenes de Preparación
            new OrdenesDePreparacionItems { ID_OPMercaderia = 1, ID_OP = 1, ID_DepositoMercaderia = 5, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 2, ID_OP = 2, ID_DepositoMercaderia = 12, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 3, ID_OP = 3, ID_DepositoMercaderia = 18, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 4, ID_OP = 4, ID_DepositoMercaderia = 25, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 5, ID_OP = 5, ID_DepositoMercaderia = 30, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 6, ID_OP = 6, ID_DepositoMercaderia = 4, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 7, ID_OP = 7, ID_DepositoMercaderia = 8, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 8, ID_OP = 8, ID_DepositoMercaderia = 15, Cantidad_Mercaderia = 13 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 9, ID_OP = 9, ID_DepositoMercaderia = 22, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 10, ID_OP = 10, ID_DepositoMercaderia = 28, Cantidad_Mercaderia = 20 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 11, ID_OP = 11, ID_DepositoMercaderia = 35, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 12, ID_OP = 1, ID_DepositoMercaderia = 42, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 13, ID_OP = 2, ID_DepositoMercaderia = 14, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 14, ID_OP = 3, ID_DepositoMercaderia = 11, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 15, ID_OP = 4, ID_DepositoMercaderia = 19, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 16, ID_OP = 5, ID_DepositoMercaderia = 27, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 17, ID_OP = 6, ID_DepositoMercaderia = 33, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 18, ID_OP = 7, ID_DepositoMercaderia = 2, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 19, ID_OP = 8, ID_DepositoMercaderia = 6, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 20, ID_OP = 9, ID_DepositoMercaderia = 9, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 21, ID_OP = 10, ID_DepositoMercaderia = 31, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 22, ID_OP = 11, ID_DepositoMercaderia = 7, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 23, ID_OP = 1, ID_DepositoMercaderia = 15, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 24, ID_OP = 2, ID_DepositoMercaderia = 25, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 25, ID_OP = 3, ID_DepositoMercaderia = 38, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 26, ID_OP = 4, ID_DepositoMercaderia = 1, Cantidad_Mercaderia = 20 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 27, ID_OP = 5, ID_DepositoMercaderia = 29, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 28, ID_OP = 6, ID_DepositoMercaderia = 36, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 29, ID_OP = 7, ID_DepositoMercaderia = 44, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 30, ID_OP = 8, ID_DepositoMercaderia = 3, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 31, ID_OP = 9, ID_DepositoMercaderia = 18, Cantidad_Mercaderia = 19 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 32, ID_OP = 10, ID_DepositoMercaderia = 12, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 33, ID_OP = 11, ID_DepositoMercaderia = 40, Cantidad_Mercaderia = 16 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 34, ID_OP = 1, ID_DepositoMercaderia = 5, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 35, ID_OP = 2, ID_DepositoMercaderia = 9, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 36, ID_OP = 3, ID_DepositoMercaderia = 22, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 37, ID_OP = 4, ID_DepositoMercaderia = 11, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 38, ID_OP = 5, ID_DepositoMercaderia = 33, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 39, ID_OP = 6, ID_DepositoMercaderia = 14, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 40, ID_OP = 7, ID_DepositoMercaderia = 37, Cantidad_Mercaderia = 20 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 41, ID_OP = 8, ID_DepositoMercaderia = 15, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 42, ID_OP = 9, ID_DepositoMercaderia = 3, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 43, ID_OP = 10, ID_DepositoMercaderia = 8, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 44, ID_OP = 11, ID_DepositoMercaderia = 19, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 45, ID_OP = 1, ID_DepositoMercaderia = 26, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 46, ID_OP = 2, ID_DepositoMercaderia = 42, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 47, ID_OP = 3, ID_DepositoMercaderia = 1, Cantidad_Mercaderia = 13 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 48, ID_OP = 4, ID_DepositoMercaderia = 7, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 49, ID_OP = 5, ID_DepositoMercaderia = 38, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 50, ID_OP = 6, ID_DepositoMercaderia = 24, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 51, ID_OP = 7, ID_DepositoMercaderia = 36, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 52, ID_OP = 8, ID_DepositoMercaderia = 43, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 53, ID_OP = 9, ID_DepositoMercaderia = 4, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 54, ID_OP = 10, ID_DepositoMercaderia = 32, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 55, ID_OP = 11, ID_DepositoMercaderia = 10, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 56, ID_OP = 1, ID_DepositoMercaderia = 28, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 57, ID_OP = 2, ID_DepositoMercaderia = 11, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 58, ID_OP = 3, ID_DepositoMercaderia = 29, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 59, ID_OP = 4, ID_DepositoMercaderia = 30, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 60, ID_OP = 5, ID_DepositoMercaderia = 15, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 61, ID_OP = 6, ID_DepositoMercaderia = 20, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 62, ID_OP = 7, ID_DepositoMercaderia = 7, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 63, ID_OP = 8, ID_DepositoMercaderia = 17, Cantidad_Mercaderia = 19 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 64, ID_OP = 9, ID_DepositoMercaderia = 39, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 65, ID_OP = 10, ID_DepositoMercaderia = 18, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 66, ID_OP = 11, ID_DepositoMercaderia = 22, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 67, ID_OP = 1, ID_DepositoMercaderia = 10, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 68, ID_OP = 2, ID_DepositoMercaderia = 34, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 69, ID_OP = 3, ID_DepositoMercaderia = 28, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 70, ID_OP = 4, ID_DepositoMercaderia = 2, Cantidad_Mercaderia = 13 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 71, ID_OP = 5, ID_DepositoMercaderia = 48, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 72, ID_OP = 6, ID_DepositoMercaderia = 50, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 73, ID_OP = 7, ID_DepositoMercaderia = 13, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 74, ID_OP = 8, ID_DepositoMercaderia = 16, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 75, ID_OP = 9, ID_DepositoMercaderia = 24, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 76, ID_OP = 10, ID_DepositoMercaderia = 5, Cantidad_Mercaderia = 18 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 77, ID_OP = 11, ID_DepositoMercaderia = 40, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 78, ID_OP = 1, ID_DepositoMercaderia = 3, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 79, ID_OP = 2, ID_DepositoMercaderia = 39, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 80, ID_OP = 3, ID_DepositoMercaderia = 12, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 81, ID_OP = 4, ID_DepositoMercaderia = 45, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 82, ID_OP = 5, ID_DepositoMercaderia = 6, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 83, ID_OP = 6, ID_DepositoMercaderia = 8, Cantidad_Mercaderia = 5 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 84, ID_OP = 7, ID_DepositoMercaderia = 10, Cantidad_Mercaderia = 2 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 85, ID_OP = 8, ID_DepositoMercaderia = 21, Cantidad_Mercaderia = 9 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 86, ID_OP = 9, ID_DepositoMercaderia = 4, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 87, ID_OP = 10, ID_DepositoMercaderia = 33, Cantidad_Mercaderia = 7 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 88, ID_OP = 11, ID_DepositoMercaderia = 35, Cantidad_Mercaderia = 12 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 89, ID_OP = 1, ID_DepositoMercaderia = 30, Cantidad_Mercaderia = 4 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 90, ID_OP = 2, ID_DepositoMercaderia = 15, Cantidad_Mercaderia = 17 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 91, ID_OP = 3, ID_DepositoMercaderia = 18, Cantidad_Mercaderia = 8 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 92, ID_OP = 4, ID_DepositoMercaderia = 40, Cantidad_Mercaderia = 14 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 93, ID_OP = 5, ID_DepositoMercaderia = 42, Cantidad_Mercaderia = 6 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 94, ID_OP = 6, ID_DepositoMercaderia = 46, Cantidad_Mercaderia = 11 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 95, ID_OP = 7, ID_DepositoMercaderia = 27, Cantidad_Mercaderia = 3 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 96, ID_OP = 8, ID_DepositoMercaderia = 32, Cantidad_Mercaderia = 15 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 97, ID_OP = 9, ID_DepositoMercaderia = 2, Cantidad_Mercaderia = 1 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 98, ID_OP = 10, ID_DepositoMercaderia = 14, Cantidad_Mercaderia = 10 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 99, ID_OP = 11, ID_DepositoMercaderia = 48, Cantidad_Mercaderia = 16 },
            new OrdenesDePreparacionItems { ID_OPMercaderia = 100, ID_OP = 1, ID_DepositoMercaderia = 5, Cantidad_Mercaderia = 19 }
        };

        public List<DepositoMercaderiaEnt> DepositoMercaderiaEnt { get; set; } = new List<DepositoMercaderiaEnt>
        {
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



        public List<OrdenesDeSeleccion> OrdenesDeSeleccion { get; set; } = new List<OrdenesDeSeleccion>
        {
            // Set de Datos de 4 Ordenes de Selección
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.Emitida, ID_OS = 1, Emision_OrdenDeSeleccion = DateTime.Now},
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.Emitida, ID_OS = 2, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(1)},
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.Emitida, ID_OS = 3, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(2)},
            new OrdenesDeSeleccion {Estado_OS = EstadoOSEnum.Emitida, ID_OS = 4, Emision_OrdenDeSeleccion = DateTime.Now.AddMonths(3)}
        };


        public List<OrdenesDeEntrega> OrdenesDeEntrega { get; set; } = new List<OrdenesDeEntrega>
        {
            new OrdenesDeEntrega {ID_OE = 1, Emision_OrdenDeEntrega = DateTime.Now, Procesado_OrdenDeEntrega  = false},
            new OrdenesDeEntrega {ID_OE = 2, Emision_OrdenDeEntrega = DateTime.Now.AddMonths(1), Procesado_OrdenDeEntrega = true},
        };


        public string EditarEstadoOP(int id)
        {
            var OrdenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == id).SingleOrDefault();

            OrdenDePreparacion.Estado_OP = EstadoOPEnum.Preparada;

            var OrdenDePreparacionE = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == id).SingleOrDefault().Estado_OP;

            return null;
        }
    }
}
