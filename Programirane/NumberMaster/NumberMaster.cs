using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberMaster
{



    public class NumberMaster
    {

        public int Multiplier { get; set; } = 1;
        
        public int GetSumOfNumbers(int a, int b)
        {
            int result = Multiplier*(a + b);
            return result;
        }

        public static void PrintOddNumbersBetween(int min, int max)
        {
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintEvenNumbersBetween(int min, int max)
        {
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int[] MakeArrayOfNumbersBetween(int num1, int num2)
        {
            int elementsCount = num2 - num1 - 1; //5-1-1=3
            int[] result = new int[elementsCount];
            for (int i = 0; i < elementsCount; i++)
            {
                result[i] = num1 + i + 1;
            }
            return result;

        }


        public static int GetSumOfAllNumbersBetween(int min, int max)
        {
            int result = 0;
            for (int i = min + 1; i < max; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
