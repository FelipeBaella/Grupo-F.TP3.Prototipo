using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class OrdenDeSeleccionAlmacen
    {

        private static List<OrdenDeSeleccionEnt> ordenesdeseleccion = new List<OrdenDeSeleccionEnt>();

        public static IReadOnlyCollection<OrdenDeSeleccionEnt> OrdenesDeSeleccion => ordenesdeseleccion.AsReadOnly();

        public static void Nueva(OrdenDeSeleccionEnt OrdenDeSeleccion)
        {
            ordenesdeseleccion.Add(OrdenDeSeleccion);
        }

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenesdeseleccion);
            File.WriteAllText(@"OrdenesDeSeleccion.json", datos);
        }

        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OrdenesDeSeleccion.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists("OrdenesDeSeleccion.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenesDeSeleccion.json");
            ordenesdeseleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEnt>>(datos)!;
        }
    }
}
