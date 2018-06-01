namespace Sismio.io.sismio.eventi
{
    public class FiltroTag: IFiltroEvento
    {
        private string Tag;

        public FiltroTag(string tag)
        {
            Tag = tag;
        }

        public bool Filtra(IEventoSismico eventoSismico)
        {
            return eventoSismico.Tag.Equals(Tag);
        }
    }
}