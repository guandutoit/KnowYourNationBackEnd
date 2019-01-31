using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Know_Your_Nation_Speedy
{
    public class KYNSDemo
    {
        public string SpeedysFriend(string name) {
            return name;
        }
        public Boolean Palandrome(string str) {
            string first = str.Substring(0, str.Length / 2);
            char[] arr = str.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        
        }
    }
}
