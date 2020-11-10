namespace ShoutsShare.Services.Data.Services
{
    using System.Collections.Generic;

    public interface IContentsService
    {
        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
