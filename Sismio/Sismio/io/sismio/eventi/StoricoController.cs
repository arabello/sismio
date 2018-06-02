using System;
using System.Collections.Generic;
using Sismio.io.sismio.database;

namespace Sismio.io.sismio.eventi
{
    public class StoricoController : DBController, IStoricoController
    {
        public StoricoController(string percorsoDatabase) : base(percorsoDatabase)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public void RegistraEvento(IEventoSismico evento)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IList<IEventoSismico> ListaEventi()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IList<IEventoSismico> ListaEventi(IList<IFiltroEvento> filters)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

      
    }
}