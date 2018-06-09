using System.Threading;
using System.Threading.Tasks;

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

        /// <summary>
        /// Notifica l'evento in maniera sincrona
        /// </summary>
        /// <param name="evnt"></param>
        public void NotificaEvento(EventoSismico evnt)
        {
            // Send the event to every receiver, while making sure they are not null
            RicevitoriEventoSismico?.Invoke(evnt);

            // Save the event using the EventoSismico Repository
            _storicoController.RegistraEvento(evnt);
        }

        /// <summary>
        /// Notifica l'evento in maniera asincrona
        /// </summary>
        /// <param name="evnt"></param>
        public void NotificaEventoAsync(EventoSismico evnt)
        {
            // Notifico l'evento e lo registro in maniera asincrona
            Task.Run(() => NotificaEvento(evnt));
        }
    }
}