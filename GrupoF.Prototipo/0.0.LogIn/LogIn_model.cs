﻿using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._0._0.LogIn
{
    internal class LogIn_model
    {
        public List<Usuarios> Usuarios { get; set; } = new List<Usuarios>
        {
            new Usuarios {Id_Cliente = 0, Id_Usuario = 0, LogIn_usuario = "1", Contrasena_usuario = "1"},

            new Usuarios {Id_Cliente = 1, Id_Usuario = 1, LogIn_usuario = "Usuario1", Contrasena_usuario = "123"},

        };
    }
}
