using System;
using System.Collections.Generic;


namespace _13.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {



            //Hash Table - > Hash Map !!!! is adata structure ! that implemetns associative array 
            // a hash talbe uses hash Functon to compute an index


            //data structure -> (format of)  data organisation ,management,
            //storage  type format ,  that enables  access and mofification.
            //Data structure is : collection of data values, the relations among them, 
            // the functions or  operations that can be applied on that data !
            // hash talbe uses hash function to copmpute Index , key ; from which the desired value can be found.
            // hash table is more effcient ! A function shoud provide uniform distribution of hash valies to avoid collisions

            // The main advantage of the hash table over other table data structures is the speed !
            // Hash talbles are powerful when they contain a large numbers of entities.
            // for a small number of entiteies are not effective
            //a dictionary is implementation of hash Table
            // Hash Map = Hash Table
            // every hash Table-stroes a data into key-value combination, 
            //every key is unique , but values can repeat, 
            // here we have an index -that is key -to this key correcsponts a value

            var map = new Dictionary<string, string>(); //We define a new object type dictinary
            map.Add("cat", "orange");  // we add some keys and values
            map.Add("dog", "brown");

            // Loop over teh Map

            //foreach (var pair in map)
            //{
            //    string key = pair.Key;
            //    string value = pair.Value;
            //    Console.WriteLine(key + " " + value);   //printint the key -> value  pair
            //}

            // .. get the value of the known key 
            //string result = map["cat"];
            // Console.WriteLine(result);

            string mapValue;  //creating a variable 

            if (map.TryGetValue("d", out mapValue)) // gets the value of the key and getsi to variable mapValue
            {
                Console.WriteLine(mapValue); //printing the value corresponding to the key
            }
            Console.WriteLine(map["d"]);

        }
    }
}
