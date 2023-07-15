// See https://aka.ms/new-console-template for more information



#region Static
//STATIC - modifier used to declare static member, which belongs to the class itself rather than to any specific objects 
using BroCode;

Car car1= new Car("Mustang");
Car car2 = new Car("Corvette");
Car car3 = new Car("Lambo");
//Console.WriteLine(car1.numberOfCars);
//Console.WriteLine(car2.numberOfCars);
Console.WriteLine(Car.numberOfCars);
Car.StartRace();
//eg: Math class;;;;;
#endregion
#region Array Of Objects
Car[] garage = new Car[3];
//Car[] garage= new Car[] { car1, car2 };
garage[0] = car1;
garage[1] = car2;
garage[2] = car3;

foreach (Car car in garage)
{
	Console.WriteLine(car.model); 
}
#endregion