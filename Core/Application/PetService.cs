using System;
using System.Collections.Generic;
using System.Text;
using Infrastrucute.Data;

namespace Core.Application
{
    public class PetService : IPetService
        
    {
        readonly IPetRepository IPR;
        List<Pet> Pets = new List<Pet>();

        public PetService(IPetRepository repo)
        {
            IPR = repo;
            foreach (var Pet in IPR.ReadPets())
            {
                Pets.Add(Pet);
            }
        }

        public void CreatePet()
        {
            Pet NewPet = new Pet();
                NewPet.ID = Pets.Count;
                Console.WriteLine("Please enter Name for the new pet");
                NewPet.Name = Console.ReadLine();
            Console.WriteLine("Please enter Owner for the new pet");
            NewPet.PreviousOwner = Console.ReadLine();
                Console.WriteLine("Please enter Price of the new pet");
            NewPet.Price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter SolDate of the new pet");
            NewPet.SoldDate = System.DateTime.Now;
                Console.WriteLine("Please enter Type of the new pet");
            NewPet.Type = Console.ReadLine();
                Console.WriteLine("Please enter Birthdate of the new pet");
            NewPet.Birthdate = System.DateTime.Now;
            Console.WriteLine("Please enter Color of the new pet");
            NewPet.Color = Console.ReadLine();
                
            Pets.Add(NewPet);
        }

        public void DeletePet()
        {
            Console.WriteLine("Please enter Name of the Pet to be deleted from database");
            var NameOfPetToDelete = Console.ReadLine();
            for (int i = 0; i < Pets.Count; i++)
            {
                if(Pets[i].Name == NameOfPetToDelete)
                {
                    Pets.RemoveAt(i);
                }
            }
        }

        public List<Pet> GetFiveCheapest()
        {
            
            List<Pet> FiveCheapest = new List<Pet>(Pets);

            Pet temp = null;
            for (int i = 0; i < FiveCheapest.Count; i++)
            {
                for (int j = 0; j < FiveCheapest.Count - 1; j++)
                {
                    if (FiveCheapest[i].Price < FiveCheapest[j].Price)
                    {
                        temp = FiveCheapest[i];
                        FiveCheapest[i] = FiveCheapest[j];
                        FiveCheapest[j] = temp;
                    }
                }
                
            }
            for (int z = FiveCheapest.Count; z > 0; z--)
            {
                if (z > 5) 
                {
                    FiveCheapest.RemoveAt(z-1); 
                }
            }

            return FiveCheapest;

        }

        public List<Pet> GetPets()

        {
            return Pets;
        }
        public List<Pet> GetPetsByType(String type)

        {
            List<Pet> PetsByType = new List<Pet>(Pets);
            for (int i = 0; i < PetsByType.Count; i++)
            {
                if (PetsByType[i].Type.Equals(type))
                {

                }
                else
                {
                    PetsByType.RemoveAt(i);
                }
            }
            
            return PetsByType;
        }

        public void SortPetsByPrice()
        {
            Pet temp = null;
            for (int i = 0; i < Pets.Count; i++)
            {
                for (int j = 0; j < Pets.Count-1; j++)
                {
                    if(Pets[i].Price < Pets[j].Price)
                    {
                        temp = Pets[i];
                        Pets[i] = Pets[j];
                        Pets[j] = temp;
                    }
                }
            }
        }

        public void UpdatePet(int ID)
        {
            if (ID > 0 && ID < Pets.Count)
            {
                Pet PetToUpdate = Pets[ID];
                Console.WriteLine("If you want update Name enter a new name for a pet");
                PetToUpdate.Name = Console.ReadLine();
                Console.WriteLine("If you want update Price enter a new name for a pet");
                PetToUpdate.Price = double.Parse(Console.ReadLine());
                Console.WriteLine("If you want update Owner enter a new name for a pet");
                PetToUpdate.PreviousOwner = Console.ReadLine();
                Pets[ID] = PetToUpdate;
                Console.WriteLine("Pet succesfully updated");
            }
        }
    }
}
