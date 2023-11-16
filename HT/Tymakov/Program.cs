using System;
using System.Globalization;
using System.Threading;

namespace Tymakov
{
    class MainClass
    {
        /// <summary>
        /// Writes "> " in start of the line.
        /// </summary>
        static void Offer()
        {
            Console.Write("> ");
        }

        /// <summary>
        /// Writes a number of the task.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="number">Number of the task.</param>
        static void Message(string message, int number)
        {
            Console.WriteLine("\nLet's check problem #{0}\nThis program {1}\nPress any to continue...", number, message);
            Console.ReadKey();
        }

        /// <summary>
        /// Reads the input int. If input incorrect it ass user to try again.
        /// </summary>
        /// <returns>The input int.</returns>
        /// <param name="positiveFlag">If set to <c>true</c> input must be positive.</param>
        /// <param name="nonZero">If set to <c>true</c> input must not be zero.</param>
        static int ReadInt(bool positiveFlag, bool nonZero)
        {
            int result = 1;
            bool term = true;
            while (term)
            {
                Offer();
                bool convert = int.TryParse(Console.ReadLine(), out result);
                bool positive = (result >= 0) || !positiveFlag;
                bool noZero = (result != 0) || !nonZero;
                if (convert && positive && noZero)
                {
                    term = false;
                }
                else if (!positive)
                {
                    Console.WriteLine("The input must be positive. Please, try again:");
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please, try again:");
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            void Lab()
            {
                Message("tests AChipher and BChipher", 1);
                AChipher aChipher = new AChipher();
                BChipher bChipher = new BChipher();
                string source = "А абв 123";
                Console.WriteLine($"AChipher encodes \"{source}\"");
                source = aChipher.Encode(source);
                Console.WriteLine($"AChipher returned \"{source}\"");
                Console.WriteLine($"AChipher decodes \"{source}\"");
                source = aChipher.Decode(source);
                Console.WriteLine($"AChipher returned \"{source}\"");
                Console.WriteLine("=============================");

                Console.WriteLine($"BChipher encodes \"{source}\"");
                source = bChipher.Encode(source);
                Console.WriteLine($"BChipher returned \"{source}\"");
                Console.WriteLine($"BChipher decodes \"{source}\"");
                source = bChipher.Decode(source);
                Console.WriteLine($"BChipher returned \"{source}\"");
            }

            void HT()
            {
                Message("tests figures", 1);
                Circle circle = new Circle(10, 10, "red", 10);
                Console.WriteLine(circle);
                Dot dot = new Dot(0, 1, "blue")
                {
                    Visibility = true
                };
                Console.WriteLine(dot);
                Rectangle rectangle = new Rectangle(0, 100, "gray", 10, 20)
                {
                    Visibility = true
                };
                rectangle.MoveY(-100);
                Console.WriteLine(rectangle);
                Console.WriteLine($"Space of rectangle: {rectangle.GetSpace()} and circle: {circle.GetSpace()}");
            }

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru");
            bool run = true;
            while (run)
            {
                Console.WriteLine();
                Console.WriteLine("||===========================<\\\\>===========================||");
                Console.WriteLine("Please, input \"HT\", if you want to check the HT solutions  or type \"exit\" to stop");
                Offer();
                string respond = Console.ReadLine().ToLower().Trim();
                if (respond.Equals("exit"))
                {
                    run = false;
                    continue;
                }
                if (respond.Equals("ht") || respond.Equals("нт")) // and russian-letters case
                {
                    HT();
                }
                else
                {
                    Lab();
                }
            }

            Console.WriteLine("Please, press any key to continue...");
            Console.ReadKey();
        }
    }
}
