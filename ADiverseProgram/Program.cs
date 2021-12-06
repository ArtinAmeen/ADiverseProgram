using System;

namespace ADiverseProgram
{
    class MainMenu
    {
        static void Main(string[] args)
        {

            bool continuingProgram = true;

            while (continuingProgram)
            {
                // introduction to the main menu
                Console.WriteLine("Hello and welcome to the main menu of this program. Please enter a number the desired service.\n");

                // the different services
                Console.WriteLine("Input 0 to terminate this program.");
                Console.WriteLine("Input 1 to get information about and purchase movie tickets (this option is in Swedish).");
                Console.WriteLine("Input 2 to repeat your input ten times.");
                Console.WriteLine("Input 3 to input a sentence with at least three words, where you will get the third word.\n");

                // your input, which will decide what service you will get
                string option = Console.ReadLine();

                Console.WriteLine();


                // in this switch body, the different cases represent what service you will get depending what you input
                // if our input does not match any case, we will be sent to the default block
                switch (option)
                {
                    // this option terminates our program
                    case "0":
                        Console.WriteLine("Program terminated. Have a nice day!");
                        Environment.Exit(0);
                        break;

                    // this alternative (not finished)
                    case "1":
                        Console.Write("I detta alternativ kan du mata in en ålder för att ta reda på hur mycket en biljett kostar, ");
                        Console.WriteLine("samt, ta reda på hur mycket den totala kostnaden blir för ett sällskap som vill köpa biobiljetter.");
                        Console.Write("\nMata in en ålder: ");
                        string input = Console.ReadLine();
                        int age = Convert.ToInt32(input);

                        if (age > 0)
                        {
                            if (age < 20)
                            {
                                Console.WriteLine("Ungdomspris: 80 kr");
                            }

                            else if (age > 64)
                            {
                                Console.WriteLine("Pensionärspris: 90 kr");
                            }

                            else
                            {
                                Console.WriteLine("Standardpris: 120 kr");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Ta nu reda på hur mycket det kostar för ett sällskap att gå på bio.");
                        Console.Write("Ange det totala antalet personer: ");
                        int people = Convert.ToInt32(Console.ReadLine());

                        string[] ages = new string[people];

                        int cost = 0;

                        Console.WriteLine("Deras åldrar (tryck på enter efter varje inmatad ålder): ");

                        for (int i = 0; i < ages.Length; i++)
                        {
                            ages[i] = Console.ReadLine();
                        }

                        int[] agesOfPeople = new int[ages.Length];

                        for (int i = 0; i < agesOfPeople.Length; i++)
                        {
                            agesOfPeople[i] = Convert.ToInt32(ages[i]);
                        }

                        // for every person that is in the company, the cost is increased,
                        // and the increase depends on the age of the moviegoers
                        for (int i = 0; i < agesOfPeople.Length; i++)
                        {
                            if (agesOfPeople[i] < 20)
                            {
                                cost += 80;
                            }

                            else if (agesOfPeople[i] > 64)
                            {
                                cost += 90;
                            }

                            else
                            {
                                cost += 120;
                            }
                        }

                        Console.WriteLine("Den totala kostnaden: " + cost + " kr");
                        Console.WriteLine();

                        break;
                    
                    // this alternative takes our input and prints it out ten times
                    case "2":
                        Console.Write("Make an input that will be repeated ten times: ");
                        string inputToRepeat = Console.ReadLine();

                        Console.WriteLine();

                        for (int i = 1; i < 10; i++)
                        {
                            Console.Write(i + ". " + inputToRepeat + ", ");
                        }

                        Console.WriteLine("10. " + inputToRepeat);
                        Console.WriteLine();
                        break;

                    // with this choice, you shall input at least three words where the third word will be output
                    case "3":
                        Console.Write("Make an input of at least three words (with only one blank between them): ");
                        var inputOfAtLeast3Words = Console.ReadLine();
                        string[] words = inputOfAtLeast3Words.Split(' ', '.', ',', '!', '?');

                        if (words.Length < 3)
                        {
                            Console.WriteLine("Not enough words have been put in. Try again.");
                            Console.WriteLine();
                            continuingProgram = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("The 3rd word is: " + words[2]);
                            Console.WriteLine();
                            continuingProgram = true;
                            break;
                        }

                    // this is the path that will be taken if we make a wrong input
                    // we will be informed that we've made a wrong input, and will be redirected
                    // back to the main menu
                    default:
                        Console.WriteLine("Sorry, your input is invalid.");
                        continuingProgram = true;
                        break;
                }
            }
        }
    }
}
