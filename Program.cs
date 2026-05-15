using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("\nWelcome to Eddy's Calculator"); 
int firstNum = askNum(); 
char character = askOp();
int secondNum = askNum();  
doOperation(firstNum,secondNum,character);

static void doOperation(int num1, int num2, char op)
{
    int ans; 
    switch(op)
    {
        case '+':
            ans = num1+num2;
            Console.WriteLine($"{num1} {op} {num2} = {ans}");
            break;
        case '/':
            ans = num1/num2;
            Console.WriteLine($"{num1} {op} {num2} = {ans}"); 
            break;
        case '-':
            ans = num1-num2;
            Console.WriteLine($"{num1} {op} {num2} = {ans}");
            break;
        case '*':
            ans = num1*num2;
            Console.WriteLine($"{num1} {op} {num2} = {ans}");
            break;
    }
}


// ASK SIGN 
static char askOp()
{
    char op = ' '; 
    while (op != '+' && op != '-' && op != '*' && op != '/')
    {
        Console.WriteLine("Pick an operator (+, -, *, /):");
        try
        {
            op = char.Parse(Console.ReadLine());
        }
        catch(ArgumentNullException)
        {
            Console.WriteLine("Input cannot be null"); 
        }
        catch (FormatException)
        {
            Console.WriteLine("Input has to be char"); 
        }
    }
    return op;
}



// ASK NUM
static int askNum()
{
    Console.WriteLine("Pick any number:");
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