using Microsoft.AspNetCore.Mvc;
using TaskApi.ITaskRepository;
using TaskApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        ITask _repo;

        public TaskController(ITask repo)
        {
            _repo = repo;
        }
        // Add required dependencies here
        [HttpPost]
        public async Task<IActionResult> Addtask(Models.Task task)
        {
            if (await _repo.AddTask(task))
            {
                return Ok("Added successfully");
            }
            else
            {
                return BadRequest("Add Task Failed");
            }
        }

        [HttpGet]
        public async Task<IEnumerable<Models.Task>> GetTasks()
        {
            return await _repo.GetAllTasks();
        }

        [HttpGet("{id}")]
        public async Task<Models.Task> GetTaskById(int id)
        {
            return await _repo.GetTaskById(id);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Models.Task task)
        {

            if(await _repo.Edit(task))
            {
                return Ok("Edited successfully");
            }
            else
            {
                return NotFound("edit failed");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if(await _repo.DeleteTask(id))
            {
                return Ok("Deleted");
            }
            else
            {
                return NotFound("ID not found");
            }
        }
    }
}
