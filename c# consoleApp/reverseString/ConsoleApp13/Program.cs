using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a =  "edaletsiz dunya";
            string result = makeString(a);
            Console.WriteLine(result);  Console.ReadKey();  
        }
        
        static string makeString(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
                {
                    result+=str[i];
                }
            return result;
        }
            
    }
           
}
