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
            //TODO: Implement
            throw new NotImplementedException();
        }


        public override void CicloPrincipale()
        {
            throw new NotImplementedException();
        }

        public void OnRisultatiGrezziDisponibili(int[] dati)
        {
            throw new NotImplementedException();
        }

        public override void Ferma()
        {
            throw new NotImplementedException();
        }
    }
}