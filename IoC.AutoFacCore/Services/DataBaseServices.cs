using System;
using System.Collections.Generic;
using System.Linq;

namespace IoC.AutoFacCore.Services
{
    public class DataBaseServices : IDataBaseServices
    {
        private List<string> _database;
        
        public DataBaseServices()
        {
            _database = new List<string>()
            {
                new string(Guid.NewGuid().ToString("N")),
                new string(DateTime.Now.ToLongTimeString())
            };
        }

        public IEnumerable<string> GetAll()
        {
            return _database.ToList();
        }

        public string Find(int id)
        {
            return _database[id];
        }
    }
}