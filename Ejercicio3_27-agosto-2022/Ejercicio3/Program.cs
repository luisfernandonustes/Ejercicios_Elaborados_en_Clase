// See https://aka.ms/new-console-template for more information
using Ejercicio3;
using Ejercicio3.accesorios;
using Ejercicio3.bicicletas;

Console.WriteLine("Hello, World!");

//crear accesorios
IAccesorio accesorio = new Gps();
IAccesorio accesorio1 = new MotorGasolina();

Bicicleta bicicleta = new Bicicleta(accesorio, accesorio1);

