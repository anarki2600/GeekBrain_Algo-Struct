using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_DZ_Algo_and_Struct
{
    /// <summary>
    /// Общий интерфейс занятий
    /// </summary>
    interface InterfaceDZ
    {
        /// <summary>
        /// "Код" для запуска занятия
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Описание занятия
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Вывод тестовых данных для проверки кода занятия
        /// </summary>
        void Verification();
    }
}
