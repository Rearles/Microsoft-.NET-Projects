using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace myApp
{
    class Methods
    {
        
        Dictionary<string, int[]> names = new Dictionary<string, int[]>();
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
        static internal Tuple <int, string> CreateAccount(string name) {
            names.add(name, )


            return new Tuple<int, string>( infor, inputValue );

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
    }
}