using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter max number: ");
            int maxNum = Convert.ToInt32(Console.ReadLine());

            Random rd = new Random();
            int rand_num = rd.Next(0, maxNum);

            // This line is considered to guess how all of these goes!
            Console.WriteLine(rand_num);

            int ansNum = 1;
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (rand_num != ansNum && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guessing number: ");
                    ansNum = Convert.ToInt32(Console.ReadLine());

                    if (ansNum > rand_num)
                    {
                        Console.WriteLine("Your number is less then a guessing number");
                    }
                    else if (ansNum < rand_num)
                    {
                        Console.WriteLine("Your number is more than a guessing number");
                    }

                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
                   
            }
            if (outOfGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("You win!");
            }

            Console.ReadLine();

        }        
    }
}
