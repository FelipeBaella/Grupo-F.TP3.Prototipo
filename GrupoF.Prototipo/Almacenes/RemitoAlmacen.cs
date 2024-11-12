using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class RemitoAlmacen
    {

        private static List<RemitoEnt> remitos = new List<RemitoEnt>();

        public static IReadOnlyCollection<RemitoEnt> Remitos => remitos.AsReadOnly();

        public static void Nueva(RemitoEnt remito)
        {
            remitos.Add(remito);
        }

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(remitos);
            File.WriteAllText(@"Datos\Remitos.json", datos);
        }

        public static void Leer()
        {
            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(@"Datos\Remitos.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Datos\Remitos.json");
            remitos = JsonSerializer.Deserialize<List<RemitoEnt>>(datos)!;
        }
    }
}
