// See https://aka.ms/new-console-template for more information
/*
 Arithmetic Operators
 */
Console.WriteLine("");
int count = 5;
Console.Write("Please enter the first Number : ");
int num1 =Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.WriteLine("Please enter the second number : ");
num2 = Convert.ToInt32(Console.ReadLine());

int num3 = 0;
Console.WriteLine(" please enter the third number : ");
num3 = Convert.ToInt32(Console.ReadLine());

int num4 = 0;
Console.WriteLine(" please enter the fourth number : ");
num4 = Convert.ToInt32(Console.ReadLine());

int num5 = 0;
Console.WriteLine(" please enter the fifth number");
num5 = Convert.ToInt32(Console.ReadLine());

// Performing the calculation

// Adding the Number
int sum = num1 + num2 + num3 + num4 + num5;

// Multiplying the numbers
int product = num1 * num2 * num3 * num4 * num5 ;

//Division
int quotient = num1 / num2/num3/num4/num5;

// Subtraaction
int difference = num1 - num2 - num3 - num3 - num4 - num5;

// Modulus
int mod = num1 % num2;

// finding the Mean of the numbers
int average = sum / count;

Console.WriteLine($"Numbers we have are : {num1} {num2} {num3} {num4} {num5}");
Console.WriteLine($"Their Sum : {sum}");
Console.WriteLine($"their Product : {product}");
Console.WriteLine($"Their Difference : {difference}");
Console.WriteLine($"Their Quotient : {quotient}");
Console.WriteLine($"Modulus : {mod}");
Console.WriteLine($" Calculating their mean : {average}");

    /*
     LOGical Operators

     */
bool isGreaterThan = num5 > num4 && num5 < num2;
bool isLessThan = num5 < num4 && num4 < num2;
bool isEqualTo = num5 < num4 && (num5 % num2) == 0;
bool isGreaterThanOrEqualTo = num5 >= num4 ;
bool isLessThanOrEqualTo = num5 <= num4;
bool isNotEqualTo = num5 != num4;

Console.WriteLine($"Is Greater Than : {isGreaterThan}");
Console.WriteLine($"Is Less Than : {isLessThan}");
Console.WriteLine($"Is Equal Than : {isEqualTo}");
Console.WriteLine($"Is Greater Than or Equal To : {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than or Equal To : {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal  TO : {isNotEqualTo}");

//Assignment Operations and Operator

num1 += 4;
Console.WriteLine($"iNCREASING Num1 by 4 : {num1}");

num2 -= 5;
Console.WriteLine($"Reducing Num2 By 5 :{num2}");

num3 /= 14;
Console.WriteLine($"Divinding Num3 by 14 : {num3}");

num4 %= 35;
Console.WriteLine($"FInding the Modulus of num4 when dividing y 35 : {num4}");

num5 *= 10;
Console.WriteLine($"Multiplying Num5 by 10 : {num5}");
// Asignment Operator
Console.WriteLine("Please Enter any Random Value : ");
int randomValue = Convert.ToInt32(Console.ReadLine());
// Increasing number

//num1 += 4;
Console.WriteLine($"iNCREASING Num1 by {randomValue}: {num1}");

//num2 -= 5;
Console.WriteLine($"Reducing Num2 By {randomValue}:{num2}");

//num3 /= 14;
Console.WriteLine($"Divinding Num3 by {randomValue} : {num3}");

//num4 %= 35;
Console.WriteLine($"FInding the Modulus of num4 when dividing {randomValue} : {num4}");

//num5 *= 10;
Console.WriteLine($"Multiplying Num5 by {randomValue} : {num5}");












