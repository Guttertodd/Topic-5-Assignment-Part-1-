using System.ComponentModel.Design;

namespace Topic_5_Assignment__Part_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string planet;

            //double weight;
            //Console.WriteLine("Please enter your curent earth weight:");
            //weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("I have information for the following plannets:");
            //Console.WriteLine("1. Venus    2. Mars    3. Jupiter");
            //Console.WriteLine("4. Saturn   5. Uranus  6. Neptune");
            //Console.WriteLine("Which planet are you visiting?");
            //planet = Console.ReadLine().ToLower();

            //if (planet == "1" || planet == "venus")
            //{
            //    Console.WriteLine("Your weight would be " + weight * 0.79);
            //}
            //if (planet == "2" || planet == "mars")
            //{
            //    Console.WriteLine("Your weight would be " + weight * 0.39);
            //}
            //if (planet == "3" || planet == "jupiter")
            //{
            //    Console.WriteLine("Your weight would be " + weight * 2.65);
            //}
            //if (planet == "4"|| planet == "saturn")
            //{
            //    Console.WriteLine("Your weight would be " + weight * 1.17);
            //}
            //if (planet == "5"| planet == "uranus")
            //{
            //    Console.WriteLine("Your weight would be " + weight * 1.05);
            //}
            //if (planet == "6"| planet == "neptune")
            //{
            //    Console.WriteLine("Your weight would be " + weight * 1.23);



            //int secretNumber;
            //string number;
            //secretNumber = 7;

            //Console.WriteLine("Pick a number from 1-10:");
            //number = Console.ReadLine().ToLower();

            //if (number == "1")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "2")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "3")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "4")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "5")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "6")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "7") 
            //{
            //    Console.WriteLine("Correct!!! You guessed the secret number!");
            //}
            //if (number == "8")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "9")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}
            //if (number == "10")
            //{
            //    Console.WriteLine("Incorrect... the secret number was " + secretNumber);
            //}

            string answerOne;
            Console.WriteLine("Question 1:");
            Console.WriteLine("How many people died in WW1?");
            Console.WriteLine("A. 40 Million");
            Console.WriteLine("B. 50 Million");
            Console.WriteLine("C. 35 Million");
            Console.WriteLine("D. 25 Million");
            answerOne = Console.ReadLine().ToUpper();
            if (answerOne == "A" || answerOne == "40 million")
            {
                Console.WriteLine("Correct!");
            }

            else
            {
                Console.WriteLine("Incorrect, the correct answer was A!");
            }

            string answerTwo;
            Console.WriteLine("Question 2:");
            Console.WriteLine("Soccer is the most played sport across the world!");
            Console.WriteLine("True");
            Console.WriteLine("False");
            answerTwo = Console.ReadLine().ToUpper();
            if (answerTwo == "TRUE" || answerTwo == "T")
            {
                Console.WriteLine("Correct!");
            }

            else
            {
                Console.WriteLine("Incorrect, the correct answer was true!");
            }

            string answerThree;
            Console.WriteLine("What is 12 * (18/3)");
            answerThree = Console.ReadLine();
            if (answerThree == "72")
            {
                Console.WriteLine("Correct! Seems like someone is good at math!");
            }

            else
            {
                Console.WriteLine("Incorrect, the correct answer was 72!");
            }

            string answerFour;
            Console.WriteLine("In which country is the eiffel tower located?");
            answerFour = Console.ReadLine().ToLower();
            if (answerFour == "france")
            {
                Console.WriteLine("Correct!");
            }

            else
            {
                Console.WriteLine("Incorrect, the correct answer was France!");
            }


        }
    }
}
         