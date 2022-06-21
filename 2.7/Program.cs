using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string frameWidht = "";
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите символ: ");
            var simbol = Console.ReadLine();
            var additionToLength = 4;
            var emptySpaceForSecondLine = " ";
            Console.WriteLine($"Символ: {simbol}");
                       
            for (var i = 1; i <= (name.Length + additionToLength); i += 1)
            {
                    frameWidht += simbol;
            }

            Console.WriteLine(frameWidht);
            Console.WriteLine(frameWidht[0] + emptySpaceForSecondLine + name + emptySpaceForSecondLine + frameWidht[frameWidht.Length - 1]);
            Console.WriteLine(frameWidht);
        }
    }
}
