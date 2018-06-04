using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sismio.io.sismio.trasmissione;

namespace SismioServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Avvio il server della stazione
            ServerStazione server = new ServerStazione(SismioServer.CertificatoRisorsa.certificato, "passwordsismio");
            server.Avvia();
        }
    }
}
