using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_DZ_Algo_and_Struct
{
    class VerificationClassDZ1_1
    {
        public string numberForCheck { get; set; }
        public string expectedValue { get; set; }
        public VerificationClassDZ1_1(string value, string ExpectedValue)
        {
            numberForCheck = value;
            expectedValue = ExpectedValue;
        }
        public VerificationClassDZ1_1(string ExpectedValue)
        {
            expectedValue = ExpectedValue;
        }
    }
}
