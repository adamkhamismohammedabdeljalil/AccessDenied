using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDenied
{
    //a class with internal access modifier
    internal class MyBank
    {
         // a public property
        public string Name { get; set; }

        //protected int AccountNumber { get; set; }  
        internal int AccountNumber { get; set; }
        public int Balance { get; set;}
        internal void CreditPrompt() {
            Console.WriteLine($"Dear {Name}, you have {Balance} FrinkCoins in your account {AccountNumber}.");
        }  
    }
}
