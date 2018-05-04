using io.sismio.sensor;

namespace io.sismio.events
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