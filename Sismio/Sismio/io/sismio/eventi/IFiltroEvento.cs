﻿using Sismio.io.sismio.eventi;

namespace Sismio.io.sismio.eventi
{
    public interface IFiltroEvento
    {
        bool Filtra(IEventoSismico eventoSismico);
    }
}