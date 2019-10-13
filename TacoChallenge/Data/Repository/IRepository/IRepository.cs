using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TacoChallenge.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            String includeProperties = null);
    }
}