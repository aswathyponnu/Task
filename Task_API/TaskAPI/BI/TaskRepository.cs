using TaskAPI.Models;

namespace TaskAPI.BI
{
    public interface ITaskRepository
    {
        IList<Tasks>? GetTasks();
        void SaveTask(Tasks task);

        IList<Employee>? GetEmployees();
    }
    public class TaskRepository : ITaskRepository
    {
       

        public IList<Tasks>? GetTasks()
        {
            using (var context = new TaskDbContext())
            {
                var data = context.Tasks.ToList();
                return data;
            }
            return null;
        }
        public IList<Employee>? GetEmployees()
        {
            using (var context = new TaskDbContext())
            {
                var data = context.Employees.ToList();
                return data;
            }
            return null;
        }
        public void SaveTask(Tasks task)
        {
            using (var context = new TaskDbContext())
            {
               context.Add(task);
            }
        }
    }
}
