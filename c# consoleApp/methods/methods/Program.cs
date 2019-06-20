using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 13, 1};
            float result = average(arr);
            Console.WriteLine(result);
        }


        static float average(int[] num)
        {
            float result = 0F;

            //// 1.foreach ile
            //int count = 0;
            //foreach(var item in num)
            //{
            //    result += item;
            //    count++;
            //}
            //return result/count;

            //// 2.For ile
            for(int i = 0; i < num.Length; i++)
            {
                result += num[i];
            }
            return result / num.Length;
        }
    }
}
