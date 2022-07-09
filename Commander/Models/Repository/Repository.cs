using System.Collections.Generic;

namespace Commander.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T Update(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}
