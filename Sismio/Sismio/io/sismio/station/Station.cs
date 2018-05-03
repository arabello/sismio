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
        private string name;
        private string location;
        private IPAddress ipAddress;
        private int port;
        private string publicKeyFingerprint;

        public Station(string name, string location, IPAddress ipAddress,
            int port, string publicKeyFingerprint)
        {
            this.name = name;
            this.location = location;
            this.ipAddress = ipAddress;
            this.port = port;
            this.publicKeyFingerprint = publicKeyFingerprint;
        }
    }
}
