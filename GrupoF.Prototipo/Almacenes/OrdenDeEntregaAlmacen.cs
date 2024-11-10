using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class OrdenDeEntregaAlmacen
    {

        private static List<OrdenDeEntregaEnt> ordenesdeentrega = new List<OrdenDeEntregaEnt>();

        public static IReadOnlyCollection<OrdenDeEntregaEnt> OrdenesDeEntrega => ordenesdeentrega.AsReadOnly();

        public static void Grabar(OrdenDeEntregaEnt ordenDeEntrega)
        {
            ordenesdeentrega.Add(ordenDeEntrega);

            var datos = JsonSerializer.Serialize(ordenesdeentrega);
            File.WriteAllText(@"OrdenesDeEntrega.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("OrdenesDeEntrega.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenesDeEntrega.json");
            ordenesdeentrega = JsonSerializer.Deserialize<List<OrdenDeEntregaEnt>>(datos)!;
        }
    }
}
