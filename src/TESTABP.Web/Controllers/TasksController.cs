using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TESTABP.Web.Utils;

namespace TESTABP.Web.Controllers
{
    public class TasksController : TESTABPControllerBase {
        private readonly ITaskAppService _taskAppService;

        public TasksController(ITaskAppService taskAppService) {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> TaskList(GetAllTasksInput input) {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items)
            {
                SelectedTaskState = input.State
            };
            return View(model);
        }

        public async Task<ActionResult> Register(CreateTaskInput Input)
        {
            var output = await _taskAppService.AddTask(Input);
            
            return View("TaskList");
        }
    }
}