using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_DZ_Algo_and_Struct
{
    internal class AsymptoticDZ1_2 : InterfaceDZ
    {
        /// <summary>
        /// Код, который нужно ввести для запуска этого задания
        /// </summary>
        public string Name => "2";
        /// <summary>
        /// Описание задания
        /// </summary>
        public string Description => "  1.2 Расчет асимтотической сложности алгоритма";
        /// <summary>
        /// Проверка алгоритма
        /// </summary>
        public void Verification()
        {
            Console.WriteLine("Асимптотическая сложность: 2 + 3N^3");
        }
       
            private static int StrangeSum(int[] inputArray)
            {
                int sum = 0; // O(1)
                for (int i = 0; i < inputArray.Length; i++) // O(N)
                {
                    for (int j = 0; j < inputArray.Length; j++) // O(N)
                    {
                        for (int k = 0; k < inputArray.Length; k++) // O(N)
                        {
                            int y = 0;   // O(1)
                            if (j != 0)  // O(1)
                            {
                                y = k / j;
                            }
                            sum += inputArray[i] + i + k + j + y;
                        }
                    }
                }
                return sum; // O(1)
                            // Асимптотическая сложность: O(1 + (N * N * ((1 + 1 + 1) * N) + 1) = 2 + 3N^3
            }
        
    }
}
