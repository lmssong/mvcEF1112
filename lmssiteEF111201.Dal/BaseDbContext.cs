using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace lmssiteEF111201.Dal
{
    public class BaseDbContext:DbContext
    {
        public BaseDbContext()
            :base("name=lmssiteEFEntities")
        {

        }

    }
}
