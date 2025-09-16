//------------ ZAVD 1 -------------

Console.Write("Enter number from 1 to 100: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 100)
{
    if (number % 3 == 0)
    {
        Console.Write("Fizz ");
    }
    if (number % 5 == 0)
    {
        Console.Write("Buzz");
    }
    if (number % 3 != 0 && number % 5 != 0)
    {
        Console.Write(number);
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("You wrote number less than 1, or more than/equal 100!");
}

//------------ ZAVD 2 -------------
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter percentage: ");
int procent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num * (procent / 100.0));

//------------ ZAVD 3 -------------
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fours number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
string tempNum = num1.ToString() + num2.ToString() + num3.ToString() + num4.ToString();
int sumNum = Convert.ToInt32(tempNum);
Console.WriteLine(sumNum);