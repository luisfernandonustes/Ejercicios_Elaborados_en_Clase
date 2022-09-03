// See https://aka.ms/new-console-template for more information
using Ejercicio5.Controllers;
using Ejercicio5.Models;
using Ejercicio5.Views.Trabajadores;

Console.WriteLine("____________________________________________");
Console.WriteLine("Ejercicio 01/Septiembre/2022");
Console.WriteLine("____________________________________________");
TrabajadorController Controller = new TrabajadorController(new CrearTrabajador());
Controller.Crear("1110178845", "Luis", ConstruccionObra.Build("0010", "Diagonal 36#13-77"));
Console.WriteLine("____________________________________________");