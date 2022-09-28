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
            Console.CursorVisible = false;
            
            Menu test = new Menu();


 
            test.DisplayMainMenu();
            Console.ReadLine();
        }
    }
}
