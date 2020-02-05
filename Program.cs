using System;
using System.Collections.Generic;

namespace igpay_atinlay
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] splitInput;

            Console.WriteLine("Welcome to the Pig Latin Translator");
            
            

            do
            {
                Console.WriteLine();
                Console.Write("Enter a line to be translated: ");
                input = Console.ReadLine().ToLower();
                splitInput = input.Split(" ");

                foreach (string str in splitInput)
                {
                    if ("aeiou".Contains(str[0]))
                    {
                        Console.Write(PrintVowel(str) + " ");
                    }
                    else
                    {
                        Console.Write(PrintConsonant(str) + " ");
                    }
                } 
            } while (true);
            

            
            
            /*foreach (char c in input)
            {
                if ("QWERTYUIOPASDFGHJKLZXCVBNM".Contains(c))
                {
                    caseQ.Enqueue(c);
                }
                else
                {
                    caseQ.Enqueue('0');
                }
            }*/

        }

        private static string PrintConsonant(string str)
        {
            int counter = 0;
            string consonants = "qwrtypsdfghjklzxcvbnm";
            string output = "";
            Queue<char> consonantQ = new Queue<char>();


            if (str.Equals("by"))
            {
                output += "yb";
            }
            else if (str.Equals("my"))
            {
                output += "ym";
            }
            else
            {
                while (consonants.Contains(str[counter]))
                {
                    consonantQ.Enqueue(str[counter]);
                    counter++;
                }
                for (int i = 0; i < str.Length - counter; i++)
                {
                    output += str[i + counter];
                }
                for (int i = 0; i < counter; i++)
                {
                    output += str[i];
                } 
            }
            return output + "ay"; 
            
            
        }

        private static string PrintVowel(string str)
        {
            return str + "way";
        }
    }
}
