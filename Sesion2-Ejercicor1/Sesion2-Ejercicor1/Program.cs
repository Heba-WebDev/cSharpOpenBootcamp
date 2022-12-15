// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? nombre;
Console.Write("Nombre? ");
nombre = Console.ReadLine();

string? apellido;
Console.Write("Apellido? ");
apellido = Console.ReadLine();

int? edad;
Console.Write("Edad? ");
edad = System.Convert.ToInt32(Console.ReadLine());

string? sabeProgramar;
Console.Write("Usted sabe programar? ");
sabeProgramar = Console.ReadLine();


Console.WriteLine($"Se llama {nombre}, su apellido es {apellido}, tiene usted {edad} y usted {sabeProgramar} sabe programar ");

Console.ReadLine();