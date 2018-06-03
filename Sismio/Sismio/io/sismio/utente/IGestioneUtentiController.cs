using System;
using System.Collections.Generic;

namespace Sismio.io.sismio.utente
{
    public interface IGestioneUtentiController : IDisposable
    {
        IList<IUtente> ListaTutti();
        bool Registra(Utente utente);
        bool Elimina(Utente utente);
        IUtente ValidaCredenziali(string username, string pass);
        IList<IUtente> Cerca(string query);
    }
}