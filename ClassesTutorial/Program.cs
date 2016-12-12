using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        public static object mercedes { get; private set; }

        static void Main(string[] args)
        {
            
            Mercedes mercedes = new Mercedes();
            Console.WriteLine("Mercedes is " +  mercedes.Description);
            Console.WriteLine("Mercedes costs " +  mercedes.Price);
            //AbstractCar aCar = new AbstractCar();
            EngineStruct engine = new EngineStruct();
            Icar car = new Mercedes();
            AbstractCar car2 = new Mercedes();
            mercedes.StartEngine();
            //mercedes.ShowRemainingNoOfKm(50,6.5);
            double result = mercedes.ShowRemainingNoOfKm(10,5.2);
            Console.WriteLine(result);
            int result2 = mercedes.StarEngine(15);
            double res3 = mercedes.CalculateConsumption(2, 30);
            Console.WriteLine("Consumption is {0}", res3);
            Console.WriteLine("The car is starting in {0}", result2);
            Console.WriteLine("This is my first c# project!");
            Console.ReadKey();
        }
    }
}
