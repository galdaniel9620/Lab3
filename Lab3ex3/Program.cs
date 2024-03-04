//Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
//• Cel mai mare numar din vector
//• Cel mai mic numar din vector
//• Numerele divizibile cu 3
//• Numerele patrate perfecte din vector


using System.Numerics;

Console.WriteLine("Enter the size of the array:");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

Console.WriteLine($"Enter {n} integers:");

for (int i = 0; i < n; i++)
{
    Console.Write($"Element {i + 1}: ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("The array you entered is:");
foreach (int num in array)
{
    Console.Write(num + " ");
}
Console.WriteLine();


int max;
int min;

MaxNumber(array);
MinNumber(array);


Console.WriteLine("Max is: " + max);
Console.WriteLine("Min is: " + min);

Console.WriteLine("Numbers divisible by 3:");
int[] divisibleBy3 = Div(array);
foreach (int num in divisibleBy3)
{
    Console.Write(num + " ");
}
Console.WriteLine();

Console.WriteLine("Perfect square numbers:");
DisplayPerfectSquares(array);
Console.WriteLine();


int MaxNumber (int[] array) {
    max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


int MinNumber(int[] array)
{
    min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }


    return min;
}


int[] Div(int[] array)
{
    int[] divisibleBy3 = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 3 == 0)
        {
            divisibleBy3[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref divisibleBy3, count);
    return divisibleBy3;
}

void DisplayPerfectSquares(int[] array)
{
    foreach (int number in array)
    {
        if (IsPerfectSquare(number))
        {
            Console.Write(number + " ");
        }
    }
}

bool IsPerfectSquare(int number)
{
    int squareRoot = (int)Math.Sqrt(number);
    return squareRoot * squareRoot == number;
}


void SimpleMinMax(int[] array) {
    Console.WriteLine("Other Method");
    Console.WriteLine($"Min is {array.Min()}");
    Console.WriteLine($"Max is {array.Max()}");
}

SimpleMinMax(array);