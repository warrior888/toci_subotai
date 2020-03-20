using System.Collections.Generic;

namespace Toci.MillShop.Common.Nfs.Interfaces
{
    public interface IResultEntity<TResult>
    {
        bool IsError { get; set; }

        TResult Result { get; set; }

        List<string> ErrorApp { get; set; }

        List<string> ErrorUi { get; set; }
    }
    
}