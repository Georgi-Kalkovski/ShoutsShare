using System.Collections.Generic;

namespace ShoutsShare.Services.Data
{
    public interface IContentsService
    {
        IEnumerable<T> GetAll<T>();
    }
}
