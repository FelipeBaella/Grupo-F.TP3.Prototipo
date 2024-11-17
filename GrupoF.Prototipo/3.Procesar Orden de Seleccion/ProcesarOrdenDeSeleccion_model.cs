
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class ProcesarOrdenDeSeleccion_model
    {
        public int ObtenerUsuarioDeposito()
        {
            var usuario = UsuarioAlmacen.UsuarioSeleccionado;

            var usuarioDeposito = UsuarioAlmacen.Usuarios.Where(x => x.ID_Usuario == usuario).FirstOrDefault().ID_Deposito;

            return usuarioDeposito;
        }


        //TODO: dar de baja el stock.
        public List<ClienteEnt> ObtenerClientes()
        {
            var lista = ClienteAlmacen.Clientes.ToList();

            return lista;
        }

        public List<DepositoMercaderiaEnt> ObtenerDepositosMercaderias()
        {
            var lista = DepositoMercaderiaAlmacen.DepositosMercaderias.ToList();

            return lista;
        }

        public List<OrdenDePreparacionEnt> ObtenerOPs()
        {
            var lista = OrdenDePreparacionAlmacen.OrdenesDePreparacion.ToList();

            return lista;
        }

        public List<OrdenDeSeleccionEnt> ObtenerOSs()
        {
            var lista = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion.ToList();

            return lista;
        }

        public List<MercaderiaEnt> ObtenerMercaderias()
        {
            var lista = MercaderiaAlmacen.Mercaderias.ToList();

            return lista;
        }

        public static string EditarEstadoOS(int id)
        {
            var ordenesDeSeleccion = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion.Where(x => x.ID_OS == id).SingleOrDefault();

            ordenesDeSeleccion.Estado_OS = EstadoOSEnum.Cumplida;

            var OrdenesDePreparacion = ordenesDeSeleccion.OrdenesPreparacion_OS;

            foreach (var orden in OrdenesDePreparacion)
            {
                var OrdenDePreparacion = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.ID_OP == orden).SingleOrDefault();

                OrdenDePreparacion.Estado_OP = EstadoOPEnum.EnPreparacion;

                var cliente = OrdenDePreparacion.ID_Cliente;
                var deposito = OrdenDePreparacion.ID_Deposito;

                var Mercaderias_OP = OrdenDePreparacion.Mercaderias_OP;

                foreach (var item in Mercaderias_OP)
                {
                    var cantidadRestante = item.Cantidad_Mercaderia;

                    while (cantidadRestante > 0)
                    {
                        // Buscar un depósito con suficiente mercadería o el próximo disponible
                        var depositoMercaderia = DepositoMercaderiaAlmacen.DepositosMercaderias
                            .Where(x => x.ID_Mercaderia == item.ID_Mercaderia && x.ID_Cliente == cliente && x.ID_Deposito == deposito && x.Cantidad_DepositoMercaderia > 0)
                            .FirstOrDefault();

                        // Reducir la cantidad del depósito según la cantidad disponible
                        if (depositoMercaderia.Cantidad_DepositoMercaderia >= cantidadRestante)
                        {
                            depositoMercaderia.Cantidad_DepositoMercaderia -= cantidadRestante;
                            cantidadRestante = 0;
                        }
                        else
                        {
                            // Reducir todo el stock disponible en este depósito y ajustar la cantidad restante
                            cantidadRestante -= depositoMercaderia.Cantidad_DepositoMercaderia;
                            depositoMercaderia.Cantidad_DepositoMercaderia = 0;
                        }
                    }
                }
            }

            Program.Grabar();

            return null;
        }

    }
}
