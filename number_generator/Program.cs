using System;

namespace number_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generate = new Random();

            //Generates random number between 1-10.
            int computer_generate = generate.Next(1, 11);

            /*
             * This part of code is just for "design" purposes.
             * Feel free to edit it however you want.
            */
            Console.WriteLine(@"Welcome to my ""Guess the number"" game made in C#.");
            Console.WriteLine("You have to guess a randomly generated number between 1-10.");
            //This part freezes the code for certain amount of time.
            System.Threading.Thread.Sleep(3000);
            //Clears the previous screen output.
            Console.Clear();
            Console.WriteLine("Starting the game.");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            bool win = false;
            do
            {
                //This part asks for user input as a string and then converts it to int.
                Console.Write("Please pick one number between 1-10 : ");
                string guess = Console.ReadLine();
                int num_guess = Convert.ToInt32(guess);

                /*This part checkes multiple conditions.
                 * If a input number is the same as computer generate then you win.
                 * If the input number is higher then the computer generated one you have to try lower input again.
                 * If the input number is lower then the computer generated one you have to try higher input again.
                 */

                if (num_guess == computer_generate)
                {
                    Console.WriteLine($"Correct, the winning number was {computer_generate}.");
                    System.Threading.Thread.Sleep(1500);

                    /*Since the user guessed the right number we 
                     * need to change the state of bool "win" to true so the game stops.*/

                    win = true;
                }
                else if (num_guess > computer_generate)
                {
                    Console.Write($"Your number {num_guess} is higher then what the computer generated.\n\n");
                }
                else if (num_guess < computer_generate)
                {
                    Console.Write($"Your number {num_guess} is lower then what the computer generated, try again.\n\n");
                }
            } while (win == false);
        }
    }
}
