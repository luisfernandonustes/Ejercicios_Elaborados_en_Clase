// See https://aka.ms/new-console-template for more information

using Ejercicio1;

Musica m = new Musica("Colombiana","Tropical");
Cantante c = new Cantante("Dario", "Gomez");
Cancion can = new Cancion("Nadie es Eterno", "50 millones");


Console.WriteLine("---------------------------------------");
Console.WriteLine("- Ejercicio del Dia 24 Agosto 2022    -");
Console.WriteLine("---------------------------------------");
Console.WriteLine("///////////////////////////////////////");
Console.WriteLine("Musica:"+" " +m.Name);
Console.WriteLine("Nombre del cantante:" + " " + c.Name);
Console.WriteLine("Nombre de la Canción:" + " " + can.Name);
Console.WriteLine("///////////////////////////////////////");
Console.WriteLine("---------------------------------------");
