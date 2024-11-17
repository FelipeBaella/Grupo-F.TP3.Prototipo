using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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



        private static int usuarioSeleccionado;
        public static int UsuarioSeleccionado => usuarioSeleccionado;

        public static void GrabarUsuario(int id_usuario)
        {
            usuarioSeleccionado = id_usuario; 
            var datos = JsonSerializer.Serialize(id_usuario);
            File.WriteAllText(@"Datos\UsuarioSeleccionado.json", datos);
        }
        public static void LeerUsuario()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "UsuarioSeleccionado.json");

        
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            var datos = File.ReadAllText(rutaArchivo); 
            usuarioSeleccionado = JsonSerializer.Deserialize<int>(datos)!; 
        }
    }
}

