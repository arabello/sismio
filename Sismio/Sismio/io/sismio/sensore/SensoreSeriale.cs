namespace Sismio.io.sismio.sensore
{
    // TODO
    public class SensoreSeriale : ISensore
    {
        public string PortaSeriale { get; }
        public int BaudRate { get; }

        public event OnRisultatiGrezziDisponibili RicevitoriDatiSensore;

        public SensoreSeriale(string portaSeriale, int baudRate)
        {
            PortaSeriale = portaSeriale;
            BaudRate = baudRate;
            
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        private void ApriSeriale()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public SensoreSeriale(string fileConfigurazione)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void CicloPrincipale()
        {
            // TODO Verifica che il sensore non sia già avviato

            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Ferma()
        {
            // TODO: Verifica che non ci siano piu ricevitori prima di fermare il sensore

            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}
