using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TESTABP {
    public interface ITaskAppService : IApplicationService {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);
        System.Threading.Tasks.Task CreateAsync(CreateTaskInput input);
        Task<TaskListDto> AddTask(CreateTaskInput input);
    }

    public class GetAllTasksInput {
        public TaskState? State { get; set; }
    }

    [AutoMapFrom(typeof(Task))]
    public class TaskListDto : EntityDto, IHasCreationTime {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }

        public Guid? AssignedPersonId { get; set; }

        public string AssignedPersonName { get; set; }
    }
}
