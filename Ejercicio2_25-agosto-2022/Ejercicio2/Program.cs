using Ejercicio2.Entities;
using Ejercicio2.Entities1;

//___________________________________________________________________Entidades
//polimorfismo y caste (atributos)
Entity ve = new VehiculoElectrico(id: "1", placa: "hga223", horasCarga: 50.1);
var ve1 = (VehiculoElectrico)ve;
Console.WriteLine(ve1.HorasCarga);

//polimorfismo y caste (metodo)

Entity vg = new VehiculoGasolina(id: "1", placa: "hga256");
var vg1 = (VehiculoGasolina)vg;
vg1.ImprimirValores();

//___________________________________________________________________Entidades1

Entity1 vehiculo = new VehiculoElectrico1();
vehiculo.Arrancar();

Entity1 vehiculo2 = new VehiculoGasolina1();
vehiculo.Arrancar();