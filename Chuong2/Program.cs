using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Ceasar.Encrypt("DHDY",1));


            Console.WriteLine(Playfair.Encipher("DHDY","D"));

            Console.ReadKey();
        }
    }
}
