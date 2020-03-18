using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.Subotai.Dal.Gatekeeper
{
    public class DalBase<TModel> : IDal<TModel> where TModel : class
    {
        protected subotaiEntities DBAccess;
        
        public DalBase(subotaiEntities DbContext)
        {
            DBAccess = DbContext;
        }

        public List<TModel> Select(Expression<Func<string, List<TModel>>> @where)
        {
            //return DBAccess.Set<TModel>().Where(where);
            return null;
        }
    }
}