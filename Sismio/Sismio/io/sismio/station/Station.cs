using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.sensor
{
    public class Station: IStation
    {
        public string Name { get; }
        public string Location { get; }
        public IPAddress IpAddress { get; }
        public int Port { get; }
        public string PublicKeyFingerprint { get; }
        public long Id { get; set; }

        public Station(string name, string location, IPAddress ipAddress, int port, string publicKeyFingerprint)
        {
            Name = name;
            Location = location;
            IpAddress = ipAddress;
            Port = port;
            PublicKeyFingerprint = publicKeyFingerprint;
        }
    }
}
