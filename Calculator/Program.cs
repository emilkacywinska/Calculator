class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;

        int result;

        
        Console.WriteLine("Hello, welcome to the calculator program!");

        Console.WriteLine("Choose method: ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToInt16(Console.ReadLine());

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("The result is: " + result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("The result is: " + result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("The result is: " + result);
                break;
            case 4:
                result = num1 / num2;
                Console.WriteLine("The result is: " + result);
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }
        
    }
}