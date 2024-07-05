using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            Console.Write("Up to how many numbers do you want to check?:");
            int loops = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= loops; i++)
            {

                if (i % 2 == 0)
                {

                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }

            }

            Console.WriteLine("Printing even numbers:");

            foreach (var item in evens)
            { Console.Write($"{item} "); }

            Console.WriteLine(Environment.NewLine + "Printing odd numbers:");
            foreach (var item in odds)
            { Console.Write($"{item} "); }

            Console.ReadLine();
            }
        }
    }






