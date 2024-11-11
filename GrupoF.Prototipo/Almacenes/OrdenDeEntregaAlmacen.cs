using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class OrdenDeEntregaAlmacen
    {

        private static List<OrdenDeEntregaEnt> ordenesdeentrega = new List<OrdenDeEntregaEnt>();

        public static IReadOnlyCollection<OrdenDeEntregaEnt> OrdenesDeEntrega => ordenesdeentrega.AsReadOnly();

        public static void Nueva(OrdenDeEntregaEnt ordenDeEntrega)
        {
            ordenesdeentrega.Add(ordenDeEntrega);
        }

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenesdeentrega);
            File.WriteAllText(@"OrdenesDeEntrega.json", datos);
        }

        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "OrdenesDeEntrega.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            var datos = File.ReadAllText(rutaArchivo);
            ordenesdeentrega = JsonSerializer.Deserialize<List<OrdenDeEntregaEnt>>(datos)!;
        }
    }
}
