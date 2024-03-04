using System.Collections.Concurrent;

namespace MenuProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                // Displaying the Main Menu
                Console.WriteLine("Main Menu:");
                Console.WriteLine("------------");
                Console.WriteLine("Welcome to the Main Menu !");
                Console.WriteLine("Please navigate by entering numbers to choose different functions.");
                Console.WriteLine();
                Console.WriteLine("1. Check if a person is a youth or pensioner.");
                Console.WriteLine("2. Calculate ticket prices for a party.");
                Console.WriteLine("3. Repeat user input ten times.");
                Console.WriteLine("4. Extract the third word from a sentance.");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice: ");

                // Reading user(s) choice
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                // Handling user choice
                switch (choice)
                {
                    // Exit the program
                    case 0:
                        Console.WriteLine("Exiting...");
                        keepRunning = false;
                        break;

                    // Call method to when user choose number 1
                    case 1:
                        CheckYouthOrPensioner();
                        break;

                    // Call method when user choose number 2 
                    case 2:
                        CalculateTicketPrices();
                        break;

                    // Call method when user choose number 3
                    case 3:
                        RepeatUserInputTenTimes();
                        break;

                    // Call method when user choose number 4
                    case 4:
                        ExtractThirdWord();
                        break;
                }

                Console.WriteLine();
            } 
        }

        // Method for case 1, to check if a person is Youth or Pensioner.
        static void CheckYouthOrPensioner()
        {
            Console.WriteLine();
            Console.WriteLine("Menu Choice 1 - Youth or Pensioner:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("To check if a person is a youth or pensioner, please enter the age of the person.");
            Console.WriteLine();
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            string result;

            if(age < 20)
            {
                result = "Youth price: 80 SEK";
            }
            else if (age > 64)
            {
                result = "Pensioner(s) price: 90 SEK";
            }
            else
            {
                result = "Standard price: 120 SEK";
            }

            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
        }

        // Method for case 2, to calculate the ticket price based on the age.
        static void CalculateTicketPrices()
        {
            Console.WriteLine();
            Console.WriteLine("Menu choice 2 - Calculate Ticket Prices for a Party: ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("To calculate ticket prices for a party, please enter the number of people in your party.");

            Console.WriteLine("Enter the number of people: ");
            int numberOfPeople = int.Parse(Console.ReadLine());

            int totalCost = 0;

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.WriteLine($"Enter age for person {i}: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 20)
                {
                    totalCost += age;
                }
                else if (age > 64)
                {
                    totalCost += 90;
                }
                else
                {
                    totalCost += 120;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Summary");
            Console.WriteLine($"number of people: {numberOfPeople}");
            Console.WriteLine($"Total cost for the entire party: {totalCost} SEK");

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        // Method for case 3, to repeat user input 10 times in one row.
        static void RepeatUserInputTenTimes() 
        {
            Console.WriteLine();
            Console.WriteLine("Menu Option 3 - Repeat User Input Ten Times:");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Enter any text: ");
            string input = Console.ReadLine();

            Console.WriteLine("Result:");

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to return to the Main Menu.");
            Console.ReadKey();
        }

        // Method for case 4, to take the user input, check and show the third word.
        static void ExtractThirdWord()
        {
            Console.WriteLine();
            Console.WriteLine("Menu Option 4 - Extract the Third Word from a Sentence:");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter a sentence with at least 3 words: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            if (words.Length >= 3)
            {
                string thirdWord = words[2];
                Console.WriteLine("Result:");
                Console.WriteLine($"The third word in the sentence is: {thirdWord}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a sentence with at least 3 words.");
            }

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
