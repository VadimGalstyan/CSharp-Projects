

class Calculator
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Calculator for integers");
        System.Console.WriteLine("Input operation(+,-,*,/)");
        string operation = System.Console.ReadLine();

        int a;
        int b;

        System.Console.WriteLine("input variables in order a,b");
        int.TryParse(System.Console.ReadLine(), out a);
        int.TryParse(System.Console.ReadLine(), out b);

        switch (operation)
        {
            case "+":
                System.Console.WriteLine(a + b);
                break;
            case "-":
                System.Console.WriteLine(a - b);
                break;
            case "*":
                System.Console.WriteLine(a * b);
                break;
            case "/":
                System.Console.WriteLine(a / b);
                break;

            default:
                System.Console.WriteLine("Invalid operation");
                break;
        }
    }
}
