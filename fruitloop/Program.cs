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

            WordValue = Console.ReadLine();

            word = (WordValue.Length);


            for (int i = 0; i < word+1; i++)
            {
                Console.WriteLine(i);
            }


            


        }
    }
}
