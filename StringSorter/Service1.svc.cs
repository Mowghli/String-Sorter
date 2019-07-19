using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StringSorter
{
    public class Service1 : IService1       // service to sort comma-separeted integers in a string
    {
        public string sort(string s)            // function for sorting comma-separated integers in a string
        {
            string ss;                          // creating a string "ss"
            string[] strarr = s.Split(',');     // parsing the string "s", storing numbers in "s" into string array "starr"
            int[] intarr = Array.ConvertAll(strarr, Int32.Parse);   // converting and storing each string of array "starr" into array "intarr"
            Array.Sort(intarr);                   // sorting the integer array "intarr"
            ss = string.Join(",", intarr);         // joining each element in "intarr", separated by a ',', and converting into a string; storing that string into "ss"
            return ss;                          // returning the string "ss"
        }
    }
}
