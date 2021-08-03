using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace myApp
{
    class Program
    {
        /// to figure out
        /// how to save information past one instance of .NET
        ///keep a database or dictionary or something updated with cash information
        ///
       
        static void Main(string[] args)
        {
            Dictionary<string, int[]> names = new Dictionary<string, int[]>();
            Console.WriteLine("Do you have an account with us?");
            string account = Console.ReadLine();
            if (account == "Yes" || account == "yes") {
                Console.WriteLine("What name is it under?");
                string accountname = Console.ReadLine();
                if (names.ContainsKey(accountname)) {
                    Console.WriteLine("Welcome " + accountname + ". Thank you for banking with us");
                }
                else if (!names.ContainsKey(accountname)) {
                    Console.WriteLine("We are sorry" + accountname + ". We can't find your records.");
                    ///this is where I should ask if the person entered their information wrong
                    ///or if they don't have an account with us
                    ///and if they want to open one. 
                }
            }
            else if (account == "No" || account == "no") {
                Console.WriteLine("Do you want to open an account?");
                string open = Console.ReadLine();
                if (open == "Yes" || open == "yes") {
                    
                }

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
