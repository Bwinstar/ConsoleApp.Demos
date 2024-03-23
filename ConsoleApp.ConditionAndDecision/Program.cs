// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Hello, World!");
// Condition and Decision

/* 
 If Statement
*/
// Prompt for input
using System.ComponentModel.Design;
Console.WriteLine("**************************Simple If Result**********");

Console.WriteLine(" Please enter the Student Grade : ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decision
if (grade >= 50)
{
    Console.WriteLine(" The Student has Passed");
}
else 
{
    Console.WriteLine(" The student has failed Woefully");
    Console.WriteLine("Kindly Recommend the Student to the Student affairs Office");
}
Console.WriteLine("Thank you for using this Program");

Console.WriteLine("**************************Simple If Result End**********");


Console.WriteLine("**************************Complex If Result**********");

/*
 Else If Statement
 */
// Using the If Statment to make Decision if the Customer to determine
// what type of Loan the cusomer of Chad Bank is Qualified for

Console.WriteLine(" Please enter the Account Balance : ");
int accountBalance = Convert.ToInt32(Console.ReadLine());

if (accountBalance < 50000)
{
    Console.WriteLine("The Customer is not Qualified for the Loan");
}
else if (accountBalance <= 100000)
{
    Console.WriteLine("Qualified for N20,000 Loan");
    Console.WriteLine("Proceed with your Document to the teller Office for Application");

}
else if (accountBalance <= 200000)
{
    Console.WriteLine(" The Customer is Qualified for N100,000 loan");

}
else
{
    Console.WriteLine("The Customer can get any loan");
}

    Console.WriteLine("Thank you for banking with us");

Console.WriteLine("************************** ComplexIf Result End**********");


Console.WriteLine("**************************Logical Operator Using the AND  OR statement **********");

// Using the AND and OR Operator
/* 
 * Grading the student Score like this
 A : 85 - 100
 B : 75 - 84
 C : 65 - 74
 D : 50 - 64
 F : less than %0
 */
Console.WriteLine(" Please enter the Student Score for the Grading System: ");
int score = Convert.ToInt32(Console.ReadLine()); 

if (score < 0 || score > 100)
{
    Console.WriteLine("The score are INVALID");
}
else if (score < 50)
{
    Console.WriteLine(" The Student has Failed - F");
}
else if (score >= 50 && score <= 64)
{
    Console.WriteLine(" D");
}
else if (score >= 65 && score <= 74)
{
    Console.WriteLine(" C");
}
else if (score >= 75 && score <= 84)
{
    Console.WriteLine(" B ");
}
else if (score >= 85 && score <= 100)
{
    Console.WriteLine(" Excellent A");
}
else
{
    Console.WriteLine(" Not a Valid score");
}

    Console.WriteLine("Thank you for using this Program");
Console.WriteLine("************************** Logical Operator the AND OR statemnt  Result**********");

Console.WriteLine("************************** Ternary Operator Result**********");


String passStatus = score > 50 ? "Pass" : "Fail";
Console.WriteLine($" student score Stauts : {passStatus}");

Console.WriteLine("************************** Ternary Operator Result**********");

Console.WriteLine(" thank you for Using this Program");


Console.WriteLine(" *********Switch Operator*****");

/* Using the switch Operator to accept an integer as the day of the week
 and printing the Approprita message as  Outline Below:
1 - Sunday
2 _ Monday
3 - Tuesday
4 - Wednesday
5 - Thursday
6 - Friday (TGIF !!!)
7 - Saturday (Beach Day !!!)
*/
Console.WriteLine("Please Enter the Day of the Week");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        Console.WriteLine("TGIF !!!");
        break;
    case 7:
        Console.WriteLine("Saturday");
        Console.WriteLine("Beach Day!!!");
        break;
    default:
        Console.WriteLine(" Invalid Day number Entered");
        break;
}






