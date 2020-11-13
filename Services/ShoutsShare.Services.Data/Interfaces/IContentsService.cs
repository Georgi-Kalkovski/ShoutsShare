namespace ShoutsShare.Services.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ShoutsShare.Web.ViewModels.Contents;

    public interface IContentsService
    {
        Task CreateAsync(CreateContentInputModel input);
    }
}
