using DAY1.Models;

namespace DAY1.Data
{
    public static class TaskContext
    {
        public static List<TaskModel> TaskModels = new List<TaskModel>
        {
            new TaskModel("Hello", false),
            new TaskModel("Hi", true),
            new TaskModel("Welcome", true)
        };
    }
}