using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace myApp
{
    class Program
    {
        Dictionary<string, string> names = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Do you have an account with us?");
            string account = Console.ReadLine();
            if (account == "Yes" || account == "yes") {
                
            }
            bool cardnum = false;
            while (cardnum == false) {
                Console.WriteLine("Enter your credit card number or debit card number");
                string ccnum = Console.ReadLine(); 
                if (ccnum.IndexOf("4") == 0) {
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
                } else if (ccnum.IndexOf("5") == 0 || ccnum.IndexOf("2") == 0) {
                    Console.WriteLine("Your card is Mastercard right?");
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
