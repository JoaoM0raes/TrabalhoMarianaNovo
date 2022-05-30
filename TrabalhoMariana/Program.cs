
using GestãoTestes.Infra.Compartilhado;
using GestãoTestes.Infra.Serializadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMariana
{
    internal static class Program
    {

        static ISerializador serializador = new SerializadorJson();

        static DataContext contexto = new DataContext(serializador);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            
            Application.Run(new TelaFormPrincipal(contexto));
            contexto.GravarDados();
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            contexto.GravarDados();
        }
    }
}
