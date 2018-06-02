using System;
using System.Collections.Generic;

namespace Sismio.io.sismio.eventi
{
    public interface IStoricoController: IDisposable
    {
        bool RegistraEvento(EventoSismico evento);
        IList<IEventoSismico> ListaEventi();
        IList<IEventoSismico> ListaEventi(IList<IFiltroEvento> filtri);
    }
}