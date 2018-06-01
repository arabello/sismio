using System.Collections.Generic;

namespace Sismio.io.sismio.eventi
{
    public interface IStoricoController
    {
        void RegistraEvento(IEventoSismico evento);
        IList<IEventoSismico> ListaEventi();
        IList<IEventoSismico> ListaEventi(IList<IFiltroEvento> filters);
    }
}