using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cup cup = new Cup();

            cup.AddCoffee();
            cup.AddMilk();
            cup.AddSugar();
            cup.Stir();


        }
    }
}
