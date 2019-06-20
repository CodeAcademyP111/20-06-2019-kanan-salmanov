using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Kamran";
            CountLetters(word);
        }

        //void method yazmagimi istemisdiz. 
        static void CountLetters(string letter)
        {
            int count = 1;

            for (int i = 0; i < letter.Length; i++)
            {
                for (int j = 1; j < letter.Length; j++)
                {
                    if ((letter[i] == letter[j]) && (i != j))
                    {
                        count++;
                    }

                }
                Console.WriteLine(letter[i] + " - " + count+" eded");
                count = 1;
            }
            Console.ReadKey();
        }
    }
}
