using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.EServices
{
    public class TaskDto: EntityDto<int>
    {    
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public string AllocatedUser { get; set; }
        public int TaskStateId { get; set; }
        public string TaskState { get; set; }
        public int TaskStatusId { get; set; }
        public string TaskStatusAr { get; set; }
        public string TaskStatusEn { get; set; }
        public string Sn { get; set; }
        public int RequestNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public int RequestTypeId { get; set; }
        public string RequestTypeNameAr { get; set; }
        public string RequestTypeNameEn { get; set; }
        public int RequestStatusId { get; set; }
        public DateTime PublishedDate { get; set; }
        public string TaskURL { get; set; }
        public string TaskURL_Ar { get; set; }
        public string RequestURL { get; set; }
        public string RequestURL_Ar { get; set; }
        public string DepartmentCode { get; set; }
        public string RequestCreatedBy { get; set; }
        public string RequestCreatedByDisplayName { get; set; }
    }
}
