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
            File.WriteAllText(@"Datos\DepositosMercaderias.json", datos);
        }

        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "DepositosMercaderias.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            var datos = File.ReadAllText(rutaArchivo);
            depositosmercaderias = JsonSerializer.Deserialize<List<DepositoMercaderiaEnt>>(datos)!;
        }
    }
}
