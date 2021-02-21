using System;
using System.Collections.Generic;
using System.Text;

namespace G45D
{
    public class MyDictionary<Tkey,TValue>
    {
        Dictionary<Tkey, TValue> myDictionary;
        Dictionary<Tkey, TValue> tempDictionary;


        public MyDictionary()
        {
            myDictionary = new Dictionary<Tkey, TValue>(0);

        }

        public void Add(Tkey key, TValue value)
        {
            tempDictionary = myDictionary;
            myDictionary = new Dictionary<Tkey, TValue>(myDictionary.Count + 1);

            foreach (var item in tempDictionary)
            {
                myDictionary.Add(item.Key, item.Value);
            }

            myDictionary.Add(key, value);
        }

        public int Length
        {
            get
            {
                return myDictionary.Count;
            }
        }

        public Dictionary<Tkey,TValue> MyDictionaryItems
        {
            get
            {
                return myDictionary;
            }
        }
    }
}
