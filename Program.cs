using System;

namespace MyDistanceMove
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveAndSpreed moveAndSpreed = new MoveAndSpreed();

            string sharp = "######################################################################################"; // ### lines.

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"##### MyDistanceMove #####");
                Console.WriteLine("Indicate the distance you need, then indicate how fast you will travel [kilometers] : ");
                Console.WriteLine(sharp);
                Console.WriteLine($"You have traveled the distance for {Math.Round(moveAndSpreed.Move(0M, 0M), 2)} hours / minutes");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine(sharp);
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("[Error] Empty values");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine(sharp);
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[Error] Zero division attempt");
            }
            catch(FormatException)
            {
                Console.WriteLine(sharp);
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("[Error] Invalid argument specified, enter an integer");
            }
            catch(OverflowException)
            {
                Console.WriteLine(sharp);
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[Error] Non-correct number entered");
            }
            finally
            {
                Console.WriteLine(sharp);
                Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine("[Completed] MyDistanceMove Robot Offer Completed");
            }

            Console.ReadKey();
        }
    }
}
