internal class Program
{
    private static void Main(string[] args)
    {
        List<string> toDolist = new List<string>();

        Console.WriteLine("Hello!");
        Console.WriteLine("");

        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all todos");
            Console.WriteLine("[A]dd a todo");
            Console.WriteLine("[R]emove a todo");
            Console.WriteLine("[Exit]");
            string userInput = Console.ReadLine()!;
            Console.WriteLine("");
            if (userInput == "s" || userInput == "S")
            {
                int i = 0;
                foreach (var toDo in toDolist)
                {
                    Console.WriteLine($"{++i}. {toDo}");
                }
            }
            else if (userInput == "a" || userInput == "A")
            {
                while (true)
                {
                    Console.WriteLine("Enter the todo description:");
                    string userTodoAddInput = Console.ReadLine()!;
                    if (userTodoAddInput == "")
                    {
                        Console.WriteLine("The description can't be Empty!");
                        Console.WriteLine("");
                    }
                    else if (toDolist.Contains(userTodoAddInput))
                    {
                        Console.WriteLine("You Have This Todo already!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        toDolist.Add(userTodoAddInput);
                        Console.WriteLine($"TODO successfully added: {userTodoAddInput}");
                        break;
                    }
                }

            }
            else if (userInput == "r" || userInput == "R")
            {
                while (true)
                {
                    int i = 0;
                    Console.WriteLine("Which one you want to remove?");
                    foreach (var toDo in toDolist)
                    {
                        Console.WriteLine($"{++i}. {toDo}");
                    }
                    var userTodoRemoveInput = Console.ReadLine();
                    bool IsIntuserTodoRemoveInput = int.TryParse(userTodoRemoveInput, out int number);

                    if (!IsIntuserTodoRemoveInput || Convert.ToInt32(userTodoRemoveInput) <= 0 || Convert.ToInt32(userTodoRemoveInput) > toDolist.Count())
                    {
                        Console.WriteLine("Enter a Valid choice");
                    }
                    else
                    {
                        Console.WriteLine($"TODO successfully Removed: {toDolist[Convert.ToInt32(userTodoRemoveInput) - 1]}");
                        toDolist.RemoveAt(Convert.ToInt32(userTodoRemoveInput) - 1);
                        break;
                    }
                    
                }

            }
            else if (userInput == "e" || userInput == "E")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine("");
        }
    }
}