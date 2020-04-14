using System;
using System.IO;
using System.Text;

namespace MyDistanceMove
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveAndSpreed moveAndSpreed = new MoveAndSpreed();

            const string Sharp = "######################################################################################"; // ### lines.
            const string Log = "Log: ";

            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"FAQ... hours, {Environment.NewLine} ## 1 - 10 minutes, 2 - 20 minutes, 3 - 30 minutes. {Environment.NewLine} ## 4 - 40 minutes, 5 - 50 minutes, 6 - 60 minutes. {Environment.NewLine} ## 7 - 70 minutes, 8 - 80 minutes, 9 - 90 minutes.");
            // FAQ hours, minutes.

            Console.WriteLine(Sharp);

            try
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"##### MyDistanceMove #####");
                Console.WriteLine("Indicate the distance you need, then indicate how fast you will travel [kilometers] : ");
                Console.WriteLine(Sharp);
                Console.WriteLine($"You have traveled the distance for {Math.Round(moveAndSpreed.Move(0M, 0M), 2)} hours / minutes");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine(Sharp);
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("[Error] Empty values");

                using(var errorNull = new StreamWriter("errorLog.txt", true, Encoding.UTF8))
                {
                    errorNull.WriteLine(Log + "[Error] Empty values");
                }

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine(Sharp);
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("[Error] Zero division attempt");

                using (var errorNull = new StreamWriter("errorLog.txt", true, Encoding.UTF8))
                {
                    errorNull.WriteLine(Log + "[Error] Zero division attempt");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine(Sharp);
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("[Error] Invalid argument specified, enter an integer");

                using (var errorNull = new StreamWriter("errorLog.txt", true, Encoding.UTF8))
                {
                    errorNull.WriteLine(Log + "[Error] Invalid argument specified, enter an integer");
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine(Sharp);
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[Error] Non-correct number entered");

                using (var errorNull = new StreamWriter("errorLog.txt", true, Encoding.UTF8))
                {
                    errorNull.WriteLine(Log + "[Error] Non-correct number entered");
                }
            }
            finally
            {
                Console.WriteLine(Sharp);
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[Completed] MyDistanceMove Robot Offer Completed");
            }

            Console.ReadKey();
        }
    }
}
