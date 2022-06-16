using DAY1.Data;
using DAY1.DTO;
using DAY1.Models;

namespace DAY1.Services.Interfaces
{
    class TaskService : ITaskService
    {
        public TaskModel Create(string title, bool isCompeted)
        {
            TaskModel newTask = new TaskModel(title, isCompeted);
            TaskContext.TaskModels.Add(newTask);

            return newTask;
        }

        public bool DeleteById(Guid id)
        {
            var item = TaskContext.TaskModels.Find(i => i.Id == id);
            if (item != null)
            {
                TaskContext.TaskModels.Remove(item);

                return true;
            }

            return false;
        }

        public bool DeleteByIds(List<Guid> ids)
        {
            try
            {
                TaskContext.TaskModels.RemoveAll(i => ids.Contains(i.Id));

                return true;
            }
            catch
            {
                return false;
            }
        }

        public TaskModel? EditById(Guid id, TaskModel taskModel)
        {
            var item = TaskContext.TaskModels.Find(i => i.Id == taskModel.Id);
            if (item != null)
            {
                item.Title = taskModel.Title;
                item.IsCompeted = taskModel.IsCompeted;

                return item;
            }

            return null;
        }

        public List<TaskModel> GetAll()
        {
            return TaskContext.TaskModels;
        }

        public TaskModel? GetById(Guid id)
        {
            return TaskContext.TaskModels.Find(i => i.Id == id);
        }

        public List<TaskModel> AddMulti(List<TaskModelDTO> taskModelDTO)
        {
            var newTasks = new List<TaskModel>();

            foreach (var task in taskModelDTO)
            {
                newTasks.Add(new TaskModel(task.Title, task.IsCompeted));
            }

            TaskContext.TaskModels.AddRange(newTasks);

            return newTasks;
        }
    }
}
