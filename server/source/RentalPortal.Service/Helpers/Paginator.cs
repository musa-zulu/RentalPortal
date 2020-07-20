using Microsoft.EntityFrameworkCore;
using RentalPortal.Service.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RentalPortal.Service.Helpers
{
    public class Paginator<T> : IPaginator<T> where T : DbSet<T>
    { 
        public IQueryable<T> BuildPageResult<TOrder>(
            IQueryable<T> dbSet,
            int page,
            int perPage,
            Expression<Func<T, TOrder>> orderByExp)
        {
            var entsToSkip = (page - 1) * perPage;
            return dbSet
                .OrderBy(orderByExp)
                .Skip(entsToSkip)
                .Take(perPage);
        }

        public IQueryable<T> BuildPageResult<TOrder>(
            IQueryable<T> dbSet, int page, int perPage,
            Expression<Func<T, bool>> whereExp,
            Expression<Func<T, TOrder>> orderExp)
        {
            var entsToSkip = (page - 1) * perPage;

            return dbSet
                .OrderBy(orderExp)
                .Where(whereExp)
                .Skip(entsToSkip)
                .Take(perPage);
        }
    }
}