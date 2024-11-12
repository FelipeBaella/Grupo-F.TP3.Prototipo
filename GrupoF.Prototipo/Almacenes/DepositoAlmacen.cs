using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class DepositoAlmacen
    {

        private static List<DepositoEnt> depositos = new List<DepositoEnt>();

        public static IReadOnlyCollection<DepositoEnt> Depositos => depositos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositos);
            File.WriteAllText(@"Datos\Depositos.json", datos);
        }

        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Depositos.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            var datos = File.ReadAllText(rutaArchivo);
            depositos = JsonSerializer.Deserialize<List<DepositoEnt>>(datos)!;
        }
    }
}
