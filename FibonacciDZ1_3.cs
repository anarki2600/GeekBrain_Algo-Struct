using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_DZ_Algo_and_Struct
{
    class FibonacciDZ1_3 : InterfaceDZ
    {        
        /// <summary>
        /// Код, который нужно ввести для запуска этого задания
        /// </summary>
        public string Name => "3";
        /// <summary>
        /// Описание задания
        /// </summary>
        public string Description => "  1.3 Функция вычисления числа Фибоначчи";
        /// <summary>
        /// Проверка алгоритма
        /// </summary>       
        public void Verification()
        {
            Console.WriteLine("Введите число - кол-во элементов последовательности");
            int number = int.Parse(Console.ReadLine().ToString());

            FibonacciDZ1_3 fibo = new FibonacciDZ1_3();
            Console.WriteLine($"Число Фибоначчи с помощью рекурсии: {fibo.FindFibonacci(number - 1)}");
            Console.WriteLine($"Число Фибоначчи с помощью цикла: {fibo.FindFibonacciCicle(number)}");
        }
        //Нахождение числа Фибоначчи с помощью рекурсии
        public int FindFibonacci(int number)
        {
            if (number < 2)
                return number;
            return FindFibonacci(number - 1) + FindFibonacci(number - 2);
        }
        //Нахождение числа Фибоначчи с помощью цикла
        public int FindFibonacciCicle(int number)
        {
            int fibonacciNumber = 0;
            int secondValue = 1;
            int tmpValue;
            for (int i = 0; i < number; i++)
            {
                tmpValue = fibonacciNumber;
                fibonacciNumber = secondValue;
                secondValue += tmpValue;
            }
            return fibonacciNumber;
        }
    }
}