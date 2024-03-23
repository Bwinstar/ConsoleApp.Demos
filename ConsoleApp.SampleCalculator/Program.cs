// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Sample Calculator");

// Prompt for User Input

Console.Write(" Please enter the First number :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Second Number :");
int num2 = Convert.ToInt32(Console.ReadLine());
// Showing Calculator Menu

Console.WriteLine("Please Select an Operator ");
Console.WriteLine("1. Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4. Division");
Console.Write("Select : ");

int choice = Convert.ToInt32(Console.ReadLine());

//Deciding which Operator to use
int answer = 0;
switch (choice)
{
    case 1 :
        answer = num1 + num2;
        break;
    case 2 :
        answer = num2 - num1;
        break;
    case 3 :
        answer = num1 * num2;
        break;
    case 4 :
        answer = num2 / num1;
        break;
    default :
        Console.WriteLine($"Invalid Operator");
        break;
}
//Printing the Output
Console.WriteLine($"The Answer is : {answer}");


Console.WriteLine("*********************---- Using another Data type Var ---***************");


//Using another Data Type var
Console.WriteLine("Welcome to the Sample Calculator");

// Prompt for User Input

Console.Write(" Please enter the First number :");
int no1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Second Number :");
int no2 = Convert.ToInt32(Console.ReadLine());
// Showing Calculator Menu

Console.WriteLine("Please Select an Operator ");
Console.WriteLine("A. Addition");
Console.WriteLine("B.Subtraction");
Console.WriteLine("C.Multiplication");
Console.WriteLine("D. Division");
Console.Write("Select : ");

var choose = Convert.ToString(Console.ReadLine());

//Deciding which Operator to use
int result = 0;

switch (choice)
{
    case 1:
        answer = no1 + no2;
        break;
    case 2:
        answer = no2 - no1;
        break;
    case 3:
        answer = no1 * no2;
        break;
    case 4:
        answer = no1 / no2;
        break;
    default:
        Console.WriteLine($"Invalid Operator");
        break;
}
//Printing the Output
Console.WriteLine($"The Answer is : {result}");







