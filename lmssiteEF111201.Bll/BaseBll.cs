using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lmssiteEF111201.Dal;
using System.Linq.Expressions;

namespace lmssiteEF111201.Bll
{
    public class BaseBll<TEntity> where TEntity:class
    {
        BaseDal<TEntity> dal = new BaseDal<TEntity>();

        public List<TEntity> Query(Expression<Func<TEntity, bool>> where) {
            return dal.Query(where);
        }
    }
}
