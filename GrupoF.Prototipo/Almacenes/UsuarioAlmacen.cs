using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class UsuarioAlmacen
    {

        private static List<UsuarioEnt> usuarios = new List<UsuarioEnt>();

        public static IReadOnlyCollection<UsuarioEnt> Usuarios => usuarios.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(usuarios);
            File.WriteAllText(@"Usuarios.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Usuarios.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Usuarios.json");
            usuarios = JsonSerializer.Deserialize<List<UsuarioEnt>>(datos)!;
        }
    }
}
