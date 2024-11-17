using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._0._0.LogIn
{
    internal class LogIn_model
    {
        public List<UsuarioEnt> ObtenerUsuarios()
        {
            var lista = UsuarioAlmacen.Usuarios.ToList();

            return lista;
        }

    }
}
