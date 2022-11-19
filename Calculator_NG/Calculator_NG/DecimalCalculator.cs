using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_NG
{
    internal class DecimalCalculator : CalculatorInterface
    {
        public double sum(int Number1, int Number2)
        {
            return Number1 + Number2;
        }
        public double sum(int Number1, int Number2, int Number3)
        {
            return Number1 + Number2 + Number3;
        }

        public double deduction(int Number1, int Number2)
        {
            return sum(Number1, -Number2);
        }

        public double divide(int Number1, int Number2)
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException();
            }

            return Number1 / Number2;
        }


        public double multi(int Number1, int Number2)
        {
            return Number1 * Number2;
        }

        public double IncreaseDegrees(int Number, int count)
        {
            double result = Number;
            if (count < 0)
            {
                count = -count;
                for (int i = 0; i < count - 1; i++)
                {
                    result *= Number;
                }
                return 1 / result;

            }
            else if (count > 0)
            {
                for (int i = 0; i < count - 1; i++)
                {

                    result *= Number;
                }
                return result;
            }
            else
            {
                return 1;
            }
        }

        public double percent(double Number)
        {
            return Number / 100;
        }

        public double SquareRoots(int Number)
        {

            if (Number == 1)
            {
                return 1;
            }
            else if (Number <= 0)
            {
                Console.WriteLine("err");
                return -1;
            }
            for (int i = 0; i <= Number / 2; i++)
            {
                if (i * i == Number)
                {
                    return i;

                }

            }
            return -1;
        }



    }
}
