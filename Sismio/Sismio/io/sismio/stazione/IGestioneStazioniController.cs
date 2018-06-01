using System.Collections.Generic;

namespace Sismio.io.sismio.stazione
{
    public interface IGestioneStazioniController
    {
        void RegistraStazione(IStazione stazione);
        void EliminaStazione(IStazione stazione);
        IList<IStazione> ListaTutti();
        IList<IStazione> Cerca(string query);
    }
}
