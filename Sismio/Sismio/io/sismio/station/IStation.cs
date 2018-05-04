using System.Net;

namespace Sismio.io.sismio.sensor
{
    public interface IStation
    {
        string Name { get; }
        string Location { get; }
        IPAddress IpAddress { get; }
        int Port { get; }
        string PublicKeyFingerprint { get; }
    }
}