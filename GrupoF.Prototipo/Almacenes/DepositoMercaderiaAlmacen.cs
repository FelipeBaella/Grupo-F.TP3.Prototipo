using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class DepositoMercaderiaAlmacen
    {

        //private static List<DepositoMercaderiaEnt> depositosmercaderias = new List<DepositoMercaderiaEnt>();

        private static List<DepositoMercaderiaEnt> depositosmercaderias { get; set; } = new List<DepositoMercaderiaEnt>
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

        public static IReadOnlyCollection<DepositoMercaderiaEnt> DepositosMercaderias => depositosmercaderias.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositosmercaderias);
            File.WriteAllText(@"DepositosMercaderias.json", datos);
        }

        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "DepositosMercaderias.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            var datos = File.ReadAllText("DepositosMercaderias.json");
            depositosmercaderias = JsonSerializer.Deserialize<List<DepositoMercaderiaEnt>>(datos)!;
        }
    }
}
