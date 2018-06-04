using System;
using System.IO;
using Sismio.io.sismio.stazione;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Sismio.io.sismio.user;

namespace Sismio.io.sismio.trasmissione
{
    // TODO
    public class CreatoreConnessioni
    {
        // COSE CHE HO CAMBIATO
        // Il metodo creaConnessione non è piu statico, perchè richiede GestioneStazioniController

        private readonly IGestioneStazioniController _gestioneStazioniController = null;

        public CreatoreConnessioni(IGestioneStazioniController gestioneStazioniController)
        {
            _gestioneStazioniController = gestioneStazioniController;
        }

        public SslStream CreaConnessione(IStazione stazione, string user, string password)
        {
            TcpClient tcpclnt = new TcpClient();
            Console.WriteLine("Creazione della connessione in corso...");

            tcpclnt.Connect(stazione.IndirizzoDiRete, stazione.Porta);
            SslStream sslStream = new SslStream(
                tcpclnt.GetStream(),
                false,
                new RemoteCertificateValidationCallback(ValidaCertificatoServer),
                null
            );

            // Cerca di validare il certificato, se fallisce lancia una NonFidatoEccezione
            try
            {
                sslStream.AuthenticateAsClient("Sismio");
            }
            catch (System.Security.Authentication.AuthenticationException e)
            {
                throw new NonFidatoEccezione("Il certificato della stazione remota non corrisponde ad uno autorizzato");
            }

            Console.WriteLine("Invio delle credenziali...");

            // Effettua la verifica delle credenziali
            BinaryWriter writerBinario = new BinaryWriter(sslStream);
            BinaryReader readerBinario = new BinaryReader(sslStream);

            // Invia username e password
            writerBinario.Write(user);
            writerBinario.Write(password);

            // Attendo la risposta
            string risposta = readerBinario.ReadString();

            if (risposta == "ACCEPT")  // Credenziali accettate, procedo
            {
                Console.WriteLine("Connessione accettata!");
                return sslStream;
            }else if (risposta == "INVALID")  // Credenziali non accettate, lancio eccezione
            {
                Console.WriteLine("Credenziali invalide");
                throw new CredenzialiInvalideEccezione("Le credenziali remote non sono state accettate");
            }
            else  // Risposta invalida
            {
                throw new RispostaInvalidaEccezione("Il server non ha restituito una risposta valida");
            }
        }

        private bool ValidaCertificatoServer(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
        {
            // Valido il certificato verificando che esista una stazione registrata corrispondente
            return _gestioneStazioniController.ValidaCertificato(((X509Certificate2) certificate).Thumbprint);
        }
    }
}
