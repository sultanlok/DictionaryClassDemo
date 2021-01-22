using System;

namespace DictionaryClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, dynamic> users = new MyDictionary<string, dynamic>();
            users.Add("Ad", "Sultan");
            users.Add("Id", 1453);

            foreach (var item in users.Keys)
            {
                Console.WriteLine("Key: "+item);
            }
            foreach (var item in users.Values)
            {
                Console.WriteLine("Value: "+item);
            }

            users.Dict();
        }
    }
}
