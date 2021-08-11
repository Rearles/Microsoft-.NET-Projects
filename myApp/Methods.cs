using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace myApp
{
    class Methods
    {
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