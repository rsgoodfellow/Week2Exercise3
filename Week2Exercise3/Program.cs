using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vowels = 0; //declares the variable vowels and intializes it as 0

            Console.Write("Enter a string: "); //displays text asking for user input
            string input = Console.ReadLine(); //saves user input a string variable called input

            for (int i = 0; i < input.Length; i++) //a loop that repeats as long as the interation number is less than the input strings length. After the iteration finishes it increases by 1
            {
                switch(input[i]) //a switch loop that helps determine if the current character is a vowel or not
                {
                    case 'a': //case if the current character is an a
                        vowels = vowels + 1; //adds a 1 to the current vowel count
                        break; //breaks from switch loop
                    case 'e': //case if the current character is an e
                        vowels = vowels + 1; //adds a 1 to the current vowel count
                        break; //breaks from switch loop
                    case 'i': //case if the current character is an i
                        vowels = vowels + 1; //adds a 1 to the current vowel count
                        break; //breaks from switch loop
                    case 'o': //case if the current character is an o
                        vowels = vowels + 1; //adds a 1 to the current vowel count
                        break; //breaks from switch loop
                    case 'u': //case if the current character is an u
                        vowels = vowels + 1; //adds a 1 to the current vowel count
                        break; //breaks from switch loop
                    default: //if the current letter does not equal any vowel, it is not added to the vowel count
                        break; //breaks from switch loop
                }
            }

            Console.WriteLine("The number of vowels in the string is: " +  vowels); //displays the total amount of vowels in the string

            Console.ReadLine(); //lets the user read program
        }
    }
}
