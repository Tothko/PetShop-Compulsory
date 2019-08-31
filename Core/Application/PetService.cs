using System;
using System.Collections.Generic;
using System.Text;
using Infrastrucute.Data;

namespace Core.Application
{
    class PetService : IPetService
        
    {
        readonly IPetRepository IPR;

        PetService(IPetRepository repo)
        {
            IPR = repo;
        }
 
        public List<Pet> GetPets()

        {
            List<Pet> Pets = new List<Pet>();
            foreach (var Pet in IPR.ReadPets())
            {
                Pets.Add(Pet);
            }
            return Pets;
        }
    }
}
