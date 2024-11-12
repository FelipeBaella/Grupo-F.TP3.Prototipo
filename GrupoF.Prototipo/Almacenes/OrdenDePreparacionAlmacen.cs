using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class OrdenDePreparacionAlmacen
    {
        
        // Voy a disponer de dos listas:
        
        // 1) Una lista privada que exclusivamente se puede modificar por la propia clase "Almacen".
        private static List<OrdenDePreparacionEnt> ordenesdepreparacion = new List<OrdenDePreparacionEnt>();

        // 2) Una lista pública de los objetos que almacenaré para que el resto del sistema la pueda consultar.
        public static IReadOnlyCollection<OrdenDePreparacionEnt> OrdenesDePreparacion => ordenesdepreparacion.AsReadOnly();

        public static void Nueva(OrdenDePreparacionEnt ordendepreparacion)
        {
            ordenesdepreparacion.Add(ordendepreparacion);
        }

        // También voy a disponer de dos métodos:

        // 1) Utilizaré un método para grabar los datos dentro de un archivo.
        public static void Grabar()
        {
            // Transformo los datos de la lista a formato JSON.
            var datos = JsonSerializer.Serialize(ordenesdepreparacion);

            // Los grabo en un archivo
            File.WriteAllText(@"Datos\OrdenesDePreparacion.json", datos);
        }

        // 2) Utilizaré un método para leer los datos de un archivo.
        public static void Leer()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"OrdenesDePreparacion.json");

            // Valido si el archivo no existe. Si ese es el caso, no hago nada.
            if (!File.Exists(@"Datos\OrdenesDePreparacion.json"))
            {
                return;
            }

            // Leo todo los datos del archivo y se los asigno a una variable
            var datos = File.ReadAllText(@"Datos\OrdenesDePreparacion.json");

            // Transformo los datos del archivo (string) adecuandolos al formato del objeto.
            ordenesdepreparacion = JsonSerializer.Deserialize<List<OrdenDePreparacionEnt>>(datos)!;
        }
    }
}
