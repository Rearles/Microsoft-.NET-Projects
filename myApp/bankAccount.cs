using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace myApp
{
    public class bankAccount
    {
        public bankAccount() { //initiates the dictionary, does at start
            this.names = new Dictionary<string, int[]>();
            this.account = new Dictionary<int[], int>();
            this.name = null;
            this.accountnum = new int[]{};
            this.startamount = 0;

        }
        public bankAccount(string name, int[] accountnum, int startamount) : this() {
            this.name = name;
            this.accountnum = accountnum;
            this.startamount = startamount;
            names.Add(name, accountnum);
            account.Add(accountnum, startamount);

        } //this initiates a dictionary
        public string name;
        public int[] accountnum;
        int startamount;

        public Dictionary<string, int[]> names {get; set;}
        public Dictionary<int[], int> account {get; set;}

        public string GetDetails(){
           return $"Name on account: {name}\n Account number: {accountnum[0]}\n Starting amount in account: {startamount}\n";
        }

    }

    
}