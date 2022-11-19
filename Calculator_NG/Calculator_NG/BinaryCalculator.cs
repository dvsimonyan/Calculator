using System;

namespace Calculator_NG
{
    internal class BinaryCalculator : CalculatorInterface
    {

        public int xor(int Number1, int Number2)
        {
            int[] arrX = toBinary(Number1);
            int[] arrY = toBinary(Number2);
            int[] result = new int[32];
            for (int i = 0; i < arrX.Length; i++)
            {
                if (arrX[i] != arrY[i])
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            int value = toDecimal(result);
            return value;
        }

        public int or(int Number1, int Number2)
        {
            int[] arrX = toBinary(Number1);
            int[] arrY = toBinary(Number2);
            int[] result = new int[32];
            for (int i = 0; i < arrX.Length; i++)
            {

                if (arrX[i] == 0 && arrY[i] == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = 1;
                }
            }
            int value = toDecimal(result);
            return value;
        }

        public int and(int Number1, int Number2)
        {
            int[] arrX = toBinary(Number1);
            int[] arrY = toBinary(Number2);
            int[] result = new int[32];
            for (int i = 0; i < arrX.Length; i++)
            {

                if (arrX[i] == 1 && arrY[i] == 1)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            int value = toDecimal(result);
            return value;
        }
        public double multi(int Number1, int Number2)
        {
            int[] arrX = toBinary(Number1);
            int[] arrY = toBinary(Number2);
            int[] result = new int[32];


            for (int i = arrX.Length - 1; i >= 0; i--)
            {

                if (arrY[i] == 1)
                {
                    int temp = 0;

                    for (int j = arrY.Length - 1; j >= 0 && j - (31 - i) >= 0; j--)
                    {

                        int values = arrX[j] + result[j - (31 - i)] + temp;

                        if (values < 2)
                        {
                            result[j - (31 - i)] = values;
                            temp = 0;
                        }
                        else
                        {
                            result[j - (31 - i)] = values & 1;

                            temp = 1;
                        }


                    }
                }

            }


            int value = toDecimal(result);
            return value;
        }


        public double sum(int Number1, int Number2)
        {
            int[] arrX = toBinary(Number1);
            int[] arrY = toBinary(Number2);
            int[] result = new int[32];

            int temp = 0;
            for (int i = arrX.Length - 1; i >= 0; i--)
            {
                int sums = arrX[i] + arrY[i] + temp;
                if (sums < 2)
                {
                    result[i] = sums;
                    temp = 0;
                }
                else
                {
                    result[i] = sums & 1;

                    temp = 1;
                }
                //            } else if (sums == 2) {
                //                result[i] = 0;
                //                temp = 1;
                //            } else if (sums == 3) {
                //                result[i] = 1;
                //                temp = 1;
                //            }
            }
            int value = toDecimal(result);
            return value;
        }

        public double deduction(int Number1, int Number2)
        {
            double value = sum(Number1, -Number2);
            return value;
        }


        private int[] toBinary(int value)
        {
            int[] arr = new int[32];
            for (int i = arr.Length - 1; i >= 0; i--)
            {

                arr[i] = value & 1;
                value = value >> 1;
            }

            return arr;
        }

        private int toDecimal(int[] arr)
        {
            int value = 0;
            bool isNegative = (arr[0] == 1);
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                if (isNegative)
                {
                    if (arr[i] == 0)
                    {
                        value += (1 << (31 - i));

                    }


                }
                else
                {
                    if (arr[i] == 1)
                    {
                        value += (1 << (31 - i));

                    }
                }
            }
            if (isNegative)
            {
                value++;
                value = -value;

            }


            return value;


        }

    }

}
