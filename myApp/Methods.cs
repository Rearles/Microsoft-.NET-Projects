using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace myApp
{
    
    class Methods : bankAccount
    {
        private static Dictionary<string, List<bankAccount>> accountinformation = new Dictionary<string, List<bankAccount>>();
        public static void bankAccountAdd(string name, bankAccount myaccount) {
            accountinformation[name] = myaccount; //this should add the name associated with the bank account to a dictionary
        }
        public static List<bankAccount> bankAccountRetrieve(string name) {
            if (accountinformation.ContainsKey(name)) { //if the name exists in the dictionary
                return accountinformation[name];
            } else {
                return null;
            }
        } 
        public static int RandomDigits(int length) //to create a new bank account number
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            int num=int.Parse(s);
            return num;   
        }
    }
}