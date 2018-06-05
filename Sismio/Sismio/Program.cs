using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Sismio.io.sismio.analisi;
using Sismio.io.sismio.log;
using Sismio.io.sismio.sorgente;
using Sismio.io.sismio.utente;

namespace Sismio
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(new MainForm()));
        }
    }
}
