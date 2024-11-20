using GrupoF.Prototipo.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._1._2_Detalles_Op
{
    internal class DetalleOp_model
    {
        public Dictionary<int, (string, string, string, string)> CargarItemsOp(int id)
        {
            var Op = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == id).FirstOrDefault();

            var IdOp = Op.ID_OP.ToString();

            var deposito = DepositoAlmacen.Depositos.Where(x => x.ID_Deposito == Op.ID_Deposito).FirstOrDefault().Descripcion_Deposito;

            var items = Op.Mercaderias_OP;

            var mercaderias = MercaderiaAlmacen.Mercaderias.ToList();

            var lista = new Dictionary<int, (string, string, string, string)>();
            
            int i = 0;

            foreach (var item in items)
            {
                var mercaderia = mercaderias.Where(x => x.ID_Mercaderia == item.ID_Mercaderia).SingleOrDefault().Descripcion_Mercaderia;

                var cantidad = item.Cantidad_Mercaderia.ToString();

                lista.Add(i, (IdOp, deposito, mercaderia, cantidad));

                i++;
            }

            return lista;
        }
    }
}
