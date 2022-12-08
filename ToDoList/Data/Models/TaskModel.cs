namespace ToDoList.Data.Models
{
    public class TaskModel
    {
        public String TaskName { get; set; }
        public bool IsComplete { get; set; }

        public DateTime completedDateTime {get; set; }
    }
}
