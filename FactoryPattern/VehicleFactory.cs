using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {

        public static void GetVehicle()
        {
            Console.WriteLine("Let's make a new vehicle! Give me a tire count for this new vehicle.");
            var tireCount = Console.ReadLine();
            bool exitUser;
            do {
                exitUser = true;
                switch (tireCount)
                {
                    case "2":
                        IVehicle motercycle = new Motercycle();
                        Console.WriteLine("Okay, Motercycle!");
                        motercycle.Drive();
                        break;

                    case "4":
                        IVehicle car = new Car();
                        Console.WriteLine("Okay, Car!");
                        car.Drive();
                        break;
                    case "6":
                        IVehicle bigRig = new Bigrig();
                        Console.WriteLine("Okay, BigRig!");
                        bigRig.Drive();
                        break;
                    default:
                        Console.WriteLine($"I'm sorry but that input doesn't work. Try giving me a 2, 4, or 6 to work with.");
                        tireCount = Console.ReadLine();
                        exitUser = false;
                        break;
                }
            }while(exitUser == false);
        }
    }
}
