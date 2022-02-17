using System;

namespace MathLibrary
{
    public class MathHalper
    {
        public static int Max(int a, int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
        }

        public static int Max(int[] array)
        {
            //return array.Max();
            if (array != null && array.Length > 0)
            {
                int maxValue = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (maxValue < array[i])
                    {
                        maxValue = array[i];
                    }
                }

                return maxValue;
            }

            throw new ArgumentException();
        }
    }
}