using DAY1.DTO;
using DAY1.Models;

namespace DAY1.Services.Interfaces
{
    public interface ITaskService
    {
        TaskModel Create(string title, bool isCompeted);
        List<TaskModel> GetAll();
        TaskModel? GetById(Guid id);
        bool DeleteById(Guid id);
        TaskModel? EditById(Guid id, TaskModel taskModel); 
        bool DeleteByIds(List<Guid> ids);
        List<TaskModel> AddMulti(List<TaskModelDTO> taskModelDTO);
    }
}
