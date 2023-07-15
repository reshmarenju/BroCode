// See https://aka.ms/new-console-template for more information

#region Static
//STATIC - modifier used to declare static member, which belongs to the class itself rather than to any specific objects 
using BroCode;

Car car1= new Car("Mustang");
Car car2 = new Car("Corvette");
//Console.WriteLine(car1.numberOfCars);
//Console.WriteLine(car2.numberOfCars);
Console.WriteLine(Car.numberOfCars);
Car.StartRace();
//eg: Math class;;;;;
#endregion