using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace BillsAccounting.Abstract.Interfaces
{
    public interface ISpecification<T> where T:class
    {
         Expression<Func<T, bool>> Criteria { get; }
         List<Expression<Func<T, object>>> Includes { get; }
         List<string> IncludeStrings { get; }
    }
}