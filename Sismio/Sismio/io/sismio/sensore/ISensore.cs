namespace Sismio.io.sismio.sensore
{
    public delegate void OnRisultatiGrezziDisponibili(int[] dati);

    public interface ISensore
    {
        event OnRisultatiGrezziDisponibili RicevitoriDatiSensore;

        void CicloPrincipale();

        void Ferma();
    }
}
