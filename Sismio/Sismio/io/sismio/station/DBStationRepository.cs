using System.Collections.Generic;
using io.sismio.database;

namespace io.sismio.sensor
{
    public class DBStationRepository : DBRepository, IStationRepository
    {

        public DBStationRepository(string databasePath) : base(databasePath)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void DeleteStation(Station station)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public IList<Station> Find(string query)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public IList<Station> GetStations()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void RegisterStation(Station station)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}