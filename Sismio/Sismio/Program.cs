using System;
using System.Windows.Forms;
using Sismio.io.sismio.log;
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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Amministratore pippo = new Amministratore("Alberto", "Bagnacani", "albertobagnacani@gmail.com", "Pippo", "24i1h4i1giu12g2i1is", "ooieowieowi9239", true);
            Logger.Scrivi(pippo, "aggiunto nuovo utente: Pluto");
            Logger.Scrivi(pippo, "abilitato login remoto a: Pluto");
        }
    }
}
