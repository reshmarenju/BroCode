using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroCode
{
    public class Car
    {
        public static int numberOfCars;
        string model;
        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("The Race starts now");
        }
    }
}
