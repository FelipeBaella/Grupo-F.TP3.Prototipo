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
            File.WriteAllText(@"Datos\Usuarios.json", datos);
        }

        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Usuarios.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            var datos = File.ReadAllText(rutaArchivo);
            usuarios = JsonSerializer.Deserialize<List<UsuarioEnt>>(datos)!;
        }
    }
}
