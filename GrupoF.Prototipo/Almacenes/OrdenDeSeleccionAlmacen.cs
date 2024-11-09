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

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenesdeseleccion);
            File.WriteAllText(@"OrdenesDeSeleccion.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("OrdenesDeSeleccion.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenesDeSeleccion.json");
            ordenesdeseleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEnt>>(datos)!;
        }
    }
}
