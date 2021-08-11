using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace myApp
{
    public class bankAccount
    {
        public bankAccount() { //initiates the dictionary, does at start
            this.names = new Dictionary<string, List<int>>();
            this.account = new Dictionary<List<int>, int>();
            this.name = null;
            this.accountnum = new List<int>();
            this.startamount = 0;

        }
        public bankAccount(string name, List<int> accountnum, int startamount) : this() {
            this.name = name;
            this.accountnum = accountnum;
            this.startamount = startamount;
            names.Add(name, accountnum);
            account.Add(accountnum, startamount);

        } //this initiates a dictionary
        public string name;
        public List<int> accountnum;
        int startamount;


        



        public Dictionary<string, List<int>> names {get; set;}
        public Dictionary<List<int>, int> account {get; set;}

        public string GetDetails(){
           return $"Name on account: {name}\n Account number: {accountnum[0]}\n Starting amount in account: {startamount}\n";
        }
        public static void GetDetails(List<bankAccount> myaccounts) {
            foreach (bankAccount i in myaccounts) {
                System.Console.WriteLine($"Name on account: {i.name}\n Account number: {i.accountnum[0]}\n Starting amount in account: {i.startamount}\n");
            }
        }
        
    

    }

    
}