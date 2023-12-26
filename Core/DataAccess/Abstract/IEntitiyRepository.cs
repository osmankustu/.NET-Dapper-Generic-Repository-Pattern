using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.GenericDataAccessRepository.Abstract
{
    public interface IEntitiyRepository<T> where T : class,IEntity,new()
    {
        List<T> getAll(Expression<Func<T, bool>> filter = null);
        T Get(int id,Expression<Func<T,bool>> filter = null );
        void add(T Entity);
        void update(T Entity);
        void delete(T Entity);
    }
}
