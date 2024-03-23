// This Project Is used to collect the name and age of Users and Determine their working Age Remaining from the retirement age

//Declaring Variables
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 70;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;

/// Prompting User for Input
Console.Write("Please enter your firstName : ");
firstName = Console.ReadLine();
Console.Write("Please enter your lastName : ");
lastName = Console.ReadLine();
Console.Write("Please enter your Age : ");
age = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your gender (M or F)");
gender = Convert.ToChar(Console.ReadLine());
Console.Write("Please Enter your Salary : ");
salary = Convert.ToDecimal(Console.ReadLine());
Console.Write("Please enter your working status (true or False): ");
working = Convert.ToBoolean(Console.ReadLine());

//Processing The data
int workingYearsRemaining = retirementAge - age;

// Output the result to the Users
Console.WriteLine($"Full Name :  {firstName} {lastName}");
Console.WriteLine($" Age : {age}");
Console.WriteLine($"Salary :  {salary}");
Console.WriteLine($" Gender : {gender}");
Console.WriteLine($" Working Status : {working}");
Console.WriteLine($" Working Years Remaining : {workingYearsRemaining}");
