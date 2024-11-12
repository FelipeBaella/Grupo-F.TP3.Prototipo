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
            File.WriteAllText(@"Datos\Mercaderias.json", datos);
        }

        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Mercaderias.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            var datos = File.ReadAllText(rutaArchivo);
            mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnt>>(datos)!;
        }
    }
}
