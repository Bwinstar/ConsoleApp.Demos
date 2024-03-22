// See https://aka.ms/new-console-template for more information

// Variables

/* 
  Text - string
  Integer - int
  Decimal - double, float, decimal
 Logical -bool(true or False)

 */

string name = " Kanu Winner Ezinne from Nigeria";

Console.WriteLine(name);
Console.WriteLine("my names is Kanu Winner Ezinne ,and I am 24 years Old");
Console.WriteLine("I want to be a professional Developer");

Console.WriteLine("I am" + name);// string concatenation
Console.WriteLine($" they call me {name}"); // string Interpolation
Console.WriteLine("I was given the name {0}", name); //formated string

int age = 24;
int retirementYearsLeft = 31;
int retirementAgeLeft = age + retirementYearsLeft;

Console.WriteLine("my age is :" + age);


// Logical Boolean - True or False

bool isRetired = true;
Console.WriteLine(" Am I retired? "  +  isRetired);
