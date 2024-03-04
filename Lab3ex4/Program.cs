//Scrieti un program care va inversa elementele unui vector
// Lungimea vectorului va fi citita de la tastatura
// Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
// Afisarea vectorului se va face printr-o functie de afisare dedicata

void Main(string[] args)
{
    Console.WriteLine("Enter the length of the array:");
    int n = int.Parse(Console.ReadLine());

    int[] array = new int[n];

    Console.WriteLine($"Enter {n} elements for the array:");

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Element {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < n / 2; i++)
    {
        int temp = array[i];
        array[i] = array[n - i - 1];
        array[n - i - 1] = temp;
    }

    DisplayArray(array);
}

void DisplayArray(int[] array)
{
    Console.WriteLine("The reversed array is:");
    foreach (int element in array)
    {
        Console.Write(element + " ");
    }
}

Main(args);