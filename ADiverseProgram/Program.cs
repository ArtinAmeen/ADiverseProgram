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

                // in this switch body, the different cases represent what service you will get depending what you input.
                // if our input does not match any case, we will be sent to the default block
                switch (option)
                {
                    // this option terminates our program
                    case "0":
                        Console.WriteLine("Program terminated. Have a nice day!");
                        Environment.Exit(0);
                        break;

                    // in this alternative, where the output will be in Swedish, we will start with an input of an age
                    // to see the different prices for movie tickets (in SEK). We will then input the number of people
                    // buying a ticket and his/her/their ages to see how much the total price for the ticket(s) will be
                    case "1":
                        Console.Write("I detta alternativ kan du mata in en ålder för att ta reda på hur mycket en biljett kostar, ");
                        Console.WriteLine("samt, ta reda på hur mycket den totala kostnaden blir för ett sällskap som vill köpa biobiljetter.");

                        bool continueInput = true;

                        // this is do-while loop with a nested if-statement, with one outer if-statement,
                        // three inner if-statements, and an else-statement (if we were to input a negative number).
                        // If the else statement is executed, the do-while loop will restart
                        do
                        {
                            Console.Write("\nMata in en ålder: ");
                            string input = Console.ReadLine();
                            int age = Convert.ToInt32(input);

                            if (age > 0)
                            {
                                if (age < 20)
                                {
                                    Console.WriteLine("Ungdomspris: 80 kr");
                                }

                                if (age > 64)
                                {
                                    Console.WriteLine("Pensionärspris: 90 kr");
                                }

                                if (age > 20 && age < 65)
                                {
                                    Console.WriteLine("Standardpris: 120 kr");
                                }
                                Console.WriteLine();
                                continueInput = false;
                            }

                            else
                            {
                                Console.WriteLine("Felaktig inmatning. Försök igen");
                            }

                        } while (continueInput == true);


                        // we will input the number of people buying a ticket/tickets
                        Console.WriteLine("Ta nu reda på hur mycket det kostar för ett sällskap att gå på bio.");
                        Console.Write("Ange det totala antalet personer: ");
                        int people = Convert.ToInt32(Console.ReadLine());

                        string[] ages = new string[people];

                        int cost = 0;

                        // here, the input will represent the age of the person (or those) buying a ticket.
                        // The input will be stored in our string array.
                        Console.WriteLine("Deras åldrar (tryck på enter efter varje inmatad ålder): "); 
                        for (int i = 0; i < ages.Length; i++)
                        {
                            ages[i] = Console.ReadLine();
                        }

                        // to later use it in a condition, we will create an int array where we will store
                        // the values in the string array (albeit in a converted form)
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

                        // the total price for the ticket(s)
                        Console.WriteLine("Den totala kostnaden: " + cost + " kr");
                        Console.WriteLine();

                        break;
                    
                    // this alternative takes our input and prints it out ten times
                    case "2":
                        Console.Write("Make an input that will be repeated ten times: ");
                        string inputToRepeat = Console.ReadLine();

                        Console.WriteLine();

                        // this for-loop will execute nine times, while the tenth execution will be executed
                        // immediately after so that the total ouput won't end with a comma
                        for (int i = 1; i < 10; i++)
                        {
                            Console.Write(i + ". " + inputToRepeat + ", ");
                        }

                        Console.WriteLine("10. " + inputToRepeat);
                        Console.WriteLine();
                        break;

                    // with this choice, you shall input at least three words where the third word will be output
                    case "3":
                        bool rightInput = false;

                        // this do-while loop works in the way that it will continue to be executed as long as
                        // the number of words input is below three.
                        do
                        {
                            Console.Write("Make an input of at least three words (with only one blank between them): ");
                            var inputOfAtLeast3Words = Console.ReadLine();
                            string[] words = inputOfAtLeast3Words.Split(' ', '.', ',', '!', '?');

                            if (words.Length < 3)
                            {
                                Console.WriteLine("Not enough words have been put in. Try again.");
                                Console.WriteLine();
                            }

                            else
                            {
                                Console.WriteLine("The 3rd word is: " + words[2]);
                                Console.WriteLine();
                                rightInput = true;
                            }
                        } while (rightInput == false);

                        break;

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
