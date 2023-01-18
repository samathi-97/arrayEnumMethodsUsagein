using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayEnumMethodsUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Implementation to find smallest value");
            int[] arr1 = new int[] { 10, 45, 78, 32, 12, 45, 78, 95, 63, 47, 51 };
            int currentMinimumValue = Int32.MaxValue;
            //find min value
            for(int index = 0 ; index < arr1.Length; index++) 
            {
             if (arr1[index] < currentMinimumValue)
                {
                 currentMinimumValue= arr1[index];
                }
            }
            Console.WriteLine(currentMinimumValue.ToString());
        }
    }
}
