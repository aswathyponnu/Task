using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.BI;
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository taskRepository;

        public TaskController(ITaskRepository taskRepository) {
            this.taskRepository = taskRepository;
        }
        [HttpGet]
        [Route("GetTasks")]
        public IList<Tasks> GetTasks() { 
            var data = taskRepository.GetTasks();
            return data;
        }

        [HttpPost]
        [Route("SaveTask")]
        public bool SaveTask(Tasks task)
        {
            taskRepository.SaveTask(task);
            return true;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public IList<Employee> GetEmployees()
        {
            var data = taskRepository.GetEmployees();
            return data;
        }
    }
}
