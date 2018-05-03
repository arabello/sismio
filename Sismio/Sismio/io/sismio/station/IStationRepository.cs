using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.sensor
{
    interface IStationRepository
    {
        void RegisterStation(Station station);
        void DeleteStation(Station station);
        IList<Station> GetStations();
        IList<Station> Find(string query);
    }
}
