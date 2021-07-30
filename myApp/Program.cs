using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        Dictionary<string, string> names = new Dictionary<string, string>();
        static void Main(string[] args)
        {

            bool cardnum = false;
            while (cardnum == false) {
                Console.WriteLine("Enter your credit card number or debit card number");
                string ccnum = Console.ReadLine();
                if (ccnum.IndexOf(4) == 0) {
                Console.WriteLine("Your card is a Visa correct?");
                string answer = Console.ReadLine();                
                if (answer == "Yes" || answer == "yes") {
                    Console.WriteLine("Thank you for confirming for me");
                    cardnum = true;
                } 
                else if (answer == "No" || answer == "no") {
                    Console.WriteLine("You entered the wrong information into the system. Please try again.");
                } else {
                    Console.WriteLine("You entered incorrect characters, try again");
                }
            }
            
            }

        }
    }
}
