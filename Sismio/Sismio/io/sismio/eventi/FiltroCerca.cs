using System;

namespace Sismio.io.sismio.eventi
{
    public class FiltroCerca: IFiltroEvento
    {
        private string _query;

        public FiltroCerca(string query)
        {
            this._query = query;
        }

        public bool Filtra(IEventoSismico eventoSismico)
        {
            return eventoSismico.Tag.IndexOf(_query, StringComparison.OrdinalIgnoreCase) >= 0
                   || eventoSismico.Messaggio.IndexOf(_query, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}