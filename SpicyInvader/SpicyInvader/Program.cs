using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 50);
            Menu test = new Menu();


            test.DisplayTitle();
            test.DisplayMainMenu();
            Console.ReadLine();
        }
    }
}
