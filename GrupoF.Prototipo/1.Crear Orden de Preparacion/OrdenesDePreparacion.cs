﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class OrdenesDePreparacion
    {
        public int Id_OrdenDePreparacion { get; set; }
        public int Id_EstadoOP { get; set; }
        public bool Prioridad_OrdenDePreparacion { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Emision_OrdenDePreparacion { get; set; }
        public int Id_Deposito { get; set; }
        public int Dni_transportista { get; set; }
        public int? Id_OrdenDeEntrega { get; set; }
        public int? Id_OrdenDeSeleccion { get; set; }
        public int? Id_Remito { get; set; }
    }
}
