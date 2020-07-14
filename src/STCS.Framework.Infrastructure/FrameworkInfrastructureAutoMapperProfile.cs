using Acme.BookStore.EServices;
using AutoMapper;
using Newtonsoft.Json.Linq;

namespace STCS.Framework
{
    public class FrameworkInfrastructureAutoMapperProfile : Profile
    {
        public FrameworkInfrastructureAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            // E-Services Task
            CreateMap<JObject, Task>()
                .ForMember(t => t.ActivityName, opt => opt.MapFrom(jo => jo["activityName"]))
                .ForMember(t => t.Folio, opt => opt.MapFrom(jo => jo["folio"]))
                .ForMember(t => t.WorkflowName, opt => opt.MapFrom(jo => jo["workflowName"]))
                .ForMember(t => t.TaskStartDate, opt => opt.MapFrom(jo => jo["taskStartDate"]))
                .ForMember(t => t.TaskEndDate, opt => opt.MapFrom(jo => jo["taskEndDate"]))
                .ForMember(t => t.AllocatedUser, opt => opt.MapFrom(jo => jo["allocatedUser"]))
                .ForMember(t => t.TaskStateId, opt => opt.MapFrom(jo => jo["taskStateId"]))
                .ForMember(t => t.TaskState, opt => opt.MapFrom(jo => jo["taskState"]))
                .ForMember(t => t.TaskStatusId, opt => opt.MapFrom(jo => jo["taskStatusId"]))
                .ForMember(t => t.TaskStatusAr, opt => opt.MapFrom(jo => jo["taskStatusAr"]))
                .ForMember(t => t.TaskStatusEn, opt => opt.MapFrom(jo => jo["taskStatusEn"]))
                .ForMember(t => t.Sn, opt => opt.MapFrom(jo => jo["sn"]))
                .ForMember(t => t.ProcessInstanceId, opt => opt.MapFrom(jo => jo["processInstanceId"]))
                .ForMember(t => t.RequestNumber, opt => opt.MapFrom(jo => jo["requestNumber"]))
                .ForMember(t => t.ReferenceNumber, opt => opt.MapFrom(jo => jo["referenceNumber"]))
                .ForMember(t => t.RequestTypeId, opt => opt.MapFrom(jo => jo["requestTypeId"]))
                .ForMember(t => t.RequestTypeNameAr, opt => opt.MapFrom(jo => jo["requestTypeNameAr"]))
                .ForMember(t => t.RequestTypeNameEn, opt => opt.MapFrom(jo => jo["requestTypeNameEn"]))
                .ForMember(t => t.RequestStatusId, opt => opt.MapFrom(jo => jo["requestStatusId"]))
                .ForMember(t => t.RequestStatusNameAr, opt => opt.MapFrom(jo => jo["requestStatusNameAr"]))
                .ForMember(t => t.RequestStatusNameEn, opt => opt.MapFrom(jo => jo["requestStatusNameEn"]))
                .ForMember(t => t.PublishedDate, opt => opt.MapFrom(jo => jo["publishedDate"]))
                .ForMember(t => t.TaskURL, opt => opt.MapFrom(jo => jo["taskURL"]))
                .ForMember(t => t.TaskURL_Ar, opt => opt.MapFrom(jo => jo["taskURL_Ar"]))
                .ForMember(t => t.RequestURL, opt => opt.MapFrom(jo => jo["requestURL"]))
                .ForMember(t => t.RequestURL_Ar, opt => opt.MapFrom(jo => jo["requestURL_Ar"]))
                .ForMember(t => t.DepartmentCode, opt => opt.MapFrom(jo => jo["departmentCode"]))
                .ForMember(t => t.RequestCreatedBy, opt => opt.MapFrom(jo => jo["requestCreatedBy"]))
                .ForMember(t => t.RequestCreatedByDisplayName, opt => opt.MapFrom(jo => jo["requestCreatedByDisplayName"]));
        }
    }
}
