using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
