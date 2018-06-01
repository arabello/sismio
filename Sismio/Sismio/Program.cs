using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
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
            IGestioneUtentiController gestione = new GestioneUtentiController("prova.db");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
