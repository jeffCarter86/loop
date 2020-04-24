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


            for (int i = 0; i < word; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            Console.WriteLine("Enter Another word");
            foreach (char c in WordValue)
            {
                Console.WriteLine(c);
            }
            for (int i = 0; i < WordValue.Length; i++)
            {
                Console.WriteLine(WordValue[i]);
            }




        }
    }
}
