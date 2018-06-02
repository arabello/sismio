using System;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.sorgente
{
    // TODO
    public class SensoreSorgenteAdapter: Sorgente
    {
        private ISensore _sensore;
        public override IStazione Stazione { get; } = null;
    
        public SensoreSorgenteAdapter(ISensore sensore)
        {
            _sensore = sensore;

            // Aggiungo l'adapter ai ricevitori del sensore
            sensore.RicevitoriDatiSensore += OnRisultatiGrezziDisponibili;
        }


        public override void CicloPrincipale()
        {
            // Passo il segnale al sensore sottostante
            _sensore.CicloPrincipale();
        }

        public void OnRisultatiGrezziDisponibili(int[] dati)
        {
            // Notifico i dati del sensore alla sorgente
            NotificaDatiDisponibili(dati);
        }

        public override void Ferma()
        {
            // Passo il segnale al sensore sottostante
            _sensore.Ferma();
        }
    }
}