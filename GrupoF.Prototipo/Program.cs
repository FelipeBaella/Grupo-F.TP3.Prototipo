using GrupoF.Prototipo._0._0.LogIn_form;
using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Aquí debería ejecutar la carga de datos desde los almacenes. Debería leer cada archivo, repitiendo 
            // la misma sentencia para cada almacen del sistema.
            OrdenDePreparacionAlmacen.Leer();

            Application.Run(new LogIn_form());

            //ClienteAlmacen.Grabar();
            //DepositoAlmacen.Grabar();
            //DepositoMercaderiaAlmacen.Grabar();
            //MercaderiaAlmacen.Grabar();
            //OrdenDeEntregaAlmacen.Grabar();
            //OrdenDePreparacionAlmacen.Grabar();
            //OrdenDeSeleccionAlmacen.Grabar();
            //RemitoAlmacen.Grabar();
            //UsuarioAlmacen.Grabar();

        }
    }
}