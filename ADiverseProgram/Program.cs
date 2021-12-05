using System;

namespace ADiverseProgram
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the main menu of this program. Please enter a number the desired service.\n");

            Console.WriteLine("Input 0 to terminate this program.");
            Console.WriteLine("Input 1 to get information about and purchase movie tickets.");
            Console.WriteLine("Input 2 to repeat your input ten times.");
            Console.WriteLine("Input 3 to input a sentence with at least three words, where you will get the third word.\n");

            string input = Console.ReadLine();

            Console.WriteLine();

            switch (input)
            {
                case "0":
                    Console.WriteLine("Program terminated. Have a nice day!");
                    Environment.Exit(0);
                    break;

                case "1":
                    break;

                case "2":
                    Console.Write("Make an input that will be repeated 10 times: ");
                    string inputToRepeat = Console.ReadLine();

                    Console.WriteLine();

                    for (int i = 1; i < 10; i++)
                    {
                        Console.Write(i + ". " + inputToRepeat + ", ");
                    }

                    Console.WriteLine("10. " + inputToRepeat);
                    break;

                case "3":
                    Console.WriteLine("Make an input of at least three words: ");

                    string a = Console.ReadLine();
                    int stringLength = a.Length;

                    char[] totalInput = new char[a.Length];
                    int numberOfWords = 1;

                    while (true)
                    {
                        while (true)
                        {
                            string a = Console.ReadLine();
                            int stringLength = a.Length;

                            char[] totalInput = new char[a.Length];
                            int numberOfWords = 1;
                        }

                        for (int i = 0; i < a.Length; i++)
                        {
                            totalInput[i] = a[i];

                            if (totalInput[i] == ' ')
                            {
                                numberOfWords++;
                            }
                        }

                        if (numberOfWords > 2)
                        {
                            break;
                        }
                    }

                    Console.WriteLine(numberOfWords);
                    break;

                default:
                    Console.WriteLine("Sorry, your input is invalid.");
                    break;
            }
        }
    }
}
