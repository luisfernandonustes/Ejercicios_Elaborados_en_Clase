// See https://aka.ms/new-console-template for more information

using Ejercicio4.Entities;
using Ejercicio4.Obras;

IFactory factory = new Factory();
factory.BuildJefe(1, "35000");

var trabajador = (Trabajador) factory.BuildTrabajador(2);
