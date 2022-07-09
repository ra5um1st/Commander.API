using System.Collections.Generic;

namespace Commander.Models.Repository
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public T Update(T item);
        public void Delete(int id);
    }
}
