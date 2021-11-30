using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion15Test
{
    public class Calculator
    {
        public int amountOfCalculations = 0;

        public int Add(int number1, int number2)
        {
            amountOfCalculations++;
            return number1 + number2;
        }
    }
}
