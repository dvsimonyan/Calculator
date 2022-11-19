using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_NG
{
    interface CalculatorInterface
    {
        double sum(int Number1, int Number2);
        double deduction(int Number1, int Number2);
        double multi(int Number1, int Number2);
    }
}
