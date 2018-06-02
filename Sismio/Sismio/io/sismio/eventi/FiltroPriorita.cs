namespace Sismio.io.sismio.eventi
{
    public class FiltroPriorita: IFiltroEvento
    {
        private Priorita _priorita;

        public FiltroPriorita(Priorita priorita)
        {
            _priorita = priorita;
        }

        public bool Filtra(IEventoSismico eventoSismico)
        {
            return eventoSismico.Priorita == _priorita;
        }
    }
}