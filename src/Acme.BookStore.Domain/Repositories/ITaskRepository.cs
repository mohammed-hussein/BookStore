using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Api = Acme.BookStore.EServices;

namespace Acme.BookStore.Repositories
{
    public interface ITaskRepository: IRepository
    {
        Task<List<Api.Task>> GetMyTasks(string CurrentUserName);
    }
}
