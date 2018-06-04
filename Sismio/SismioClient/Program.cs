using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sismio.io.sismio.analisi;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.sorgente;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.trasmissione;

namespace SismioClient
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("127.0.0.1"),
                Porta = 8001,
                ImprontaChiavePubblica = "E2C9153221FE658AFDCEBE095EE5D2392AF8C4AE"
            };

            if (File.Exists("test_client.db"))
            {
                File.Delete("test_client.db");
            }

            GestioneStazioniController stazioni = new GestioneStazioniController("test_client.db");
            stazioni.Registra(stazione);

            CreatoreConnessioni creatore = new CreatoreConnessioni(stazioni);
            SorgenteFactory factory = new SorgenteFactory(creatore);
            ISorgente sorgenteRemota = factory.NuovaSorgenteRemota(stazione, "tizio", "password");

            Thread threadSorgente = new Thread(() => sorgenteRemota.CicloPrincipale());
            threadSorgente.Start();

            IAnalisi analisi = new AnalisiGrezza();
            sorgenteRemota.AggiungiAnalisi(analisi);

            threadSorgente.Join();
        }
    }
}
