using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class MercaderiaAlmacen
    {

        private static List<MercaderiaEnt> mercaderias = new List<MercaderiaEnt>();

        public static IReadOnlyCollection<MercaderiaEnt> Mercaderias => mercaderias.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(mercaderias);
            File.WriteAllText(@"Mercaderias.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Mercaderias.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Mercaderias.json");
            mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnt>>(datos)!;
        }
    }
}
