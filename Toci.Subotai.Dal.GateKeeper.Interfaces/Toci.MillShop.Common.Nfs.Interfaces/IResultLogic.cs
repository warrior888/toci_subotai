using System.Collections.Generic;

namespace Toci.MillShop.Common.Nfs.Interfaces
{
    public interface IResultLogic<TResult>
    {
        IResultEntity<TResult> HandleResult(TResult result, List<string> Messages);
    }
}