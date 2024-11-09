using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal class ClienteEnt
    {
        public int ID_Cliente { get; set; }
        public int DNI_Cliente { get; set; }
        public string NombreApellido_Cliente { get; set; }
        public long CUIT_Cliente { get; set; }
        public string Domicilio_Cliente { get; set; }
        public string CondIVA_Cliente { get; set; }
    }
}
