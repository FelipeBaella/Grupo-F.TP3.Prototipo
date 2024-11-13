using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoF.Prototipo.Almacenes;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal class CrearOrdnesDePreparacion_model
    {
        //TODO: cuando validen o le den las cantidades maximas de cada producto a la pantalla para que valide
        //hay que restarle a esas cantidades lo que haya en OP en estado Emitida o Seleccionada

        public List<DepositoEnt> ObtenerDepositos()
        {
            var lista = DepositoAlmacen.Depositos.ToList();

            return lista;
        }

        public List<DepositoMercaderiaEnt> ObtenerDepositosMercaderias()
        {
            var lista = DepositoMercaderiaAlmacen.DepositosMercaderias.ToList();

            return lista;
        }

        public List<MercaderiaEnt> ObtenerMercaderias()
        {
            var lista = MercaderiaAlmacen.Mercaderias.ToList();

            return lista;
        }

        public new Dictionary<int, ( int, int, int, int)> ObtenerOPs()
        {
            var OPs = OrdenDePreparacionAlmacen.OrdenesDePreparacion
                .Where(x => x.Estado_OP == EstadoOPEnum.Emitida || x.Estado_OP == EstadoOPEnum.Seleccionada)
                .Select(x => new { x.ID_Cliente, x.ID_Deposito, x.Mercaderias_OP }) 
                .ToList();

            var lista = new Dictionary<int,(int, int, int, int)>();

            var i = 1;

            // Recorremos cada orden de preparación
            foreach (var op in OPs)
            {
                // Recorremos cada mercadería en Mercaderias_OP y la agregamos a la lista
                foreach (var mercaderia in op.Mercaderias_OP)
                {               
                    lista.Add( i, (op.ID_Cliente, op.ID_Deposito, mercaderia.ID_Mercaderia, mercaderia.Cantidad_Mercaderia));

                    i++;
                }
            }

            return lista;
        }


        public static string CrearOrdenesDePreparacion(bool Prioridad_OP, int ID_Cliente, DateTime FechaEntrega_OP, int ID_Deposito, int DNI_Transportista, Dictionary<int,int> Mercaderias_OP)
        { 
            var Estado_OP = EstadoOPEnum.Emitida;        
            var FechaEmision_OP = DateTime.Now.Date;

            if (DNI_Transportista < 0)
            {
                return "El DNI ingresado debe ser un número positivo.";
            }
            if (DNI_Transportista < 10_000_000 || DNI_Transportista > 99_999_999)
            {
                return "El DNI ingresado debe tener 8 dígitos.";
            }

            if (FechaEmision_OP < DateTime.Now.Date)
            {
                return "La fecha de emision no puede ser menor al dia de hoy.";
            }

            var ordenDePreparacion = new OrdenDePreparacionEnt();

            ordenDePreparacion.Prioridad_OP = Prioridad_OP;
            ordenDePreparacion.ID_Cliente = ID_Cliente;
            ordenDePreparacion.FechaEntrega_OP = FechaEntrega_OP;
            ordenDePreparacion.ID_Deposito = ID_Deposito;
            ordenDePreparacion.DNI_Transportista = DNI_Transportista;

            var marcaderias_op = new List<Mercaderia_OP>();

            foreach (var opItem in Mercaderias_OP) 
            {
                var item = new Mercaderia_OP();

                item.ID_Mercaderia = opItem.Key;
                item.Cantidad_Mercaderia = opItem.Value;

                marcaderias_op.Add(item);
            }

            ordenDePreparacion.Mercaderias_OP = marcaderias_op;

            var OP = OrdenDePreparacionAlmacen.OrdenesDePreparacion.ToList();

            if (OP.Count > 0)
            {
                ordenDePreparacion.ID_OP = OP.Last().ID_OP + 1;
            }
            else
            {
                ordenDePreparacion.ID_OP = 1;
            }

            OrdenDePreparacionAlmacen.Nueva(ordenDePreparacion);

            Program.Grabar();

            return ordenDePreparacion.ID_OP.ToString();
        }
    }
}
