using System;
using System.Collections.Generic;

namespace Kodanalys
{
    class Program // Here used changed to capital
    {
        static List<string> users = new List<string>();
        static int userCount = 0;

        //Dåliga variablenamn ändrade till mer passande namn
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                Console.Write("Val: ");
                string userChoice = Console.ReadLine();

                //Here a switch statement is more appropriate than multiple if-else statements
                // The switch statement is commented out below for reference

                /*switch (userChoice)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        ShowUsers();
                        break;
                    case "3":
                        RemoveUser();
                        break;
                    case "4":
                        SearchUser();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }*/

                Console.WriteLine();
            }
        }

    }
}
