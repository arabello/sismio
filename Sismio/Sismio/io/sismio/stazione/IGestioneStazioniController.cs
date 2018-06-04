using System;
using System.Collections.Generic;

namespace Sismio.io.sismio.stazione
{
    // Cambiato EliminaStazione, RegistraStazione -> Elimina, Registra
    // Cambiato IStazione -> Stazione in EliminaStazione, RegistraStazione
    // Cambiato void -> bool in EliminaStazione, RegistraStazione
    // Aggiunto Valida()
    public interface IGestioneStazioniController : IDisposable
    {
        bool Registra(Stazione stazione);
        bool Elimina(Stazione stazione);
        bool ValidaCertificato(string impronta);
        IList<IStazione> ListaTutti();
        IList<IStazione> Cerca(string query);
    }
}
