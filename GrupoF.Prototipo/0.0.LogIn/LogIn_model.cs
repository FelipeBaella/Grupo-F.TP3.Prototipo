using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void UsuarioSeleccionado(string usuario)
        {
            var id_usuario = ObtenerUsuarios().Where(u => u.LogIn_Usuario.ToUpper() == usuario.ToUpper()).Select(u => u.ID_Usuario).SingleOrDefault();

            UsuarioAlmacen.GrabarUsuario(id_usuario);
        }

    }
}
