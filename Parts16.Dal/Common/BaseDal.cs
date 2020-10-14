using Parts16.IDal.Common;
using Parts16.Models;
using Parts16.Models.Common;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parts16.Dal.Common
{
    public class BaseDal<T> : IBaseDal<T> where T : BaseEntity, new()
    {
        private readonly Parts16Context _db;

        public BaseDal(Parts16Context db)
        {
            _db = db;
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task<int> AddAsync(T modal)
        {
            _db.Entry<T>(modal).State = EntityState.Added;
            return await _db.SaveChangesAsync();
        }

        public async Task<int> EditAsync(T modal)
        {
            _db.Entry<T>(modal).State = EntityState.Modified;
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(T modal)
        {
            _db.Entry<T>(modal).State = EntityState.Deleted;
            return await _db.SaveChangesAsync();
        }

        public IQueryable<T> Query()
        {
            return _db.Set<T>();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> whereExpression)
        {
            return _db.Set<T>().Where(whereExpression);
        }

        public async Task<T> QueryAsync(Guid id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<bool> IsExistsAsync(Expression<Func<T, bool>> whereExpression)
        {
            return await _db.Set<T>().Where(whereExpression).AnyAsync();
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> whereExpression)
        {
            return await _db.Set<T>().Where(whereExpression).CountAsync();
        }

        public IQueryable<T> QueryByPage(int pageSize, int pageIndex, Expression<Func<T, bool>> whereExpression, bool isAsc)
        {
            if (isAsc)
            {
                return _db.Set<T>().Where(whereExpression).OrderBy(t => t.UpdateTime)
                    .Skip(pageSize * pageIndex).Take(pageSize);
            }

            return _db.Set<T>().Where(whereExpression).OrderByDescending(t => t.UpdateTime)
                .Skip(pageSize * pageIndex).Take(pageSize);
        }
    }
}
