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
            WordValue = Console.ReadLine(); //accepts user input for a value

            word = (WordValue.Length);      /// turns string into a interger

           foreach (char c in WordValue)
            {
                Console.WriteLine(c); //alternate to spell word invidual letters
            }
            for (int i = 0; i < WordValue.Length; i++) //spell individual letters of word
            {
                Console.WriteLine(WordValue[i]);
            }
            for (int i = 0; i < word; i++) // counts each letter and spaces of a set of words or word
            {
                Console.WriteLine(i);
            }
            for (int i=1; i<WordValue.Length; i+=2) // displays every other letter of input
            {
                Console.WriteLine(WordValue[i]);
            }

            if (word % 3 ==0) //sees if a word or phrase is divisible completely by 3
            {
           for  (int i = 0; i < WordValue.Length; i += 3) //if divisible by 3 prints approppiate letter
                {
                    Console.WriteLine(WordValue[i]); 
                }
            }
            else
            {
                Console.WriteLine("Not divisible by 3"); //if not does this
            }




        }
    }
}
