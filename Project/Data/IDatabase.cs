namespace Data
{
    interface IDatabase
    {
        void Add<T>(T t);
        void Update<T>(T t);
        void Delete<T>(T t);
    }
}
