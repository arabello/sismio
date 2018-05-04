using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sismio.io.sismio.sensor
{
    public interface IStationRepository
    {
        void RegisterStation(Station station);
        void DeleteStation(Station station);
        IList<Station> GetStations();
        IList<Station> Find(string query);
    }
}
