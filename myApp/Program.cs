using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace myApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            start:
            System.Console.WriteLine("Do you have an account with us?");
            string answer = Console.ReadLine();
            if (answer == "No" || answer == "no") {
                System.Console.WriteLine("Please enter the name of the account to open");
                string name = Console.ReadLine();
                int account = Methods.RandomDigits(9);
                System.Console.WriteLine("Do you want to enter money into the account?");
                int amountof = int.Parse(Console.ReadLine());
                int[] accountnumbers = new int[]{account};
                bankAccount accountname = Console.ReadLine();
                bankAccount accountname = new bankAccount(name, accountnumbers, amountof);
                string details = accountname.GetDetails();
                Console.WriteLine(details);
                goto start;
                //running into issues of what to name bankaccount to access it down below. Damn you strictly typed languages
                
            } else if (answer == "Yes" || answer == "yes") {
                System.Console.WriteLine("Thank you for choosing us");
                System.Console.WriteLine("What's the name is it under?");
                bankAccount yourname = Console.ReadLine();
                System.Console.WriteLine("Is this your account?");
                string details = yourname.GetDetails();
                Console.WriteLine(details);
                string yesorno = Console.ReadLine();
            } //running into issues here due to what I tell get details. see line 32-36

        }
    }
}