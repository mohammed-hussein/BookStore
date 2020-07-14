using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.EServices
{
    public interface ITasksAppService: IApplicationService
    {
        Task<PagedResultDto<TaskDto>> GetMyTasksAsync(string UserName, PagedAndSortedResultRequestDto input);
    }
}
