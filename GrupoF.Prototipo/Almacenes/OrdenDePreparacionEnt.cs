
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace GrupoF.Prototipo.Almacenes
{
    // Una entidad debe seguir 3 reglas:
    // 1) Es una clase de datos. Sólo sirve para contener y definir todos los datos que utilizará una entidad.
    // 2) Si implemento métodos, únicamente deberán trabajar con los datos/parámetros que se encuentran dentro de esta entidad (sin referencias externas)
    // 3) Si tengo datos que pueden ser calculados, deberé crear un método para obtenerlos.
    public class OrdenDePreparacionEnt
    {
        public int ID_OP { get; set; }
        public EstadoOPEnum Estado_OP { get; set; }
        public bool Prioridad_OP { get; set; }
        public int ID_Cliente { get; set; }
        public DateTime FechaEmision_OP { get; set; }
        public DateTime FechaEntrega_OP { get; set; }
        public int ID_Deposito { get; set; }
        public int DNI_Transportista { get; set; }

        // Esta lista va a representar cada uno de los productos dentro de la orden. Será una clase auxiliar
        public List<Mercaderia_OP> Mercaderias_OP { get; set; } = new();



        //public int? ID_OE { get; set; }
        //public int? ID_OS { get; set; }
        //public int? ID_Remito { get; set; }


    }

}
