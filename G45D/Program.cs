using System;

namespace G45D
{
    class Program
    {
         static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();


            myDictionary.Add(31, "Emre");
            myDictionary.Add(9, "Meryem");
            myDictionary.Add(26, "Gamze");
            myDictionary.Add(29, "Kerim");

            Console.WriteLine(myDictionary.Length);

            foreach (var item in myDictionary.MyDictionaryItems)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

        }
    }
}
