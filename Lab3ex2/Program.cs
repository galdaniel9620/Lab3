//Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul


Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());

if (IsPerfectSquare(number))
{
    Console.WriteLine(number + " is a perfect square.");
}
else
{
    Console.WriteLine(number + " is not a perfect square.");
}

bool IsPerfectSquare(int number)
{
    double squareRoot = Math.Sqrt(number);
    return squareRoot == Math.Floor(squareRoot);
}