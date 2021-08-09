using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ryan'sATM
{
    class Program
    {
        /// to figure out
        /// how to save information past one instance of .NET
        ///keep a database or dictionary or something updated with cash information
        ///
       
        static void Main(string[] args)
        {
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
                    //ask if they want to check the balance or change the balance. 
                    System.Console.WriteLine("Press <1> to check your balance, Press <2> to change your balance, or press <3> to open a new account");
                    string here = Console.ReadLine();
                    if (here == "1") {
                        Tuple <int, bool> yes = Methods.CheckBalance(name, number);
                        if (yes.Item1 == false) {
                            System.Console.WriteLine("We are sorry, something went wrong");
                            //something went wrong with adding their account and try again. 
                        } else if (yes.Item2 == true) {
                            System.Console.WriteLine("The balance for the account of  " + number + " for the name of " + name + " is {1} " yes.Item1);
                            System.Console.WriteLine("Do you want to change your balance or open a new account or are you finished?");
                            System.Console.WriteLine("Press <1> to change your balance, or press <2> to open a new account");
                            string bb = Console.ReadLine();
                            if (bb == "1") {
                                goto balance;
                            } else if (bb == "2") {
                                goto tryagain;
                            }
                        }
                    balance:
                    } else if (here == "2") { //change balance
                        System.Console.WriteLine("Do you want to check your balance before you change your balance? Press <1> for check or press <2> for change");
                        string check = Console.ReadLine();
                        if (check == "1") {

                        } else if (check == "2") { //just want to change balance
                           if (Methods.CheckAccount(name, num)) { //double check if the account exists
                                System.Console.WriteLine("What do you want to add to your account? Please enter in the amount in dollars as an integer or integer with a decimal");
                                decimal toadd = Console.ReadLine();
                                if (Methods.ChangeBalance(name, num, toadd)) { //do the adding
                                    decimal balanceof = Methods.Balance(num);
                                    System.Console.WriteLine("The account " + num + " was changed to add " + toadd + " for a new total of " + balanceof);
                                }

                           }
                           System.Console.WriteLine("What do you want to do now? Change balance <1>, Check balance <2>, "); //check with user to see what they want to do next

                        }

                    } else if (here == "3") {
                        goto tryagain;
                    }

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
                    System.Console.WriteLine("Do you want to input any money into the account?");
                    int amount = Console.ReadLine();
                    string name, int accountnumber = Methods.CreateAccount(name, amount); //CHECK THIS PHRASING
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