using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal class UsuarioEnt
    {

        public int ID_Usuario { get; set; }
        public string LogIn_Usuario { get; set; }
        public string contrasena_Usuario { get; set; }
        public int ID_Deposito{ get; set; }
    }
}
