// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number;

Console.Write("Pleae enter a number ");

number = System.Convert.ToInt32(Console.ReadLine());

char letter;

Console.Write("Pleae enter a letter ");

letter = Console.ReadLine()[0];


if(number > 18)
{
    Console.WriteLine("The number you entered is bigger than 18 ");
}else
{
    Console.WriteLine("The number you entered is smaller than 18 ");
}

if(letter == 'a')
{
    Console.WriteLine("The letter you wrote is a");
} else
{
    Console.WriteLine("The letter you wrote isn't a");
}

if(number < 18 && letter == 'a')
{
    Console.WriteLine($"both conditions are {true}");
} else
{
    Console.WriteLine($"both conditions are not {true}");
}

Console.ReadLine();