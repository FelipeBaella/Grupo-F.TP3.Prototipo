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

        private static List<DepositoMercaderiaEnt> depositosmercaderias = new List<DepositoMercaderiaEnt>();

        public static IReadOnlyCollection<DepositoMercaderiaEnt> DepositosMercaderias => depositosmercaderias.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositosmercaderias);
            File.WriteAllText(@"DepositosMercaderias.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("DepositosMercaderias.json"))
            {
                return;
            }

            var datos = File.ReadAllText("DepositosMercaderias.json");
            depositosmercaderias = JsonSerializer.Deserialize<List<DepositoMercaderiaEnt>>(datos)!;
        }
    }
}
