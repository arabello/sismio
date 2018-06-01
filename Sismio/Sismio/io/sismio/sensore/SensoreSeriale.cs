namespace Sismio.io.sismio.sensore
{
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
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Ferma()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}
