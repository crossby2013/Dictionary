using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            studentScores.Add("StudentA", 89);//Student A is the key, 89 is the value

            studentScores.Add("StudentB", 75);

            studentScores.Add("StudentC", 94);

            studentScores.Add("StudentD", 98);

            foreach(KeyValuePair<string,int> student in studentScores)
            {
               // Console.WriteLine(student);
                Console.WriteLine(studentScores["StudentA"]);//printing an individual elements
            }
            Console.ReadLine();
        }
    }
}
