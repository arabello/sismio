namespace Sismio.io.sismio.eventi
{
    public class FiltroIntervalloDiTempo: IFiltroEvento
    {
        private long Inizio;
        private long Fine;

        public FiltroIntervalloDiTempo(long inizio, long fine)
        {
            Inizio = inizio;
            Fine = fine;
        }

        public bool Filtra(IEventoSismico eventoSismico)
        {
            return eventoSismico.Timestamp >= Inizio && eventoSismico.Timestamp <= Fine;
        }
    }
}