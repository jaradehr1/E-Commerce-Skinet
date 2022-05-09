using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        // Where Criteria
        Expression<Func<T, bool>> Criteria {get; }

        // Navigation Property
        List<Expression<Func<T, object>>> Includes {get; }

        // Ordering Properties
        Expression<Func<T, object>> OrderBy {get; }
        Expression<Func<T, object>> OrderByDescending {get; }

        // Pagination Properties
        int Take {get; }
        int Skip {get; }
        bool IsPagingEnabled {get;}
    }
}