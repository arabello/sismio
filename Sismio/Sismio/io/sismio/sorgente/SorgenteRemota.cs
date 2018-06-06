using System;
using System.IO;
using Sismio.io.sismio.stazione;
using System.Net.Security;
using Sismio.io.sismio.eventi;

namespace Sismio.io.sismio.sorgente
{
    // TODO
    public class SorgenteRemota: Sorgente
    {
        public override IStazione Stazione { get; }
        private SslStream _connessione;

        private bool _dovrebbeFermarsi = false;

        public SorgenteRemota(SslStream connessione, IStazione stazione, GestoreEventi gestoreEventi)
        {
            _connessione = connessione;
            this._gestoreEventi = gestoreEventi;
            Stazione = stazione;
        }

        public override void CicloPrincipale()
        {
            // Leggo i valori del sensore
            BinaryReader reader = new BinaryReader(_connessione);

            // Creo il buffer che conterrà i valori
            int[] buffer = new int[DimensioneBuffer];
            int index = 0;

            while (!_dovrebbeFermarsi)
            {
                int corrente = reader.ReadInt32();

                // Inserisco il valore corrente nel buffer
                buffer[index] = corrente;
                index++;

                // Quando il buffer è pieno, inoltro i valori
                if (index >= DimensioneBuffer)
                {
                    NotificaDatiDisponibili(buffer);
                    index = 0;
                }
            }
        }

        public override void Ferma()
        {
            _dovrebbeFermarsi = true;
        }
    }
}