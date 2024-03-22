// This Project Is used to collect the name and age of Users and Determine their working Age Remaining from the retirement age

//Declaring Variables
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 70;

/// Prompting User for Input

Console.WriteLine("Please enter your First name");
firstName = Console.ReadLine();
Console.WriteLine("Please enter your Last name");
lastName = Console.ReadLine();
Console.WriteLine(" Please enter your Age");
age = Convert.ToInt32(Console.ReadLine());

//Processing The data
int workingYearsRemaining = retirementAge - age;

// Output the result to the Users
Console.WriteLine($"Full Name :  {firstName} {lastName}");
Console.WriteLine($" Age : {age}");
Console.WriteLine($" Working Years Remaining : {workingYearsRemaining}");
