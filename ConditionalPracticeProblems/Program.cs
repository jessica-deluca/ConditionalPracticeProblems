using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter an integer.");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a second integer.");
            //int number2 = int.Parse(Console.ReadLine());

            //if (number1 == number2)
            //{
            //    Console.WriteLine("The numbers " + number1 + " and " + number2 + " are the same number.");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers " + number1 + " and " + number2 + " are not equal to each other.");
            //}

            //Console.WriteLine("Enter a whole number.");
            //int numberEntered = int.Parse(Console.ReadLine());

            //if (numberEntered % 2 == 0)
            ///*modulus operator finds remainder
            // * if numberEntered divided by 2 has a remainder, the remainder does not equal 0 so the numberEntered is an odd number
            // * if numberEntered divided by 2 does not have a remainder, the remainder is 0 so the numberEntered is even*/
            //{
            //    Console.WriteLine(numberEntered + " is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine(numberEntered + " is an old number.");
            //}

            //Console.WriteLine("Enter either a positive or negative whole number.");
            //int numberEntered = int.Parse(Console.ReadLine());

            //if (numberEntered > 0)
            //{
            //    Console.WriteLine("The number " + numberEntered + " is a positive number.");
            //}
            //else if (numberEntered < 0)
            //{
            //    Console.WriteLine("The number " + numberEntered + " is a negative number.");
            //}
            //else
            //{
            //    Console.WriteLine("0 is neither a positive or negative number.");
            //}

            //Console.WriteLine("Enter a letter.");
            //char letterEntered = char.Parse(Console.ReadLine());

            //switch(letterEntered)
            //{
            //    case 'a': //user can enter uppercase (A) or lowercase (a) and they still get correct response
            //        Console.WriteLine("The letter " + letterEntered + " is a vowel.");
            //        break;
            //    case 'e':
            //        Console.WriteLine("The letter " + letterEntered + " is a vowel.");
            //        break;
            //    case 'i':
            //        Console.WriteLine("The letter " + letterEntered + " is a vowel.");
            //        break;
            //    case 'o':
            //        Console.WriteLine("The letter " + letterEntered + " is a vowel.");
            //        break;
            //    case 'u':
            //        Console.WriteLine("The letter " + letterEntered + " is a vowel.");
            //        break;
            //    default:
            //        Console.WriteLine("The letter " + letterEntered + " is a consonant.");
            //        break;
            //}

            //Console.WriteLine("Enter an integer.");
            //int integer1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a second integer.");
            //int integer2 = int.Parse(Console.ReadLine());

            //if (integer1 > integer2)
            //{
            //    Console.WriteLine(integer1 + " is the biggest number.");
            //}
            //else
            //{
            //    Console.WriteLine(integer2 + " is the biggest number.");
            //}

            //Console.WriteLine("Enter an integer.");
            //int integer1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a second integer.");
            //int integer2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a third integer.");
            //int integer3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a fourth integer.");
            //int integer4 = int.Parse(Console.ReadLine());

            //float sum = integer1 + integer2 + integer3 + integer4;

            //Console.WriteLine(sum / 4 + " is the mean of your integers.");

            Console.WriteLine("Enter a number between one and nine.");

            int fizzNumber = int.Parse(Console.ReadLine()); //user enters fizzbuzz number

            if (fizzNumber < 1 || fizzNumber > 9) //check if user entered number between 1 and 9
            {
                Console.WriteLine("Please try again. (Be sure the numbers you entered are between one and nine.)"); //response if number entered incorrectly
            }
            else // consider entering return; here instead of else
            {
                Console.WriteLine("Enter a second number between one and nine."); //response if number entered correctly
            }

            int buzzNumber = int.Parse(Console.ReadLine());

            if (buzzNumber < 1 || buzzNumber > 9)
            {
                Console.WriteLine("Please try again. (Be sure the numbers you entered are between one and nine.)");
            }
            else // consider entering return; here instead of else
            {
                Console.WriteLine("Enter a test number.");
            }
            
            int testNumber = int.Parse(Console.ReadLine());

            if (testNumber % fizzNumber == 0 && testNumber % buzzNumber == 0) // if test number is a multiple of fizz and buzz
            {
                Console.WriteLine("FizzBuzz!");
            }
            else if (testNumber % fizzNumber == 0) // if test number is a multiple of fizz
            {
                Console.WriteLine("Fizz!");
            }
            else if (testNumber % buzzNumber == 0) // if test number is a multiple of buzz
            {
                Console.WriteLine("Buzz!");
            }
            else if (testNumber % fizzNumber != 0 && testNumber % buzzNumber != 0) // if test number is NOT a multiple of buzz and fizz
            {
                Console.WriteLine(testNumber);
            }

        }
        }
}
