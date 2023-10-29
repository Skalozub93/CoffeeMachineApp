using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
    internal class Cup : CupBase, IContainingCoffee, IContainingWater, IContainingMilk, IContainingSugar
    {
        /// <summary>
        /// Method from abstract class "CupBase" for mixing drinks
        /// </summary>
        public override void Stir()
        {
            Console.WriteLine("The drink mixed");
        }

        /// <summary>
        /// Method, which adding coffee
        /// </summary>
        public void AddCoffee()
        {
            Console.WriteLine("Coffee was added");
        }

        /// <summary>
        /// Method for adding water
        /// </summary>
        public void AddWater()
        {
            Console.WriteLine("Water was added");
        }

        /// <summary>
        /// Method for adding milk
        /// </summary>
        public void AddMilk()
        {
            Console.WriteLine("Milk was added");
        }

        /// <summary>
        /// Method for adding sugar
        /// </summary>
        public void AddSugar()
        {
            Console.WriteLine("Sugar was added");
        }



    }
}
