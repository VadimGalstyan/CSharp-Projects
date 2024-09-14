
using Sudoku;

class Project
{
    static void Main(string[] args)
    {
        Table obj = new Table();
        if(obj.Solve())
        {
            Console.WriteLine("Program gives us a one solution.There can be another.");
            obj.printTable();
        }
    }
}

