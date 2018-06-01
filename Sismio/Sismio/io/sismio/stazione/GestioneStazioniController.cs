using System.Collections.Generic;
using Sismio.io.sismio.database;

namespace Sismio.io.sismio.stazione
{
    public class GestioneStazioniController : DBController, IGestioneStazioniController
    {

        public GestioneStazioniController(string percorsoDatabase) : base(percorsoDatabase)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void EliminaStazione(IStazione stazione)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public IList<IStazione> Cerca(string query)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public IList<IStazione> ListaTutti()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void RegistraStazione(IStazione stazione)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}