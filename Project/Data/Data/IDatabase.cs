using System.Collections.Generic;

namespace Data
{
    interface IDatabase
    {
        void Add<T>(T t);
        void AddList<T>(List<T> l);
        void Update<T>(T t);
        void Delete<T>(T t);
    }
}
