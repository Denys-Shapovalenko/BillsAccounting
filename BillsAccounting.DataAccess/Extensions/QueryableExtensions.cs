using System.Linq;
using BillsAccounting.Abstract.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BillsAccounting.DataAccess.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Specify<T>(this IQueryable<T> source, ISpecification<T> spec) where T : class
        {
            var queryableWithIncludes = spec.Includes.Aggregate(source, (current, include) => current.Include(include));
            var secondary = spec.IncludeStrings.Aggregate(queryableWithIncludes, (current, include) => current.Include(include));

            return secondary.Where(spec.Criteria);
        }
    }
}