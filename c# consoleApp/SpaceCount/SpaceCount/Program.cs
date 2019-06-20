using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Kamran en bomba muellimdir";
            string count = SpaceCount(sentence);
            Console.WriteLine(count);
        }

        static string SpaceCount (string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    count++;
                }
            }
            return "Bu cumlada "+ count + " bosluq var";
        }
    }
}
