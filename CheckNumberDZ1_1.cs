using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_DZ_Algo_and_Struct
{
    /*Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
1. Реализовать в виде консольного приложения.
2. Алгоритм реализовать в отдельном классе согласно блок-схеме.
3. Написать проверочный код (один положительный, один отрицательный сценарий) в отдельной функции и вызывать его при запуске.
4. Код выложить на GitHub.
                                    _____________
                                   |             |
                                   |   начало    |
                                   |_____________|
                                          |
                                          |                                         
                                     ____ ↓_______
                                    /            /
                                   /   number   /
                                  /____________/
                                          |
                                          |
                                    ______↓_______      
                                   |              |
                                   |  d=0   i=2   |
                                   |______________|
                                          |
                                          ↓                                                     
                                       __/\__
                                    __/      \__                            
            |--------------------->/  i<number  \--------no---------------------------|
            |                      \__        __/                                     |
            |                         \__  __/                                        |
            |                            \/                                           |
            |                             |                                           |
            |                             |yes                                        |
            |                             ↓                                           |
            |                          __/\__                       _____________     |
            |                       __/      \__                   |//количество |    |      
            |                      /number%i==0 \----yes---------->|   делений   |    |
            |                      \__        __/                  |____d++______|    |
            |                         \__  __/                           |            |
            |                            \/                              |            |
            |                             |                              |           no
            |                             |no                            |            |
            |                       ______↓______                        |            |
            |                      |//увеличить  |                       |            |
            |----------------------|сравниваемое |<----------------------|            |
                                   |____i++______|                                    |
                                           ___________________________________________|
                                          |
                                          ↓
        _____________                  __/\__                  _____________
       |   number    |              __/      \__              |   number    | 
       | не простое  |<-----no-----/   d = 0    \----yes----->|   простое   |      
       |        _____|             \__        __/             |        _____|
       |    ___/                      \__  __/                |    ___/
        \__/ |                           \/                    \__/ |
             |                                                      |
             |                      _____________                   |
             |                     |             |                  |
             |-------------------->|    конец    |<-----------------|
                                   |_____________|

*/

    internal class CheckNumberDZ1_1 : InterfaceDZ
    {
        /// <summary>
        /// Код, который нужно ввести для запуска этого задания
        /// </summary>
        public string Name => "1";
        /// <summary>
        /// Описание задания
        /// </summary>
        public string Description => "  1.1 Алгоритм проверки, простое число или нет";
        /// <summary>
        /// Проверка алгоритма
        /// </summary>
        public void Verification()
        {
            int vibor;
            VerificationClassDZ1_1[] verificationValues = new VerificationClassDZ1_1[5];
            verificationValues = FillingArray(verificationValues);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите 1 для запуска алгоритма. Введите 2 для проверки алгоритма");       //как-бы меню, из двух вариантов;
            Console.ResetColor();

            vibor:
            vibor = int.Parse(Console.ReadLine());                                                        //обрабатываем корректность ввода;
            if (vibor == 1 || vibor == 2)                                                                 //если пользователь ввел 1 или 2;
                switch (vibor)                                                                            //то, попадаем в блок, который перенаправляет нас в ту часть кода, куда мы сделали выбор;
                {                                                                                         //1 - вводим сами число, используя метод PrimeOrNot класса ChekNumber проверяем его и выводим результат;
                    case 1:
                        goto verification_number;
                    case 2:
                        goto check;
                }

            else                                                                                          //сюда мы попадаем, если пользователь в vibor ввел не 1 или 2;
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не корректный ввод попробуйте еще раз ");
                Console.ResetColor();
                goto vibor;
            }

            verification_number:                                                //тут мы, если vibor = 1;

            Console.WriteLine("Введите любое целое число\n");                   //просим ввести число;
            int numb = int.Parse(Console.ReadLine());                           //парсим число в переменную numb;
            string result = PrimeOrNot(numb);                                   //дальше эта numb залетает в класс CheckNumberDZ1_1, обрабатывается там методом PrimeOrNot и вылетает уже;
            Console.WriteLine($"Введенное число - {result}");                   //ответ в виде переменной result. Эту result мы выводи в консоль;
            Console.ReadKey();

            {                                                                   //сворачиваем программу. это нужно, чтоб не выполнялось меню 2, если уже выбрали 1;
                return;
            }

            check:                                                              //тут мы, если выбрали 2 vibor;
            Tests(verificationValues);
            Console.ReadKey();


        }

        /// <summary>
        /// Сам алгоритм из блок-схемы
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string PrimeOrNot(int number)
        {
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
            {
                return "простое число";
            }
            else
                return "не простое число";
        }
        /// <summary>
        /// Заполнение массива значениями для тестов
        /// </summary>
        /// <param name="verificationValues"></param>
        /// <returns></returns>
        static public VerificationClassDZ1_1[] FillingArray(VerificationClassDZ1_1[] verificationValues)
        {
            verificationValues[0] = new VerificationClassDZ1_1("3", "простое число");
            verificationValues[1] = new VerificationClassDZ1_1("1999", "простое число");
            verificationValues[2] = new VerificationClassDZ1_1("25", "не простое число");
            verificationValues[3] = new VerificationClassDZ1_1("-7", "Отрицательное число");
            verificationValues[4] = new VerificationClassDZ1_1("'просто текст'", "Неверный тип данных");

            return verificationValues;
        }

        /// <summary>
        /// Тестирование
        /// </summary>
        /// <param name="verificationValues"></param>
        static public void Tests(VerificationClassDZ1_1[] verificationValues)
        {
            var cn = new CheckNumberDZ1_1();
            for (int i = 0; i < verificationValues.Length; i++)
            {
                if (int.TryParse(verificationValues[i].numberForCheck, out int result))
                {
                    if (result > 0)
                        Console.WriteLine($"Результат проверки для значения {verificationValues[i].numberForCheck} является {cn.PrimeOrNot(result)}. Ожидаемое значение: {verificationValues[i].expectedValue}");
                    else
                        Console.WriteLine($"Результат проверки для значения {verificationValues[i].numberForCheck} является \"отрицательное число\". Ожидаемое значение: {verificationValues[i].expectedValue}");
                }
                else
                    Console.WriteLine($"Результат проверки для значения { verificationValues[i].numberForCheck} является \"Неверный тип данных\". Ожидаемое значение: {verificationValues[i].expectedValue}");
            }
        }
    }
}
