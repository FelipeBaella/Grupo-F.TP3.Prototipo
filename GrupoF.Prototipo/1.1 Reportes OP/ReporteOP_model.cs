using GrupoF.Prototipo.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._1._1_Reportes_OP
{
    internal class ReporteOP_model
    {
        public List<OrdenDePreparacionEnt> CargarOps()
        {
            var lista = OrdenDePreparacionAlmacen.OrdenesDePreparacion.ToList();

            return lista;
        }

        public List<DepositoEnt> Depositos()
        {
            var lista = DepositoAlmacen.Depositos.ToList();

            return lista;
        }

        public List<ClienteEnt> Clientes()
        {
            var lista = ClienteAlmacen.Clientes.ToList();

            return lista;
        }  

        public List<EstadoOPEnum> CargarListaEstadosOp()
        {
            // Obtén todos los valores del enum y conviértelos a una lista
            var lista = Enum.GetValues(typeof(EstadoOPEnum))
                            .Cast<EstadoOPEnum>()
                            .ToList();

            return lista;
        }

    }
}
