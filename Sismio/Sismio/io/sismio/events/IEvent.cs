using Sismio.io.sismio.sensor;

namespace Sismio.io.sismio.events
{
    public interface IEvent
    {
        string Tag { get; }
        Priority Priority { get; }
        string Message { get; }
        long Timestamp { get; }
        Station Station { get; }
    }
}