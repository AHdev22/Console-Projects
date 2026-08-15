internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Input the first number: ");
        int firstInput = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Input the Second number: ");
        int secondInput = int.Parse(Console.ReadLine()!);
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[A]dd numbers");
        Console.WriteLine("[S]ubtract numbers");
        Console.WriteLine("[M]ultiply numbers");
        string userChoice = Console.ReadLine()!;

        if (userChoice == "a" || userChoice == "A")
        {
            Console.WriteLine($"{firstInput} + {secondInput} = {AddInputs(firstInput, secondInput)}");
            CloseMessage();
        }
        else if (userChoice == "s" || userChoice == "S")
        {
            Console.WriteLine($"{firstInput} - {secondInput} = {SubtractInputs(firstInput, secondInput)}");
            CloseMessage();
        }
        else if (userChoice == "m" || userChoice == "M")
        {
            Console.WriteLine($"{firstInput} * {secondInput} = {MultiplyInputs(firstInput, secondInput)}");
            CloseMessage();
        }
        else
        {
            Console.WriteLine("Invalid Choice!");
            CloseMessage();
        }

        int AddInputs(int num1, int num2)
        {
            return num1 + num2;
        }
        int SubtractInputs(int num1, int num2)
        {
            return num1 - num2;
        }
        int MultiplyInputs(int num1, int num2)
        {
            return num1 * num2;
        }

        void CloseMessage()
        {
            Console.WriteLine("Press any key to close");
        }

        Console.ReadKey();
    }
}