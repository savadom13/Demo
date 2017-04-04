using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repositoryes
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Edit(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        T FindById(int entityId);
        //IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

    }
}
