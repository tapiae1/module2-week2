using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Welcome to Eddy's Calculator"); 
int firstNum = askNum(); 
char character = askSign();
int secondNum = askNum();  


static char askSign()
{
    Console.WriteLine("Please pick from '*' or '/' :\n"); 
    char sign = '+';
    try
    {
        sign = char.Parse(Console.ReadLine()); 
    }
    catch(ArgumentNullException)
    {
        Console.WriteLine("Input cannot be null"); 
    }
    catch (FormatException)
    {
        Console.WriteLine("Input has to be char"); 
    }
    return sign;
}




static int askNum()
{
    Console.WriteLine("Pick any number:\n");
    int number = 0;   
    // Asking for user input  
    try
    {
        string? input = Console.ReadLine();  
        number = int.Parse(input); 
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("Input cannot be null"); 
    }
    catch(FormatException)
    {
        Console.WriteLine("Please enter a number"); 
    }

    return number; 
}