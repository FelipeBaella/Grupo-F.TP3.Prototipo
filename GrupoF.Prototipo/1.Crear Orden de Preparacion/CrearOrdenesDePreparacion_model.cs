using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal interface ProcesarOrdenesDePreparacion_model
    {

    }

    internal class CrearOrdnesDePreparacionModel
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>
        {
            new Cliente {Id_Cliente = 0, Dni = 0, NombreApellido = "---"},

            new Cliente {Id_Cliente = 1, Dni = 42119134, NombreApellido = "Quimey Lopez SR"},

            new Cliente {Id_Cliente = 2, Dni = 42102237, NombreApellido = "Agustin Tallone SR"}
        };

        public List<Transportista> Transportistas { get; set; } = new List<Transportista>
        {
            new Transportista {Dni_Transportista = 42119134, NombreApellido_Transportista = "Quimey Lopez"},

            new Transportista {Dni_Transportista = 42102237, NombreApellido_Transportista = "Agustin Tallone"}
        };


        public List<Mercaderia> Mercaderias { get; set; } = new List<Mercaderia>
        {
            new Mercaderia {Id_Mercaderia = 0, Descripcion_Mercaderia = "---"},

            new Mercaderia {Id_Mercaderia = 1, Descripcion_Mercaderia = "Manzanas"},

            new Mercaderia {Id_Mercaderia = 2, Descripcion_Mercaderia = "Peras"}
        };

        public List<Deposito> Depositos { get; set; } = new List<Deposito>
        {
            new Deposito {Id_Deposito = 0, Nombre_Deposito = "---"},

            new Deposito {Id_Deposito = 1, Nombre_Deposito = "Rosario"},

            new Deposito {Id_Deposito = 2, Nombre_Deposito = "Mendoza"}
        };


    }
}
