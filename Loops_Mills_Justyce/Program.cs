using System;

namespace Loops_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a sentence");
            string response = Console.ReadLine();
            Console.WriteLine($"the sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            Console.WriteLine("input a whole number");
            string response2 = Console.ReadLine();
            Console.WriteLine($"the sum of the individual digits you inputed {response2} is {SumOfDigits(response2)}");
        }
        
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                    numberOfSpaces++;
            }
            return numberOfSpaces;
        }

        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
