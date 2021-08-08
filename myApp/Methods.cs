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
    }
}