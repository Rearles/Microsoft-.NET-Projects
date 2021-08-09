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
            wrong:
            Console.WriteLine("Do you have an account with us?");
            string account = Console.ReadLine();
            bool answer = Methods.GetAccount(account);
            if (answer == true) {
                //goto accessing that account
                tryagain:
                System.Console.WriteLine("Please enter your name as it would appear on the account");
                string name = Console.ReadLine();
                System.Console.WriteLine("Thank you " + name);
                System.Console.WriteLine("Please enter the account number attached to " + name);
                int num=int.Parse(Console.ReadLine());
                bool check = Methods.AccountInformation(name, num);
                if (check == true) { //if the information is included

                } else {
                    System.Console.WriteLine("We're sorry we don't have that information, try again? Type <yes> or <no>");
                    string sorry = Console.ReadLine();
                    if (sorry == "yes" || sorry == "Yes") {
                        goto tryagain;
                    } else {
                        goto endofscript;
                    }
                }
            } else if (answer == false) { //two outcomes, either they don't have an account or they entered something wrong
                System.Console.WriteLine("Type <1> to open an account with us, type <2> if you entered incorrect information or <3> if you have no interest in opening an account");
                string a = Console.ReadLine();
                if (a == "1") {
                    //go to new account creation method
                    System.Console.WriteLine("I need your name to open an account with us");
                    string name = Console.ReadLine();
                    string name, int accountnumber = Methods.CreateAccount(name); 
                } else if (a == "2") {
                    goto wrong;
                } else if (a == "3") {
                    goto endofscript;
                }

            } 
          
            endofscript:
            System.Console.WriteLine("Thank you for considering Ryan's ATM. Have a great day.");
           
        }


    }
}