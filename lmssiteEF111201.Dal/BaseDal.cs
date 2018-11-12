using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace lmssiteEF111201.Dal
{
    public class BaseDal<TEntity> where TEntity : class
    {

        /// <summary>
        /// 实例化EF上下文对象
        /// </summary>
        BaseDbContext dbc = new BaseDbContext();

        IDbSet<TEntity> _dbSet;

        public BaseDal() {
            _dbSet = dbc.Set<TEntity>();
        }

        public List<TEntity> Query(Expression<Func<TEntity, bool>> where) {
            return _dbSet.Where(where).ToList();
        }
    }
}
