//------------ ZAVD 1 ---------------
using System;

Random rnd = new Random();

int[] A = new int[5];
float[,] B = new float[3, 4];
double mini, maxi, sum = 0, dobytok = 1, sumEvenA = 0, sumOddB = 0;

for(int i = 0; i < 5; i++)
{
    Console.Write($"Enter number for array index {i}: ");
    A[i] = Convert.ToInt32(Console.ReadLine());
}
mini = A[0];
maxi = A[0];
Console.WriteLine();

Console.WriteLine("Array A: ");
for (int i = 0; i < 5; i++)
{
    if (A[i] < mini) { mini = A[i]; }
    if (A[i] > maxi) { maxi = A[i]; }
    sum += A[i];
    dobytok *= A[i];
    if(i % 2 == 0) { sumEvenA += A[i]; }
    Console.Write($"{A[i]} \t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Array B: ");
for (int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        float num = (float)rnd.NextDouble() * (101 - (-100)) + (-100);
        B[i, j] = (float)Math.Round(num, 1);
        if (B[i, j] < mini) { mini = B[i, j]; }
        if (B[i, j] > maxi) { maxi = B[i, j]; }
        sum += B[i, j];
        dobytok *= B[i, j];
        if (i % 2 != 0) { sumOddB += B[i, j];  }
        Console.Write($"{B[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Max element: {maxi}");
Console.WriteLine($"Min element: {mini}");
Console.WriteLine($"Sum of elements: {sum}");
Console.WriteLine($"Dobytok of elements: {dobytok}");
Console.WriteLine($"Sum of even elements of array A: {sumEvenA}");
Console.WriteLine($"Sum of elements from odd rows of array B: {sumOddB}");

Console.WriteLine();
Console.WriteLine("---------------------------------");
//------------ ZAVD 2 ---------------
int[,] arr = new int[5, 5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = rnd.Next(-100, 101);
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

int min = arr[0, 0], max = arr[0, 0];
int minI = 0, minJ = 0, maxI = 0, maxJ = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (arr[i, j] < min)
        {
            min = arr[i, j];
            minI = i;
            minJ = j;
        }
        if (arr[i, j] > max)
        {
            max = arr[i, j];
            maxI = i;
            maxJ = j;
        }
    }
}

Console.WriteLine($"\nMin element: {min} at [{minI},{minJ}]");
Console.WriteLine($"Max element: {max} at [{maxI},{maxJ}]");

int minIndex = minI * 5 + minJ;
int maxIndex = maxI * 5 + maxJ;

int startIndex = Math.Min(minIndex, maxIndex);
int endIndex = Math.Max(minIndex, maxIndex);

int suma = 0;
Console.Write("Elements between min and max: ");

for (int i = startIndex + 1; i < endIndex; i++)
{
    int row = i / 5;
    int col = i % 5;
    suma += arr[row, col];
    Console.Write(arr[row, col] + " ");
}

Console.WriteLine($"\nSum: {suma}");


Console.WriteLine();
Console.WriteLine("---------------------------------");
//---------------- ZAVD 3 ------------------
Console.Write("Write smth to encrypt: ");
string textEnc = Console.ReadLine();
string tempText = "";

foreach (char c in textEnc)
{
    int tempEnc = (int)c + 3;
    char t = (char)tempEnc;
    tempText += t;
}

textEnc = tempText;
tempText = "";

Console.WriteLine(textEnc);


Console.Write("Write smth to decipher: ");
string textDec = Console.ReadLine();

foreach (char c in textDec)
{
    int tempDec = (int)c - 3;
    char t = (char)tempDec;
    tempText += t;
}
textDec = tempText;
tempText = null;

Console.WriteLine(textDec);