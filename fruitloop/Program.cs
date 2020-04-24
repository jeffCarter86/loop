using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int word;
            string WordValue;
            Console.WriteLine("Enter word here: ");
            WordValue = Console.ReadLine();

            word = (WordValue.Length);

           foreach (char c in WordValue)
            {
                Console.WriteLine(c); //alternate to spell world invidual letters
            }
            for (int i = 0; i < WordValue.Length; i++)
            {
                Console.WriteLine(WordValue[i]);
            }
            for (int i = 0; i < word; i++)
            {
                Console.WriteLine(i);
            }
            for (int i=1; i<WordValue.Length; i+=2)
            {
                Console.WriteLine(WordValue[i]);
            }

            if (word % 3 ==0)
            {
           for  (int i = 0; i < WordValue.Length; i += 3)
                {
                    Console.WriteLine(WordValue[i]);
                }
            }
            else
            {
                Console.WriteLine("Not divisible by 3");
            }




        }
    }
}
