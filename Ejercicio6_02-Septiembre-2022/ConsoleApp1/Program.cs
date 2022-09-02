// See https://aka.ms/new-console-template for more information
using ConsoleApp1.CentroComercial;
using ConsoleApp1.Entities;

Console.WriteLine("Hello, World!");
//Asesor
PuntoVentaMovistar<AsesorComercial> puntoVentaMovistar = new PuntoVentaMovistar<AsesorComercial>();
puntoVentaMovistar.Venta(new AsesorComercial());



