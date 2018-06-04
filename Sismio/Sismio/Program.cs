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
            //IGestioneUtentiController gestione = new GestioneUtentiController("prova.db");
            //gestione.ValidaCredenziali("admin", "admin");
            //
            /**
             *  Mi server il main per la ui. Usate i test (ho commentato le 3 righe qua sotto)
             */
            //ISorgente sorgente = SorgenteFactory.NuovaSorgenteFile(@"C:\testfile.txt");
            //sorgente.AggiungiAnalisi(new AnalisiGrezza());
            //sorgente.CicloPrincipale();
            //
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Amministratore pippo = new Amministratore("Alberto", "Bagnacani", "albertobagnacani@gmail.com", "Pippo", "24i1h4i1giu12g2i1is", "ooieowieowi9239", true);
            //Logger.Scrivi(pippo, "aggiunto nuovo utente: Pluto");
            //Logger.Scrivi(pippo, "abilitato login remoto a: Pluto");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new Login());
        }
    }
}
