using System;
using System.Collections.Generic;

namespace GB_DZ_Algo_and_Struct
{
    class Program
    {
        static List<InterfaceDZ> _interfaceDZ = new List<InterfaceDZ>()
        {            
            new CheckNumberDZ1_1(), 
            new AsymptoticDZ1_2(),
            new FibonacciDZ1_3()
        };
       
        static void Main(string[] args)
        {
            int les;

            Console.WriteLine($"Для запуска задания, введите его код. Доступные задания: ");
            foreach (InterfaceDZ interfaceDZ in _interfaceDZ)
            {
                Console.WriteLine($"код:{interfaceDZ.Name} ({interfaceDZ.Description})");                         
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("?");
            Console.ResetColor();

            les = int.Parse(Console.ReadLine());

            InterfaceDZ[] less = new InterfaceDZ[3];          
            less[0] = new CheckNumberDZ1_1();
            less[1] = new AsymptoticDZ1_2();
            less[2] = new FibonacciDZ1_3();


            switch (les)
            {
                case 1:
                    less[0].Verification();
                    break;
                case 2:
                    less[1].Verification();
                    break;
                case 3:
                    less[2].Verification();
                    break;
            }

            Console.ReadLine();

        }
       
    }
}
