using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryChall
{
    class DictionaryChall
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> CoatCheck = new Dictionary<int, string>();
            CoatCheck.Add(13, "Purple Coat");
            CoatCheck.Add(54, "Peacoat");
            CoatCheck.Add(34, "Fleece");
            CoatCheck.Add(65, "Blue Coat");
            CoatCheck.Add(3, "Red Coat");
            CoatCheck.Add(78, "Rain Coat");
            CoatCheck.Add(98, "Leather Jacket");
            CoatCheck.Add(90, "Green Coat");
            CoatCheck.Add(24, "Blazer");
            CoatCheck.Add(50, "Black Coat");

            foreach(KeyValuePair<int,string> coats in CoatCheck)
            {
                Console.WriteLine(coats);
            }
            Dictionary<string, string> ValetCheck = new Dictionary<string, string>();
            ValetCheck.Add("Nolan", "Volkswagon");
            ValetCheck.Add("Hunt", "Ford");
            ValetCheck.Add("Cross", "Mustang");
            ValetCheck.Add("Brown", "Chevy");
            ValetCheck.Add("Cephas", "Toyota");
            ValetCheck.Add("Smith", "Cadalliac");
            ValetCheck.Add("Wilson", "Honda");
            ValetCheck.Add("Black", "BMW");
            ValetCheck.Add("Drake", "Buick");
            ValetCheck.Add("Gray", "Kia");

            foreach(KeyValuePair<string,string> cars in ValetCheck)
            {
                Console.WriteLine(cars);
            }
            Dictionary<string, int> ZooAnimals = new Dictionary<string, int>();
            ZooAnimals.Add("Lions", 3);
            ZooAnimals.Add("Zebra", 4);
            ZooAnimals.Add("Birds", 15);
            ZooAnimals.Add("Monkeys", 8);
            ZooAnimals.Add("Snakes", 3);
            ZooAnimals.Add("Tiger", 6);
            ZooAnimals.Add("Bears", 4);
            ZooAnimals.Add("Naked Mole Rats", 20);
            ZooAnimals.Add("Giraffe", 4);
            ZooAnimals.Add("Hippo", 2);

           // Console.WriteLine(ZooAnimals.Values.Max());//finds the highest quantity
            int LowQuantity = ZooAnimals.Values.Min();//find lowest quantity
           // Console.WriteLine(LowQuantity);
            string LowKey = ZooAnimals.FirstOrDefault(x => x.Value == LowQuantity).Key;//sees the lowest value which is 2 and finds its key which is hippo
            Console.WriteLine(LowKey);
            ZooAnimals.Remove(LowKey);//removes the lowest quantity key and value
            foreach(KeyValuePair<string,int> animals in ZooAnimals)
            {
                Console.WriteLine(animals);//prints out all the keys and values except for the one removed
            }

            Console.WriteLine(ZooAnimals.Count());//Counts the remaining entries in the dictionary which is 9

            Console.WriteLine("Input an animal name");
            string userReply = System.Console.ReadLine();
            if(ZooAnimals.ContainsKey(userReply))
            {
                Console.WriteLine("We have this animal");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
                string answer = Console.ReadLine();//reading the answer
                if (answer == "yes" || answer == "Yes")//if answer is lowercase or and uppercase yes
                {
                    Console.WriteLine("How many of the animal do you want to add?");//ask how many for the value
                    int reply = int.Parse(Console.ReadLine());//convert the string into an int and read answer
                    ZooAnimals.Add(userReply,reply);//then add the new key and value
                }
                else
                {
                    Console.WriteLine("Thank you for participating!");
                }
            }
            foreach (KeyValuePair<string, int> animals in ZooAnimals)
            {
                Console.WriteLine(animals);
            }


            Console.ReadLine();
        }
    }
}
