using System.Dynamic;
using ToDo;

List<ToDoTask> tasks = new List<ToDoTask>();
tasks.Add(new ToDoTask() { GuidId=Guid.NewGuid(),   Details = "First Task", Priority = Priority.Medium });
tasks.Add(new ToDoTask() { GuidId = Guid.NewGuid(), Details = "Second Task", Priority = Priority.Lowest});
tasks.Add(new ToDoTask() { GuidId = Guid.NewGuid(), Details = "Third Task", Priority = Priority.Highest});
Console.WriteLine("-------------- ToDo App ---------------");
string operation = "";
while (operation is not "ex")
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Your Todo List ");
    Console.WriteLine("please enter 1 to add task ");
    Console.WriteLine("please enter 2 to remove task or completed task (Using ID)");
    Console.WriteLine("please enter 3 to show your Todo task ");
    Console.WriteLine("please enter ex to close the program ");
    operation = Console.ReadLine();
    if (operation == "1")
    {
        Console.WriteLine("please enter your Task details");
        var details = Console.ReadLine();
        Console.WriteLine("please enter your Task Priority");
        Console.WriteLine("press 1 to hight,2 to medium ,3 to low");
        var priority = Console.ReadLine();
        var task = new ToDoTask();
        var testTask = tasks.Any(b => b.Details.ToLower() == details.ToLower());
        if (!testTask && !string.IsNullOrEmpty(details))
        {
            task.Details = details;
            switch (priority)
            {
                case "1":
                    task.Priority = Priority.Highest;
                    break;
                case "2":
                    task.Priority = Priority.Medium;
                    break;
                case "3":
                    task.Priority = Priority.Lowest;
                    break;
                default:
                    Console.WriteLine("Please enter Task valid Priority");
                    break;

            };
            task.GuidId = Guid.NewGuid();
            tasks.Add(task);
        }
    }
    else if(operation == "2")
    {
        Console.WriteLine("please enter your completed task Id");
        var task =Console.ReadLine();
        var deletedTask = tasks.FirstOrDefault(b => b.GuidId.ToString() == task);
        if (deletedTask != null)
            tasks.Remove(deletedTask);
        else
            Console.WriteLine("this Task already deleted or doesn't exist");

    }
    else if (operation == "3")
    {
     
        Console.WriteLine("-------------- ToDo List ---------------");
        if (tasks.Any())
        {
            var orderedTodo = tasks.OrderBy(b => b.Priority).ToList();
            for (int i=0;i< orderedTodo.Count;i++)
            {
                Console.WriteLine($"Task ID : {orderedTodo[i].GuidId} - Your Task {orderedTodo[i].Details} : the Priority {orderedTodo[i].Priority}");
            }
        }
        else
            Console.WriteLine("Your ToDo Empty ");

    }
    else if(operation=="ex")
    {
        break;
    }

    Console.WriteLine("please choose number from the list or exist");

 
}
