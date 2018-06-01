using System;

namespace Sismio.io.sismio.eventi
{
    public delegate void OnEventoSismico(IEventoSismico eventoSismico);

    public class GestoreEventi
    {
        public event OnEventoSismico RicevitoriEventoSismico;

        private readonly IStoricoController _storicoController;

        public GestoreEventi(IStoricoController storicoController)
        {
            _storicoController = storicoController;
        }

        public void NotificaEvento(IEventoSismico evnt)
        {
            // Send the event to every receiver, while making sure they are not null
            RicevitoriEventoSismico?.Invoke(evnt);

            // Save the event using the EventoSismico Repository
            _storicoController.RegistraEvento(evnt);
        }
    }
}