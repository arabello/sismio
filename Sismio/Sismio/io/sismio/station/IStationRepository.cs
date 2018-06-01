using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sismio.io.sismio.sensore
{
    public interface IStationRepository
    {
        void RegisterStation(IStation station);
        void DeleteStation(IStation station);
        IList<IStation> GetStations();
        IList<IStation> Find(string query);
    }
}
