using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.eventi
{
    public interface IEventoSismico
    {
        string Tag { get; }
        Priorita Priorita { get; }
        string Messaggio { get; }
        long Timestamp { get; }
        IStazione Stazione { get; }
    }
}