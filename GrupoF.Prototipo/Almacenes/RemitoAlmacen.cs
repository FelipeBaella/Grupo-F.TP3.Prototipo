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

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(remitos);
            File.WriteAllText(@"Remitos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Remitos.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Remitos.json");
            remitos = JsonSerializer.Deserialize<List<RemitoEnt>>(datos)!;
        }
    }
}
