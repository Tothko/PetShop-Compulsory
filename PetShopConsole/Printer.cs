using System;
using System.Collections.Generic;
using Core;
using Core.Application;
using Infrastrucute.Data;

namespace PetShopConsole
{
    class Printer
    {

        private static Boolean Run = true;
        static void Main(string[] args)
        {
            FakeDB.InitData();
            IPetRepository PR = new PetRepository();
            IPetService PS = new PetService(PR);

            do
            {
                
                Console.WriteLine("Welcome to my little Pet shop");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Show all pets");
                Console.WriteLine("2. Search pets");
                Console.WriteLine("3. Create new pet");
                Console.WriteLine("4. Delete pet");
                Console.WriteLine("5. Update pet");
                Console.WriteLine("6. Sort pets by Price");
                Console.WriteLine("7. Show 5 cheapest pets");
                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 0:
                        Run = false;
                        break;
                    case 1:
                        foreach (var Pet in PS.GetPets())
                        {
                            Console.WriteLine(Pet.ToString());
                        }
                        break;
                    case 2:
                        foreach (var Pet in PS.GetPetsByType(Console.ReadLine()))
                        {
                            Console.WriteLine(Pet.ToString());
                        }
                        break;
                    case 3:
                        PS.CreatePet();
                        break;
                    case 4:
                        PS.DeletePet();
                        break;
                    case 5:
                        Console.WriteLine("Please enter ID of a pet you want to update");
                        PS.UpdatePet(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Dont write anything if you dont want to update selected information");
                        break;

                    case 6:
                        PS.SortPetsByPrice();
                        break;
                    case 7:
                        foreach (var Pet in PS.GetFiveCheapest())
                        {
                            Console.WriteLine(Pet.ToString());
                        }
                        break;
                    default:
                        break;
                }


            } while (Run);
        }
    }
}
