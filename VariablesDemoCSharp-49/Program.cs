namespace VariablesDemoCSharp_49;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        //camelCase for variable names - everyOtherLetterStartsWithCapital
        
        //Number types
        
        //Declaring a variable (creation of a variable)
        int wholeNumber;
        
        //Initializing a variable (giving a variable a value)
        wholeNumber = 5;
        
        //Or do both
        //Declaring and initializing
        int newNumber = 10;

        double average = 99.80;

        decimal myWallet = 1000.00m;

        //Word types

        string ourClass = "CSharp-49";

        char initial = 'S';
        
        //Fact type

        bool isCoding = true;
        
        //String Interpolation

        //string message = $"Our class is {ourClass}";

        //Console.WriteLine($"Our class is {ourClass}");
        
        //Take user input

        Console.WriteLine("Give me your name:");

        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}!");

    }
}