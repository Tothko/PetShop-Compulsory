using System;
using Core;

namespace PetShopConsole
{
    class Printer
    {
        private static Boolean Run = true;
        public Printer()
        {
            IPetService PS;
        }
        static void Main(string[] args)
        {
         while(Run)   
            Console.WriteLine("Welcome to my little Pet shop");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Show all pets");
            Console.WriteLine("2. Search pets");
            Console.WriteLine("3. Create new pet");
            Console.WriteLine("4. Delete pet");
            Console.WriteLine("5. Update pet");
            Console.WriteLine("6. Show pets by Price");
            Console.WriteLine("7.. Show 5 cheapest pets");


        }
    }
}
