using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3_Pizza_Time
{
    public delegate int IntDelegate(int value);
    class SuperArray
    {

        public static void UpdateArray<T>(T[] array, Func<T, T> func)
        {
            if (func != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = func.Invoke(array[i]);
                }
            }

        }

        public static int SquareInt(int value)
        {
            return value * value;
        }

        public static double SquareDouble(double value)
        {
            return value * value;
        }

        public static int Sum(int[] array)
        {
            int arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arraySum += array[i];
            }

            return arraySum;
        }

        public static double Sum(double[] array)
        {
            double arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arraySum += array[i];
            }

            return arraySum;
        }

        public static double Average(int[] array)
        {
            int arraySum = Sum(array);
            int count = array.Length;
            double arrayAverage = arraySum / count;

            return arrayAverage;
        }

        public static double Average(double[] array)
        {
            double arraySum = Sum(array);
            int count = array.Length;
            double arrayAverage = arraySum / count;

            return arrayAverage;
        }

        public static int Count(int[] array)
        {
            
            var elem = array.GroupBy(x => x).OrderByDescending(x => x.Count()).First();

            return elem.Key; 
            
        }

        public static double Count(double[] array)
        {

            var elem = array.GroupBy(x => x).OrderByDescending(x => x.Count()).First();

            return elem.Key;
        }



    }
}
