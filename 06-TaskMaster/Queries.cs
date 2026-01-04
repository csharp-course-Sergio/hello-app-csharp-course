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
                WriteLine(ex.Message);
                return Tasks;
            }
        }
        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Marcar tarea como completada-----");
                Write("Ingrese el id de la tarea completeda: ");
                var id = ReadLine()!;

                Task task = Tasks.Find(t => t.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontró una tarea con el ID proporcionado.");
                    return Tasks;
                }

                task.Completed = true;
                task.ModifiedAt = DateTime.Now;

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea marcada como completada exitosamente.");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }
    }
}