using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryClassDemo
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] k;
        TValue[] v;
       

        public MyDictionary()
        {
            k = new TKey[0];
            v = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] TempKey = k;
            TValue[] TempValue = v;
            k = new TKey[k.Length + 1];
            v = new TValue[v.Length + 1];
            for (int i = 0; i < TempKey.Length; i++)
            {
                k[i] = TempKey[i];
                v[i] = TempValue[i];
            }
            k[k.Length - 1] = key;
            v[v.Length - 1] = value;
            
        }
        public TKey[] Keys { 
        get { return k; }
        } 
        public TValue[] Values { 
        get { return v; }
        }
        public void Dict()
        {

            for (int i = 0; i < k.Length; i++)
            {
                Console.WriteLine("Key: " + k[i] + " Value: " + v[i]);
            }
            
        }

    }
  
}
