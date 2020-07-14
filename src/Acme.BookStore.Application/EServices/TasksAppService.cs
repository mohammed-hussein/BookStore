using Acme.BookStore.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Api = Acme.BookStore.EServices;

namespace Acme.BookStore.EServices
{
    public class TasksAppService : ApplicationService, ITasksAppService
    {
        private readonly ITaskRepository Repository;
        public TasksAppService(ITaskRepository repository)
        {
            Repository = repository;
        }        

        public async Task<PagedResultDto<TaskDto>> GetMyTasksAsync(string UserName, PagedAndSortedResultRequestDto input)
        {
            var tasks = await Repository.GetMyTasks(UserName);
            return new PagedResultDto<TaskDto>(tasks.Count, ObjectMapper.Map<List<Api.Task>, List<TaskDto>>(tasks));
        }
    }
}
