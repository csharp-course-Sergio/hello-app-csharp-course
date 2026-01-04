using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private readonly List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("-----Lista de Tareas-----");

            Table table = new("Id", "Descripción", "Estado");

            foreach (var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
            }

            table.Config = TableConfig.Unicode();
            Write(table.ToString());
        }

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Agregar Nueva Tarea-----");
                Write("Ingrese la descripción de la tarea: ");
                var description = ReadLine()!;
                Task newTask = new(Utils.GanerateId(), description);
                Tasks.Add(newTask);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea agregada exitosamente.");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Ocurrio un error al agregar la tarea: " + ex.Message);
                return Tasks;
            }
        }
    }
}