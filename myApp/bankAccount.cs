using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace myApp
{
    public class bankAccount
    {
        /// <summary>
        /// Initializes the information tied to the bank account to starter values
        /// </summary>
        public bankAccount() { 
            this.names = new Dictionary<string, List<int>>();
            this.account = new Dictionary<List<int>, int>();
            this.name = null;
            this.accountnum = new List<int>();
            this.startamount = 0;

        }
        /// <summary>
        /// Initializes the bank account at creation with the name of the account holder, account number tied to that account, the starting amount in the account.
        /// It also adds the information of name and account number to the dictionary names as well as the account number and starting amount to the dictionary acccount.
        /// Note: The account number here is the same, hence linking the two dictionaries together
        /// Potential improvement: Dictionary<name, Dictionary<accountnum, startamount>>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="accountnum"></param>
        /// <param name="startamount"></param>
        /// <returns></returns>
        public bankAccount(string name, List<int> accountnum, int startamount) : this() {
            this.name = name;
            this.accountnum = accountnum;
            this.startamount = startamount;
            names.Add(name, accountnum);
            account.Add(accountnum, startamount);

        } 
        //initializes the different varibales included in this class to be used elsewhere in the class 
        public string name;
        public List<int> accountnum;
        int startamount;
        public Dictionary<string, List<int>> names {get; set;}
        public Dictionary<List<int>, int> account {get; set;}
        /// <summary>
        /// Prints out the details attached to the bank account you send it, has to be invocated as follows bankAccount.GetDetails(); 
        /// so it knows what to put in for name, accountnum, and starting amount
        /// </summary>
        /// <returns>string of the information to be printed out and shown to user</returns>
        public string GetDetails(){
           return $"Name on account: {name}\n Account number: {accountnum[0]}\n Starting amount in account: {startamount}\n";
        }
        /// <summary>
        /// this is the same as GetDetails() above but works for userts who have multiple bank accounts attached to their name
        /// </summary>
        /// <param name="myaccounts"></param>
        public static void GetDetails(List<bankAccount> myaccounts) {
            foreach (bankAccount i in myaccounts) {
                System.Console.WriteLine($"Name on account: {i.name}\n Account number: {i.accountnum[0]}\n Starting amount in account: {i.startamount}\n");
            }
        }
        
    

    }

    
}