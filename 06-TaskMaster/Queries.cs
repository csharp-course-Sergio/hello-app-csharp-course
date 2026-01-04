namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private readonly List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-----Lista de Tareas-----\n");

            Console.WriteLine("\n{0,-8} {1,-35} {2,-15}", "Id", "Descripción", "Completado");

            foreach (var task in Tasks)
            {

                WriteLine(new string('-', 58));
                Console.WriteLine("{0,-8} {1,-35} {2,-15}", task.Id, task.Description, task.Completed);
            }
            WriteLine(new string('-', 58));
        }
    }
}