using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.EServices
{
    public class Task : Entity<int>
    {
        // "activityName": "GRC Director Review",
        public string ActivityName { get; set; }
        
        // "folio": "GC-061294",
        public string Folio { get; set; }

        //"workflowName": "STCS Internal Policies Process",
        public string WorkflowName { get; set; }

        //"taskStartDate": "2020-06-26T00:41:24.6630000",
        public DateTime TaskStartDate { get; set; }

        //"taskEndDate": null,
        public DateTime TaskEndDate { get; set; }

        //"allocatedUser": "K2:STCS\\ZBAHHAH",
        public string AllocatedUser { get; set; }

        //"taskStateId": 0,
        public int TaskStateId { get; set; }

        //"taskState": null,
        public string TaskState { get; set; }

        //"taskStatusId": 3,
        public int TaskStatusId { get; set; }

        //"taskStatusAr": "متأخرة جداً",
        public string TaskStatusAr { get; set; }

        //"taskStatusEn": "Too Late",
        public string TaskStatusEn { get; set; }

        //"sn": "3106_62",
        public string Sn { get; set; }

        //"processInstanceId": 3106,
        public int ProcessInstanceId { get; set; }

        // "requestNumber": 61294,
        public int RequestNumber { get; set; }
      
        //"referenceNumber": "GC-061294",
        public string ReferenceNumber { get; set; }

        //"requestTypeId": 1,
        public int RequestTypeId { get; set; }

        //"requestTypeNameAr": "سياسة داخلية جديدة",
        public string RequestTypeNameAr { get; set; }
      
        //"requestTypeNameEn": "New Internal Policies",
        public string RequestTypeNameEn { get; set; }
      
        //"requestStatusId": 4,
        public int RequestStatusId { get; set; }

        //"requestStatusNameAr": "GRC Director Review",
        public string RequestStatusNameAr { get; set; }

        //"requestStatusNameEn": "GRC Director Review",
        public string RequestStatusNameEn { get; set; }

        //"publishedDate": "2019-12-08T13:44:23.0000000",
        public DateTime PublishedDate { get; set; }

        //"taskURL": "http://eservices-dev.stcs.com.sa/Runtime/Runtime/Form/GRC.InternalPolicy.Review.Form?SN=3106_62&pRequestID=cf0edb21-4727-4fdd-adbc-0c7d317801d4&IsPortal=1",
        public string TaskURL { get; set; }

        //"taskURL_Ar": "http://eservices-dev.stcs.com.sa/Arabic/Runtime/Form/GRC.InternalPolicy.Review.Form?SN=3106_62&pRequestID=cf0edb21-4727-4fdd-adbc-0c7d317801d4&IsPortal=1",
        public string TaskURL_Ar { get; set; }

        //"requestURL": "http://eservices-dev.stcs.com.sa/Runtime/Runtime/Form/GRC.InternalPolicy.RO.Form/?pRequestID=cf0edb21-4727-4fdd-adbc-0c7d317801d4&IsPortal=1",
        public string RequestURL { get; set; }

        //"requestURL_Ar": "http://eservices-dev.stcs.com.sa/Arabic/Runtime/Form/GRC.InternalPolicy.RO.Form/?pRequestID=cf0edb21-4727-4fdd-adbc-0c7d317801d4&IsPortal=1",
        public string RequestURL_Ar { get; set; }

        //"departmentCode": "GC",
        public string DepartmentCode { get; set; }

        //"requestCreatedBy": "STCS\\mkheiralla.c",
        public string RequestCreatedBy { get; set; }

        //"requestCreatedByDisplayName": "Zakaria M. Bahhah",
        public string RequestCreatedByDisplayName { get; set; }
    }
}
