using System;
using System.Collections.Generic;
using System.Text;
using Core;


namespace Infrastrucute.Data
{
    public class PetRepository : IPetRepository 
    {
        
    
        
        public IEnumerable<Pet> ReadPets()
        {
            return FakeDB.Pets;
        }

       
    }

  
}
