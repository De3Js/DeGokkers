using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(generateName());
            Console.ReadLine();
        }

        public static string generateName()
        {
            Random r = new Random();
            string[] consonants = {"b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","sh","z","zh",
            "t","v","w","x","y"};
            string[] vowels = { "a", "e", "i", "o", "u" };
            string stringName;
            string[] arrayName = new string[3];
            bool Cons;
            int a = r.Next(0, 1);
            if (a == 1) Cons = true; else Cons = false;
            int i = 0;
            Cons = false;
            while (i < 3)
            {
                if (Cons)
                {
                    arrayName[i] = consonants[r.Next(consonants.Length)];
                    Cons = false;
                    i++;
                }
                else
                {
                    arrayName[i] = vowels[r.Next(vowels.Length)];
                    Cons = true;
                    i++;
                }
            }
            stringName = string.Join("", arrayName);
            return stringName;
        }
    }
}
