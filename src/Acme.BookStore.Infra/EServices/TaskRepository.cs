using Acme.BookStore.Repositories;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.ObjectMapping;
using Api = Acme.BookStore.EServices;

namespace Acme.BookStore.Infra.EServices
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(ITaskRepository))]
    public class TaskRepository : ITaskRepository
    {
        #region Private Members

        private readonly IConfiguration Configuration;
        private readonly IObjectMapper ObjectMapper;

        #endregion
        #region Properties
        public string MyTasks_address
        {
            get
            {
                //return ConfigurationManager.AppSettings["MyTasks_address"]; 
                return Configuration["Tasks_URL"];
            }
        }
        #endregion

        //public TaskRepository()
        //{
        //}

        public TaskRepository(IConfiguration configuration, IObjectMapper objectMapper)
        {
            Configuration = configuration;
            ObjectMapper = objectMapper;
        }       
        public Task<List<BookStore.EServices.Task>> GetMyTasks(string CurrentUserName)
        {
            if (!string.IsNullOrEmpty(CurrentUserName))
            {
                // Call API and Get json object
                dynamic json = "";
                var jsonoObj = JObject.Parse(json);
                return ObjectMapper.Map<JObject, Api.Task>(jsonoObj);
            }
            return null;
        }
    }
}
