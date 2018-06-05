using System;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Sismio.io.sismio.analisi;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.log;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.sorgente;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.trasmissione;
using Sismio.io.sismio.utente;

namespace Sismio
{
    static class Program
    {
        private const string PERCORSO_DATABASE = @"C:\sismio_database.db";

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inizializzo il sensore
            ISensore sensore = new MockSensore();
            //ISensore sensore = new SensoreSeriale("COM10", 74880);
            sensore.RicevitoriDatiSensore += dati => Console.WriteLine(String.Join(",", dati));

            // Creo il thread del sensore e lo avvio
            Thread threadSensore = new Thread(() => sensore.CicloPrincipale());
            threadSensore.Start();



            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("127.0.0.1"),
                Porta = 8001,
                ImprontaChiavePubblica = "E2C9153221FE658AFDCEBE095EE5D2392AF8C4AE"
            };

            // Inizializzo il gestore delle stazioni

            GestioneStazioniController stazioni = new GestioneStazioniController(PERCORSO_DATABASE);
            stazioni.Registra(stazione);

            // Inizializzo il gestore utenti

            IGestioneUtentiController gestioneUtentiController = new GestioneUtentiController(PERCORSO_DATABASE);

            IStoricoController storicoController = new 

            CreatoreConnessioni creatore = new CreatoreConnessioni(stazioni);
            SorgenteFactory factory = new SorgenteFactory(creatore);
            //ISorgente sorgenteRemota = factory.NuovaSorgenteRemota(stazione, "tizio", "password");
            ISorgente sorgenteRemota = factory.NuovaSorgenteLocale(sensore);

            Thread threadSorgente = new Thread(() => sorgenteRemota.CicloPrincipale());
            threadSorgente.Start();

            IAnalisi magnitudo = new AnalisiMagnitudine();
            sorgenteRemota.AggiungiAnalisi(magnitudo);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(new MainForm()));
        }
    }
}
