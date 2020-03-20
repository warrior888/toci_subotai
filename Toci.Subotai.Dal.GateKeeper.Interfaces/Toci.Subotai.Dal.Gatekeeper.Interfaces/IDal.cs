using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Toci.Subotai.Dal.Gatekeeper.Interfaces
{
    public interface IDal<TModel>  //templates
    {
        List<TModel> Select(Expression<Func<string, List<TModel>>> where);

        TModel Insert(TModel model);
    }
}