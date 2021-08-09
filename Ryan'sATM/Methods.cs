using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace myApp
{
    class Methods
    {
        //combine these 
        Dictionary<string, int[]> names = new Dictionary<string, int[]>(); //dictionary from string, a name, to a list of ints of account numbers 
        Dictionary<int, int > accountvalue = new Dictionary<int, int>(); //dictionary from int acccount number to amount in it. 
        static internal bool GetAccount(string account) {
            if (account == "No" || account == "no") {
                return false;
            }
            else if (account == "Yes" || account == "yes") {

                return true;

            } else {
                return false;
            }

        }
        static internal Tuple <string, int> CreateAccount(string name, int amount) { //code to create new account with a helper function
            int num = RandomDigits(10);
            names.add(name, num);
            accountvalue.add(num, amount);
            return new Tuple<string, int>( name, num );
        }

        public int RandomDigits(int length) //to create a new bank account number
        {
            aaaaaa:
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            int num=int.Parse(s);
            if (!names.ContainsValue(num)){
                goto aaaaaa;

            } else {
                return num;
            }
            
        }
        static internal Tuple <int, bool> CheckBalance(string name, int accountnumber) {
            if (!names.ContainsValue(accountnumber) || !accountvalue.ContainsKey(accountnumber)) {
                return new Tuple<int, bool>( 0, false );
            } else {
                return new Tuple<int, bool>( accountvalue[accountnumber], true );
            }
        }
        static internal bool ChangeBalance(string name, int accountnumber, decimal amount) {
            if (!names.ContainsValue(accountnumber) || !accountvalue.ContainsKey(accountnumber)) {
                return false;
            }
            else {
                accountvalue[accountnumber] = accountvalue[accountnumber] + amount;
                return true;
            }
        }

        static internal bool CheckAccount(string name, int accountnumber) {
            if (!names.ContainsValue(accountnumber) || !accountvalue.ContainsKey(accountnumber)) {
                return false;
            } else {
                return true;
            }
        }
        static internal decimal Balance(int accountnumber) {
            return accountvalue[accountnumber];
        }
        //check balance, change balance, 
    }
}