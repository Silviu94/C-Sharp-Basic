using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            //AbstractCar aCar = new AbstractCar();
            EngineStruct engine = new EngineStruct();
            Console.WriteLine("This is my first c# project!");
            Console.ReadKey();
        }
    }
}
