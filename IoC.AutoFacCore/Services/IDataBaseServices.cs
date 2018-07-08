using System.Collections.Generic;

namespace IoC.AutoFacCore.Services
{
    public interface IDataBaseServices
    {
        IEnumerable<string> GetAll();
        string Find(int id);
    }
}