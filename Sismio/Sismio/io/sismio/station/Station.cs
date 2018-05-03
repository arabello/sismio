using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.sensor
{
    public class Station
    {
        private string Name { get; }
        private string Location { get; }
        private IPAddress IpAddress { get; }
        private int Port { get; }
        private string PublicKeyFingerprint { get; }

        public Station(string name, string location, IPAddress ipAddress,
            int port, string publicKeyFingerprint)
        {
            Name = name;
            Location = location;
            IpAddress = ipAddress;
            Port = port;
            PublicKeyFingerprint = publicKeyFingerprint;
        }
    }
}
