// See htt//Scrieti o functie care va calcula suma cifrelor unui numar.

Console.WriteLine("Add a number:");
int number = int.Parse(Console.ReadLine());

int sum = 0;
SumDigits(number);

Console.WriteLine($"The sum of the digits of the number is: {sum}");

int SumDigits(int number)
{
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;

}
