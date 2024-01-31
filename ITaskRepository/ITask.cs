using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;

namespace TaskApi.ITaskRepository
{
    public interface ITask
    {
        //Declare all following functions only for CRUD for Task & SubTask

        public Task<IEnumerable<Models.Task>> GetAllTasks();

        public Task<bool> AddTask(Models.Task task);

        public Task<Models.Task> GetTaskById(int id);

        public Task<bool> DeleteTask(int id);

        public Task<bool> Edit(Models.Task task);

        // Add a Task
        // Get all Tasks
        // Get a particular Task
        // Edit some Task
        // Delete some task, in case there is no subtask

        // Add a SubTack for a Task
        // Get all subtasks for a particular Task
        // Here in display Task Name, SubtTask Name,Created By, When

    }
}
