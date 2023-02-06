using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivanova";
            string surname = "Anna";
            string exchange;
            Console.WriteLine($" Ваше имя {name}. Ваша фамилия {surname}.");

            exchange = name;
            name = surname;
            surname = exchange;
            Console.WriteLine($" Ваше имя {name}. Ваша фамилия {surname}");
        }

    }
}
