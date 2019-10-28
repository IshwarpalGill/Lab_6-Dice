using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true, repeat = true;

            Console.Write("Welcome to Grand Circus Casino! ");

            while (again)
            {
                Console.Write("Please enter the dice sides: ");
                try
                {
                    int sides = int.Parse(Console.ReadLine());//inputting sides

                    //uses sides as input and plugs it into Dice method 
                    Console.WriteLine(Dice(sides));
                    Console.WriteLine(Dice(sides));
                    Console.WriteLine("Would you like to play again? [y/n]: ");

                    while (repeat)
                    {
                        string ans = Console.ReadLine().ToLower();
                        
                        if (ans == "n")
                        {
                            Console.WriteLine("Thanks for playing! Goodbye!");
                            repeat = false;
                            again = false;
                            
                        }
                        else if (ans == "y")
                        {
                            repeat = false;
                            again = true;
                            
                        }
                        else
                        {
                            Console.WriteLine("I do not understand. Please enter y or n.");
                            //ans = Console.ReadLine();
                            repeat = true;
                            again = false;
                            
                        }
                        
                    }

                }
                catch(FormatException)
                {
                    Console.WriteLine("Input is not a number. Please try again.");
                    again = true;
                }
                catch(OverflowException )
                {
                    Console.WriteLine("Your number is too large. Please try again");
                }
                repeat = true;
                
            }
        }

        public static int Dice(int input)
        {
            //Create random number generator
            Random r = new Random();
            int rand = r.Next(0, input);
            return rand;
        }
    }
}
