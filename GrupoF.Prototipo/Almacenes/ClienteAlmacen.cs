using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class ClienteAlmacen
    {

        private static List<ClienteEnt> clientes = new List<ClienteEnt>();

        public static IReadOnlyCollection<ClienteEnt> Clientes => clientes.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"Clientes.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Clientes.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Clientes.json");
            clientes = JsonSerializer.Deserialize<List<ClienteEnt>>(datos)!;
        }
    }
}
