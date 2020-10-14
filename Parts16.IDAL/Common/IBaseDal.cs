using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Parts16.Models.Common;

namespace Parts16.IDal.Common
{
    public interface IBaseDal<T> : IDisposable where T:BaseEntity, new()
    {
        Task<int> AddAsync(T modal);

        Task<int> EditAsync(T modal);

        Task<int> DeleteAsync(T modal);

        IQueryable<T> Query();

        IQueryable<T> Query(Expression<Func<T, bool>> whereExpression);

        Task<T> QueryAsync(Guid id);

        Task<bool> IsExistsAsync(Expression<Func<T, bool>> whereExpression);

        Task<int> GetCountAsync(Expression<Func<T, bool>> whereExpression);

        IQueryable<T> QueryByPage(int pageSize, int pageIndex, Expression<Func<T, bool>> whereExpression, bool isAsc);
    }
}