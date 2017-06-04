using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice Kata

            string text = "badger badger badger badger mushroom mushroom snake badger badger badger";
            string[] stringSeparators = new string[] { " ", "  ", "   " };

            Dictionary<string, string> wordandcount = new Dictionary<string, string> { };

            //split text string into an array of words (called words)
            string[] words = text.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            //store the first word in a dictionary with a count of 1 (1 star "*")
            wordandcount.Add(words[0], "*");

            //if each word after that is in the dictionary already, add a star
            //if not, add it to the dictionary with a count of 1 (1 star "*")
            for (int i = 1; i < words.Length; i++)
            {
                if (wordandcount.ContainsKey(words[i]))
                {
                    wordandcount[words[i]] = wordandcount[words[i]]+"*";
                }
                else
                {
                    wordandcount.Add(words[i], "*");
                }
            }

            //foreach (KeyValuePair<string, string> pair in wordandcount)
            //{
            //    Console.WriteLine(pair.Key,pair.Value);
            //}

            //store the dictionary as a list and sort it in descending order
            var myList = wordandcount.ToList();
            myList.Sort((x, y) => -1 * x.Value.CompareTo(y.Value));

            //print list which includes word and star count
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
