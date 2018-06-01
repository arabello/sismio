using System.Collections.Generic;

namespace Sismio.io.sismio.utente
{
    public interface IGestioneUtentiController
    {
        IList<IUtente> ListaTutti();
        void Registra(IUtente utente);
        void Elimina(IUtente utente);
        IUtente ValidaCredenziali(string username, string pass);
    }
}