namespace TaskMaster
{
    partial class Program
    {

        static readonly FileActions<Task> fileActions = new("./06-TaskMaster/task.json");
        static readonly List<Task> tasks = fileActions.ReadFile();
        static readonly Queries queries = new(tasks);

        public static void TaskMaster()
        {
            bool salir = false;

            while (!salir)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("-----Menú de Tareas-----");
                WriteLine("1. Listar tareas");
                WriteLine("2. Añadir tarea");
                WriteLine("3. Marcar tarea como completada");
                WriteLine("4. Editar tarea");
                WriteLine("5. Eliminar tarea");
                WriteLine("6. Consultar tareas por estado");
                WriteLine("7. Consultar tarea por descripción");
                WriteLine("8. Salir");
                Write("\nSeleccione una opción: ");

                switch (ReadLine())
                {
                    case "1": queries.ListTasks(); break;
                    case "2": AddTask(); break;
                    case "3": MarkAsCompleted(); break;
                    case "4": EditTask(); break;
                    case "5": break;
                    case "6": break;
                    case "7": break;
                    case "8":
                        salir = true;
                        Clear();
                        break;
                    default:
                        Clear();
                        WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        public static void AddTask()
        {
            try
            {
                var tasks = queries.AddTask();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                WriteLine("Ocurrio un error al agregar la tarea: " + ex.Message);
            }
        }

        public static void MarkAsCompleted()
        {
            try
            {
                var tasks = queries.MarkAsCompleted();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                WriteLine("Ocurrio un error al marcar la tarea como completada: " + ex.Message);
            }
        }

        public static void EditTask()
        {
            try
            {
                var tasks = queries.EditTask();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                WriteLine("Ocurrio un error al editar la tarea: " + ex.Message);
            }
        }
    }
}