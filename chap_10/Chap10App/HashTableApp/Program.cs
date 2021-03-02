using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";
            /*Console.WriteLine(ht["일"]);
            Console.WriteLine(ht["이"]);*/

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
        }
    }
}
