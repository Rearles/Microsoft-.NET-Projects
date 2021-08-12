using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace myApp
{
    
    class Methods : bankAccount
    {
        private static Dictionary<string, List<bankAccount>> accountinformation = new Dictionary<string, List<bankAccount>>();
        /// <summary>
        /// this method adds a bank account to the dictionary
        /// </summary>
        /// <param name="name"></param>
        /// <param name="myaccount"></param>
        public static void bankAccountAdd(string name, bankAccount myaccount) { //adds bank account to the dictionary for the bank account myaccount to be accessible later.
            int index = GetNums(name);
            accountinformation[name].Add(myaccount[index]); //this should add the name associated with the bank account to a dictionary
        }
        /// <summary>
        /// retreives the bank account that should be in accountinformation dictionary, and if it doesn't exist it returns null
        /// </summary>
        /// <param name="name"></param>
        /// <returns>either List<bankAccount> at given name or null if it doesn't exist</returns>
        public static List<bankAccount> bankAccountRetrieve(string name) { 
            if (accountinformation.ContainsKey(name)) { //if the name exists in the dictionary
                return accountinformation[name];
            } else {
                return null;
            }
        } 
        /// <summary>
        /// this allows me to access the amount of items in the dictionary at a given name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>index</returns>
        public static int GetNums(string name) {
            if (!accountinformation.ContainsKey(name)) {
                return 0;
            } else if (accountinformation.ContainsKey(name)) {
                return accountinformation[name].Count() - 1;
            }
        }
        /// <summary>
        /// generates bank account number equal to length and returns that number to be used in bank account creation. 
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
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