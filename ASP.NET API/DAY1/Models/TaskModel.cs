namespace DAY1.Models
{
    public class TaskModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsCompeted { get; set; }

        public TaskModel(string _title, bool _isCompeted)
        {
            this.Id = Guid.NewGuid();
            this.Title = _title;
            this.IsCompeted = _isCompeted;
        }
    }
}
